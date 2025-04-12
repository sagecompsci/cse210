public class EternalGoal : Goal
{
    private int _points;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _points = points;
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetString()
    {
        return $"eternal,{_name},{_description},{_points}";
    }
}