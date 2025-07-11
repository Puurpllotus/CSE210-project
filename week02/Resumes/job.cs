using System;

public class mainJob
{
    public string _JobTitle;
    public string _Company;
    public int _StartYear;
    public int _EndYear;

    public mainJob(string jobTitle, string company, int startYear, int endYear)
    {
        _JobTitle = jobTitle;
        _Company = company;
        _StartYear = startYear;
        _EndYear = endYear;
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_JobTitle} ({_Company}) {_StartYear}-{_EndYear}");
    }
}
