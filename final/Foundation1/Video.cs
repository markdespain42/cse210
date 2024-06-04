using System;

public class Video {
    private string _title;
    private string _author;
    private int _length;
    public List<string> _videoList;

    public string VideoInfo(string title, string author, int length) {
        _title = title;
        _length = length;
        _author = author;
        _videoList.Add(VideoInfo(_title, _author, _length));
        return $"{_title}, {_author} ({_length} seconds)";
    }
    public void Display() {
        Console.WriteLine(_videoList);

    }

}