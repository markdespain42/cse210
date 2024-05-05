using System;

partial class Program
{
    string randomPrompt = PromptGenerator.GetRandomPrompt();   

    static void Main(string[] args)
    {
        // Welcome to the Journaling Program
        Console.WriteLine("Welcome to the Journaling Program");
            // Journal class storing entries
            // Entry class representing and storing a single entry
            // PromptGenerator storing and supplying prompts
        // While loop to keep the following running
        int number = 1;
        do
        {
            Console.Write("Please select an option(type 'exit' to quit): ");
            string line = Console.ReadLine();

            Console.WriteLine("Options");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
    
            Console.WriteLine("What would you like to do? ");
            string option = Console.ReadLine();
            int newOption = int.Parse(option);
            if (newOption == 5)
            {
                number = 5;
            }
            else if (newOption == 1)
            {
                Entry.EntryResponse();
            }
            else if (newOption == 2)
            {
                Console.WriteLine("Displaying all entries: ");
                Journal.DisplayPastEntries();
            }
            else if (newOption == 3)
            {
                Console.WriteLine("Filename for loading? ");
                string fileName = Console.ReadLine();
                Journal.LoadingFile(fileName);
            }
            else if (newOption == 4)
            {
                Console.WriteLine("Filename to save? ");
                string fileName = Console.ReadLine();
                Journal.SavingFile(fileName);
            }
            Console.WriteLine(line);
        } while (number != 5);

        
    }

}