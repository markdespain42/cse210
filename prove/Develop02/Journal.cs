using System;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(string date, string prompt, string entry) {
        Entry newEntry = new Entry(date, prompt, entry);
        _entries.Add(newEntry);
    }
    public void DisplayPastEntries() {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
    public string SavingFile(string fileName) {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry.date()} | {entry.prompt()} | {entry.entry()}");
        }
        return "";
    } 
    public string LoadingFile(string filename) {
        foreach (Entry entry in _entries)
        {

        }

        return "";
    } 
}   