using System;
using System.Runtime.CompilerServices;

public class Comment {

    private string _text;
    private string _author;
    private string _date;

    public List<string> _commentList;

    public string CommentInfo(string text, string author, string date) {
        _text = text;
        _author = author;
        _date = date;

        _commentList.Add(CommentInfo(_text, _author, _date));
        return $"{_date} - {_author}: {_text}";
    }
    public void Display(List<string>_commentList) {
        Console.WriteLine($"{_date} - {_author}: {_text}");
    }

}