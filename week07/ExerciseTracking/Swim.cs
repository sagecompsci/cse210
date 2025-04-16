public class Swim : Exercise
{
    private int _laps;
    
    public Swim(int length, string date, string activity, int laps)
        : base(length, date, activity)
    {
        _laps = laps;
    }
    
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}