public abstract class Activity
{
    private string _date;
    private double _lengthInMinutes;

    public Activity(double lengthInMinutes)
    {
         _date = DateTime.Now.ToShortDateString();
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public double GetTime() 
    {
        return _lengthInMinutes;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {GetType()} ({_lengthInMinutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F1} min per km";
    }
}