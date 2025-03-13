public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public abstract string DisplayProgress();
}