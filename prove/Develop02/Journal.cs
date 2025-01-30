public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }


    public void LoadFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            JournalEntry entry = new JournalEntry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._respond = parts[2];
            _entries.Add(entry);
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._respond}");
            }
        }
    }
}