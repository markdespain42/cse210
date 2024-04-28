using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;
        int total = 0;
        int largestNumber = 0;

        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            else 
            {
                number = 0;
            }
        }
        foreach (int standardNumber in numbers)
        {
            Console.WriteLine(standardNumber);
            total += standardNumber;
            if (standardNumber > largestNumber)
            {
                largestNumber = standardNumber;
            }

        }

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}