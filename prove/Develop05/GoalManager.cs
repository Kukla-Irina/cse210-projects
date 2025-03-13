public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new();

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
       Goal goal = _goals.FirstOrDefault(g => g.GetName() == goalName);
        if (goal == null)
        {
            Console.WriteLine($"Goal with name '{goalName}' does not exist.");
            return;
        }

        _score += goal.RecordEvent();
        Console.WriteLine($"Event recorded for goal: {goal.GetName()}");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("");
        Console.WriteLine("The goals are: ");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.DisplayProgress());
        }
    }

    public void SaveProgress(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadProgress(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])));
                    break;
            }
        }
    }
}