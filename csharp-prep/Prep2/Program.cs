using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter = "F";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a {letter}");

        if (letter != "F")
        {
            Console.WriteLine($"You passed! Congrates!");
        }
        else
        {
            Console.WriteLine($"You didn't pass but better luck next time!");
        }


        

    }
}