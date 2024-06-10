namespace Assignment3_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Temperature Converter");
                    Console.WriteLine("Enter the current temperature:");

                    double temperature;
                    while (!double.TryParse(Console.ReadLine(), out temperature))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid temperature:");
                    }

                    Console.WriteLine("Select a conversion option:");
                    Console.WriteLine("1. Convert to Celsius");
                    Console.WriteLine("2. Convert to Fahrenheit");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            double celsius = ConvertToFahrenheit(temperature);
                            Console.WriteLine($"The temperature in Celsius is: {celsius}°C");
                            break;
                        case "2":
                            double fahrenheit = ConvertToCelsius(temperature);
                            Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}°F");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    Console.WriteLine("Do you want to perform another conversion? (yes/no)");
                    string continueChoice = Console.ReadLine().ToLower();
                    if (continueChoice != "yes")
                    {
                        break;
                    }
                }
            

            static double ConvertToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            static double ConvertToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }
        }
    }
}
