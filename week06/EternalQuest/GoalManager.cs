using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void AddSimpleGoal(string name, string description, int points)
    {
        SimpleGoal goal = new SimpleGoal(name, description, points);
        _goals.Add(goal);
    }
    private void AddSimpleGoal(string name, string description, int points, bool isComplete)
    {
        SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
        _goals.Add(goal);
    }

    
    public void AddEternalGoal(string name, string description, int points)
    {
        EternalGoal goal = new EternalGoal(name, description, points);
        _goals.Add(goal);
    }
    
    
    public void AddChecklistGoal(string name, string description, int target, int points, int bonus)
    {
        ChecklistGoal goal = new ChecklistGoal(name, description, target, points, bonus);
        _goals.Add(goal);
    }
    private void AddChecklistGoal(string name, string description, int target, int points, 
        int bonus, int count)
    {
        ChecklistGoal goal = new ChecklistGoal(name, description, target, points, bonus, count);
        _goals.Add(goal);
    }

    
    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            string checkbox = "[ ]";
            if (goal.IsComplete())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                checkbox = "[X]";
            }
            Console.WriteLine($"{checkbox} {goal.GetDetails()}");
            Console.ResetColor();
        }
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                sw.WriteLine($"{goal.GetString()}");
            }
        }
    }

    public void LoadGoals(string file)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
       
        foreach (string line in lines)
        {
            string[] data = line.Split(",");
            string type = data[0];
            string name = data[1];
            string description = data[2];
            if (type == "simple")
            {
                int points = int.Parse(data[3]);
                bool isComplete = bool.Parse(data[4]);
                AddSimpleGoal(name, description, points, isComplete);
            }

            if (type == "eternal")
            {
                int points = int.Parse(data[3]);
                AddEternalGoal(name, description, points);
            }

            if (type == "check")
            {
                int target = int.Parse(data[3]);
                int points = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);
                int count = int.Parse(data[6]);
                
                AddChecklistGoal(name, description, target, points, bonus, count);
            }
        }
    }

    public void RecordEvent()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            string data = goal.GetString();
            string[] info = data.Split(",");
            Console.WriteLine($"{i + 1}. {info[1]}");
            i += 1;
        }
        Console.Write("Which goal did you accomplish?");
        int choice = int.Parse(Console.ReadLine());
        Goal item = _goals[choice - 1];
        if (item.IsComplete() == false)
        {
            int points = item.RecordEvent();
            _score += points;
        }
        else
        {
            Console.WriteLine("That goal is already completed.");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine("");
    }
}