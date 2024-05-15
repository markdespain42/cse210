using System;

public class BreathingAct
{
    public string _text;
    public static void Display()
    {
        Console.WriteLine("This activity is designed you help you relax and focus on your breathing.");

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        int time = int.Parse(seconds);

        for (int i = time; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        
    }
}