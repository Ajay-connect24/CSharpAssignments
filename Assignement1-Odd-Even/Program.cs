namespace Assignement1_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int targetNumber;
            Console.Clear();
            Console.WriteLine("Program to print all Odd / Even numbers below a target number ");
            Console.Write("Enter target number : ");


            while (!int.TryParse(Console.ReadLine(), out  targetNumber) || targetNumber <= 0) 
            {
                Console.WriteLine("Invalid Input ! Enter a postitive integer ");
            }

            
            Console.WriteLine("Choose an option \n 1.Odd \n 2.Even \n Enter : ");
            string choice = Console.ReadLine().ToLower().Trim();


            if (choice == "odd")
            {
                Console.WriteLine($"The odd numbers below {targetNumber} are : ");

                for (int i = 1; i < targetNumber; i += 2)
                {
                    Console.Write($"  {i} , ");


                }
                Console.Write("\b\b");
            }
            else 
            {
                Console.WriteLine($"The even numbers below {targetNumber} are : ");

                for (int i = 0; i < targetNumber; i += 2)
                {
                    Console.Write($"  {i} , ");


                }
                Console.Write("\b\b");

            }
        }
    }
}