using System;

public class WordRandom
{
    private string _word;
    private Random random = new Random();
    string[] txt = {"For", "God", "so", "loved", "the", "world", "that", "he", "gave", "his", "only", "begotten", "Son,", "that", "whosoever", "believeth", "in", "him", "shall", "not", "perish,", "but", "have", "everlasting", "life."};

    public string GetRandomWord()
    {
        _word = txt[random.Next(0, txt.Length)];
        return _word;
    }
    public string MakeUnderline(string wordRandom)
    {
        string underline = "";
        for (int i = 0; i < _word.Length; i++)
        {
            underline += "_";

        }
        return underline;
    }

}