using System;

class Program
{
    
    static void Main(string[] args)
    {
        string scriptureText = "For God so loved the world that he gave his only begotten Son, that whosoever he had shall not perish but have everlasting life.";
        Reference reference = new Reference("John 3:16");
        reference.Display();

        Scripture scripture = new Scripture(reference, scriptureText);
        scripture.Display();

        WordRandom wordRandom = new WordRandom();


        for (int i = 0; i < wordRandom.GetRandomWord().Length; i++)
        {
            string randomWord = wordRandom.GetRandomWord();
            string underlinedWord = wordRandom.MakeUnderline(randomWord);

            Console.WriteLine("Press any key to continue or 'q' to quit...");
            var key = Console.ReadKey();

            if (key.KeyChar == 'q')
            {
                break;
            }

    }
}
}