using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor receives all values and passes studentName and topic to base class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // This method returns the homework details
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
