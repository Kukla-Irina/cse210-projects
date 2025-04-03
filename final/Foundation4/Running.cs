public class Running : Activity
{
    private double _speed;

    public Running(double lengthInMinutes, double speed) : base(lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
       return GetSpeed() * (GetTime() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }
}
