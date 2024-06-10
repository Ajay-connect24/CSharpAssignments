namespace Assignment4_PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Palindrome Checker");
                Console.WriteLine("Enter a value:");

                string input = Console.ReadLine();

                if (IsPalindrome(input))
                {
                    Console.WriteLine($"{input} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome.");
                }

                Console.WriteLine("Do you want to check another value? (yes/no)");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                {
                    break;
                }
            }
        }

        static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
