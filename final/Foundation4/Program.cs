using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running();
        Activity cycling = new Cycling();
        Activity swimming = new Swimming();
        
        List<Activity> activities = new List<Activity> {running, cycling, swimming};
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}