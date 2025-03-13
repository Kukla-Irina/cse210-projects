public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { 
        _name = name;
        _description = description;
        _points = points;
    }

    public override int RecordEvent()
    {
        _complete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_complete}";
    }

    public override string DisplayProgress()
{
    string completionStatus;
    if (_complete)
    {
        completionStatus = "X";
    }
    else
    {
        completionStatus = " ";
    }
    return $"[{completionStatus}] {_name} - {_description}";
}
}