public class Cycling : Activity
{
    private double _speed;

    public Cycling(double lengthInMinutes, double speed) : base(lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override double GetDistance()
    {
        return GetSpeed() * (GetTime() / 60);
    }
}