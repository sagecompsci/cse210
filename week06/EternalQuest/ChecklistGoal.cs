public class ChecklistGoal : Goal
{
    private int _count;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int target, int points, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int target, int points, int bonus, int count) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You earned {_points} points!");
        _count += 1;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations!! You have compeleted your goal " +
                              $"{_target} times!");
            Console.WriteLine($"You have earned {_bonus} bonus points!");
            _points += _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        if (_count == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetails()
    {
        return $"{_name} ({_description}) {_points} points - Completed ({_count}/{_target})";
    }

    public override string GetString()
    {
        return $"check,{_name},{_description},{_target},{_points},{_bonus},{_count}";
    }
}