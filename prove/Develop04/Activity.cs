using System;
using System.Net.Quic;

public class Activity
{
    public string _activityName;
    public string _description;
    public int _duration;
    public DateTime _startTime;
    public DateTime _endTime;
    ReflectingAct reflecting = new ReflectingAct();
    BreathingAct breathing = new BreathingAct();
    ListingAct listing = new ListingAct();
    public Activity()
    {
        int i = 0;
        while (i < 1) {
        _startTime = DateTime.Now;
        _endTime = DateTime.Now;
        Console.WriteLine("What would you like to do? (1-4)");
        Console.WriteLine("1. Reflecting");
        Console.WriteLine("2. Breathing");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");
        string option = Console.ReadLine();
        int newOption = int.Parse(option);
        if (newOption == 1)
        {
            _activityName = "Reflecting activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            reflecting.ReflectDisplay(_activityName, _description);
            reflecting.EndActivity();
        }
        else if (newOption == 2)
        {
            _activityName = "Breathing activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            breathing.BreathingDisplay(_activityName, _description);
            breathing.EndActivity();
        }
        else if (newOption == 3)
        {
            _activityName = "Listing activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            listing.ListingDisplay(_activityName, _description);
            listing.EndActivity();
        }
        else if (newOption == 4)
        {
            i = 1;
        }
        }
        
    }

    public int StartActivity(string _activityName, string _description)
    {
        DateTime _startTime = DateTime.Now;
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Countdown(_duration);
        Console.WriteLine();

        return _duration;
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity.");
        _endTime = DateTime.Now;
    }
    public void Countdown(int __duration)
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinner(int _duration)
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

}