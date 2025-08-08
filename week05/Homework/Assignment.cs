using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor that sets student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // This method returns a summary with the student name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // This method provides access to the student name for derived classes
    public string GetStudentName()
    {
        return _studentName;
    }
}
