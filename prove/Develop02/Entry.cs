using System;


public class Entry
{
    public string _date; //string DisplayDate()
    public string _promptText; //string DisplayPrompt()
    public string _entryText; //string DisplayEntryText()

    public string EntryResponse()
    {
        Console.Write("Date: ");
        string date = Console.ReadLine();
        Console.Write($"Prompt: {PromptGenerator.GetRandomPrompt()}");
        string prompt = Console.ReadLine();
        Console.Write("Entry: ");
        string entry = Console.ReadLine();
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Entry: {entry}");

        return $"date + prompt + entry";
    }



}