public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string type, string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(type, title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void GetFullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_address.GetFullAddress()}");
        Console.WriteLine($"Email: ({_rsvpEmail})");
    }
}
