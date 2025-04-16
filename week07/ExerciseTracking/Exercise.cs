public abstract class Exercise
{
    protected int _length;
    private string _date;
    private string _activity;

    public Exercise(int length, string date, string activity)
    {
        _length = length;
        _date = date;
        _activity = activity;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activity} ({_length}) - Distance: {GetDistance()} miles, " +
               $"Speed: {GetSpeed()} mph, Pace: {GetPace()} minutes per mile";
    }
}