using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome to the Journaling Program
        Console.WriteLine("Welcome to the Journaling Program");
            // Journal class storing entries
            // Entry class representing and storing a single entry
            // PromptGenerator storing and supplying prompts
        // While loop to keep the following running
        while (true)
        {
            Console.Write("Please select an option(type 'exit' to quit): ");
            string line = Console.ReadLine();

            //Options
            //1. Write
            //2. Display
            //3. Load
            //4. Save
            //5. Quit
            Console.WriteLine("What would you like to do? ");
            string option = Console.ReadLine();
            int newOption = int.Parse(option);
            if (newOption == 5)
            {
                break;
            }
            Console.WriteLine(line);
        }

        
    }

}