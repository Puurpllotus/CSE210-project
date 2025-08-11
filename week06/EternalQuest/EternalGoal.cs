using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points, string category)
        : base(shortName, description, points, category)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_category}";
    }
}
