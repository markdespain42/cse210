using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        string response = "no";

        while (response == "no")
        {
        Console.WriteLine("What is your guess (1-100)? ");
        string newGuess = Console.ReadLine();
        int newGuessNumber = int.Parse(newGuess);
        if (magicNumber == newGuessNumber)
        {
            Console.WriteLine("You guessed it!");
            response = "yes";
        }
        else if (magicNumber > newGuessNumber)
        {
            Console.WriteLine("Higher");
            response = "no";
        }
        else if (magicNumber < newGuessNumber)
        {
            Console.WriteLine("Lower");
            response = "no";
        }
        }
    }
}