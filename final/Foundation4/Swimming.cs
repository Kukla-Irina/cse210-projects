class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; 
    }
}