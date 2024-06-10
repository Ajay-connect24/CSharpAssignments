using System.Linq.Expressions;

namespace Assignment2_Calculator
{
    internal class Program
    {
        static void Main(string[] args) { 

        while (true) 
        {

            int option;
            double firstNumber;
            double secondNumber;
            string continueChoice;
            Console.Clear();

            Console.WriteLine("Calculator\n");

            Console.WriteLine("Choose the operation \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Division \n 5.Exit");
            Console.Write("Enter an option : ");

                while (!int.TryParse(Console.ReadLine(), out  option) || (1 > option) || option > 5 )
            {
                Console.WriteLine("\"Invalid Input ! Reenter a value between 1 to 5  \"");
            
            }
            if (option == 5) { break; }


            Console.Write("Enter the first number : ");
            while (!double.TryParse(Console.ReadLine(), out  firstNumber) )
            {
                Console.WriteLine("\"Invalid Input !Please reenter  a number \"");

            }
            Console.Write("Enter the second number : ");
            while (!double.TryParse(Console.ReadLine(), out  secondNumber))
            {
                Console.WriteLine("\"Invalid Input ! Please reenter a number \"");

            }

            switch(option)
            {
                case 1:Add(firstNumber,secondNumber);
                    break;
                case 2:
                    Subtract(firstNumber, secondNumber);
                    break;
                case 3:
                    Multiply(firstNumber, secondNumber);
                    break;
                case 4:
                    Divide(firstNumber, secondNumber);
                    break;
                default :
                        Console.WriteLine("Unhandled Exception");
                    break;



            }
                Console.WriteLine("Do you want to perform another operation? (yes/no)");
                continueChoice = Console.ReadLine().ToLower();

                while (continueChoice != "no" && continueChoice!= "yes")
                {
                    Console.WriteLine("Invalid input ,Reenter yes/no");
                    continueChoice = Console.ReadLine().ToLower();
                }
                if (continueChoice == "no") { 
                    break;
                    
                }








            }
	

	}

        private static void Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0) Console.WriteLine("Error: Division by zero is not allowed.");
            else Printer(firstNumber / secondNumber);
        }

        private static void Multiply(double firstNumber, double secondNumber)
        {
            Printer(firstNumber * secondNumber);
        }

        private static void Subtract(double firstNumber, double secondNumber)
        {
            Printer(firstNumber - secondNumber);
        }

        private static void Add(double firstNumber, double secondNumber)
        {
            Printer(firstNumber+secondNumber);
        }

        private static void  Printer(double result) 
        { 
            Console.WriteLine($"The result of the operation is : {result}");
        }

    }
}
