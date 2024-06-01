using System;
using System.Runtime.CompilerServices;
public class ReflectingAct : Activity {

    private static Random random = new Random();
    public List<string> _prompts;
    public string _response;

    public static string DisplayPrompts(string _prompt) {
        Console.WriteLine(_prompt);
        string _response = Console.ReadLine();

        return _response;
    }

    public static string GetRandomPrompt() {
        string[] _prompts = {
            "What would you want to be when you grow up?",
            "What happened?",
            "Why did you do it?",
            "How did you feel?",
            "Would you do it again if you had the chance?",
        };
        return _prompts[random.Next(0, _prompts.Length)];
    }
    public static void ReflectDisplay(string _activityName, string _description) {
        ReflectingAct reflecting = new ReflectingAct();
        reflecting.StartActivity(_activityName, _description);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(" --- " + "Think of a time when you stood up for someone else." + " --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they will help you reflect on the experience.");
        Console.WriteLine($"You may begin: reflecting.Countdown(5)");
        while (reflecting._duration > 0) {
            Console.WriteLine(" --- " + GetRandomPrompt() + " --- ");
            reflecting.Spinner(5);
            reflecting._duration--;
        }
        }

}