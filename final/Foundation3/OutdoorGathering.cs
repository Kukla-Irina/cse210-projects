class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string type, string title, string description, string date, string time, Address address, string weatherForecast)
        : base(type, title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public void GetFullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_address.GetFullAddress()}");
        Console.WriteLine($"Weather: {_weatherForecast}");
    }
}