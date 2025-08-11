using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _category; // Exceed requirement feature: Category for goal

    public Goal(string shortName, string description, int points, string category)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _category = category;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetCategory() // Exceed requirement: returns category
    {
        return _category;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}
