using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Weclome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}.");
        }

        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
        
    }
}