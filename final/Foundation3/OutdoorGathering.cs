class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this._weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}