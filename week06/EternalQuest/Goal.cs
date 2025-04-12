﻿public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetails()
    {

        return $"{_name} ({_description})  {_points} points";
    }

    public abstract string GetString();
}