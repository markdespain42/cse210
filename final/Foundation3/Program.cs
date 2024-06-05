using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    Event eventstuff = new Event();

    static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine(program.eventstuff.StandardDetails("Outdoor", "Come on in and celebrate Madison's birthday with some fun!","01/01/2020","12:00", "123 Main St."));
        Console.WriteLine(program.eventstuff.FullDetails("Lecture", "Come to the lecture of Mr. and Mrs. Smith!", "01/02/2022", "6:00", " 142 Heights Rodeway"));
        Console.WriteLine(program.eventstuff.FullDetails("Reception", "Come to the wedding of Matt and Madi!", "01/05/2023", "3:00", "542 South St."));
        Console.WriteLine(program.eventstuff.FullDetails("Outdoor", "Come on out and celebrate Madison's birthday with some fun!","01/01/2020","12:00", "123 Main St."));
        Console.WriteLine(program.eventstuff.ShortDescription("Reception", "Marriage of Matt and Madi!", "01/05/2023"));
    }
}