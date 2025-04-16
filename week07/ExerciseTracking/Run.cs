public class Run : Exercise
{
    private double _distance;

    public Run(int length, string date, string activity, double distance)
        : base(length, date, activity)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}