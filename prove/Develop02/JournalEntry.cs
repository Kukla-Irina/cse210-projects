public class JournalEntry
{
    public string _date = "";
    public string _prompt = "";
    public string _respond = "";


    public void Display()
    {
        Console.WriteLine($"Date {_date} - {_prompt}");
        Console.WriteLine(_respond);
        Console.WriteLine();
    }
}