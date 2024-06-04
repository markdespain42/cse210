using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        Comment comment = new Comment();
        Console.WriteLine(video.VideoInfo("Last to take their hand off of an airplane gets it", "MrBeast", 30));
        Console.WriteLine(comment.CommentInfo("Great video", "RandomUser", "1/1/2020"));
        Console.WriteLine(comment.CommentInfo("I love what you did at 4:47", "AnotherUser", "1/4/2020"));
        Console.WriteLine(comment.CommentInfo("I hate that you act like a child", "YetAnotherUser", "1/5/2020"));
        Console.WriteLine(video.VideoInfo("The Best of Smii7y", "Smii7y", 60));
        Console.WriteLine(comment.CommentInfo("Wow! The effort that you put into this was amazing", "GreatScott", "2/15/2020"));
        Console.WriteLine(comment.CommentInfo("I can't wait to see what you do with the rest of your life", "CrazySteve", "2/17/2020"));
        Console.WriteLine(comment.CommentInfo("You and your friends crack me up", "ShoppingCartHero23", "2/18/2020"));
        Console.WriteLine(video.VideoInfo("Legend of Zelda: Ocarina of Time Walkthrough", "Link", 30));
        Console.WriteLine(comment.CommentInfo("I love the input and help", "LinkRunner53", "2/20/2020"));
        Console.WriteLine(comment.CommentInfo("Wow! I really enjoyed the whole thing", "MasterSword126", "2/21/2020"));
        Console.WriteLine(comment.CommentInfo("I hate the whole thing", "HospitibalGuy", "2/22/2020"));
    }
}