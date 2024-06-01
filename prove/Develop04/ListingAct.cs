using System;

public class ListingAct : Activity
{
    public List<string> _prompt;
    public int _count;
    
    public static void ListingDisplay(string _activityName, string _description)
    {
        ReflectingAct reflecting = new ReflectingAct();
        ListingAct listing = new ListingAct();
        listing.StartActivity(_activityName, _description);
        
        Console.WriteLine("List everything you can about the following prompt: ");
        Console.WriteLine(" -- " + "Think of a time you stood up for someone else. " + " -- ");
        Console.WriteLine();
        Console.WriteLine($"You may begin: listing.Countdown(5)");
        while (listing._duration > 0) {
            Console.Write(">");
            string response = Console.ReadLine();
            listing._prompt.Add(response);
            listing._duration--;
        }
        Console.WriteLine($"You listed {listing._prompt.Count} items. ");
        Console.WriteLine("Congratulations!");
        listing.Spinner(5);
        Console.WriteLine("You have completed another " + listing._duration + " seconds of the activity.");
        

        
    }
}