public class ChecklistGoal : Goal
{
    private int _target { get; set; }
    private int _current { get; set; }
    private int _bonus { get; set; }

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _current++;
        if (_current >= _target)
        {
            _complete = true;
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_current}";
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
        return $"[{completionStatus}] {_name} - {_description} (Completed {_current}/{_target} times)";
    }
}