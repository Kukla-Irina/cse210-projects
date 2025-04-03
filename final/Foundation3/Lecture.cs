class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GetFullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_address.GetFullAddress()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"The capacity is: {_capacity}");
    }
}