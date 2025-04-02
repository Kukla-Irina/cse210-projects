class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLenthInMinutes()) / 60;
    }
}