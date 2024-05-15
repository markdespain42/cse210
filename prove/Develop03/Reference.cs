public class Reference
{
    private string _referenceText;
    public Reference(string referenceText)
    {
        _referenceText = referenceText;
    }
    public void Display()
    {
        Console.WriteLine(_referenceText);
    }
}