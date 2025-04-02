class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}
