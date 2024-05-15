
public class Scripture
{
    private string _scriptureText;
    private Reference _reference = new Reference("John 3:16");
    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _scriptureText = text;
    }
    public void Display()
    {
        Console.WriteLine(_scriptureText);
    }
    

}