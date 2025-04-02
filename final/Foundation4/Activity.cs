class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        this._date = date;
        this._lengthInMinutes = lengthInMinutes;
    }

    public int GetLenthInMinutes() {
        return _lengthInMinutes;
    }
    
    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _lengthInMinutes) * 60;
    }

    public virtual double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F1} min per km";
    }
}