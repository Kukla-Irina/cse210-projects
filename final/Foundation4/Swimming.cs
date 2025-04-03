public class Swimming : Activity
{
    private double _laps;

    public Swimming(double lengthInMinutes, int laps) : base(lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetTime() / 60);
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }
}