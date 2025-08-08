using System;

public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor — passes studentName and topic to the base class constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // This method returns the writing assignment details
    public string GetWritingInformation()
    {
        // Accessing the student name through a public method in the base class
        return $"{_title} by {GetStudentName()}";
    }
}
