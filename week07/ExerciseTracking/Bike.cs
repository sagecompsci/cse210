public class Bike : Exercise
{
    private int _speed;
    
    public Bike(int length, string date, string activity, int speed)
        : base(length, date, activity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }
}