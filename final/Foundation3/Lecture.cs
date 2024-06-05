using System;

public class Lecture : Event {

    private string _speaker;
    private string _topic;
    private int _capacity;

    public string LectureInfo(string title, string description, string time, string date, string speaker, string topic) {
        _speaker = speaker;
        _topic = topic;

        return $"{title}, {description}, {time}, {date}, {speaker}, {topic}";
    }

    public string Speaker(string speaker) {
        _speaker = speaker;
        return _speaker;
    }

    public string Capacity(int capacity) {
        _capacity = capacity;
        return $"{capacity}";
    }
}