using System;

public class BreathingAct : Activity
{
    public static void BreathingDisplay(string _activityName, string _description)
    {   
        BreathingAct breathing = new BreathingAct();
        breathing.StartActivity(_activityName, _description);
        Console.WriteLine($"Breathing in... breathing.Countdown(_duration / 6)");
        Console.WriteLine("Breathing out... breathing.Countdown(_duration / 6)");
        Console.WriteLine($"Breathing in... breathing.Countdown(_duration / 6)");
        Console.WriteLine("Breathing out... breathing.Countdown(_duration / 6)");
        Console.WriteLine($"Breathing in... breathing.Countdown(_duration / 6)");
        Console.WriteLine("Breathing out... breathing.Countdown(_duration / 6)");
        Console.WriteLine("Congratulations! ");
        breathing.Spinner(5);
        Console.WriteLine("You have completed another " + breathing._duration + " seconds of the activity.");
    }

}