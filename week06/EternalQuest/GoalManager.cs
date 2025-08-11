using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private Dictionary<string, int> _categoryScores = new Dictionary<string, int>(); // Exceed requirement

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYour score: {_score}");
            Console.WriteLine("Category scores:"); // Exceed requirement display
            foreach (var category in _categoryScores)
            {
                Console.WriteLine($" - {category.Key}: {category.Value} points");
            }

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordGoalEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("Enter category (e.g., Health, Learning, Fitness): "); // Exceed requirement
        string category = Console.ReadLine();

        if (!_categoryScores.ContainsKey(category))
        {
            _categoryScores[category] = 0;
        }

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points, category));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points, category));
        }
        else if (type == "3")
        {
            Console.Write("Enter target completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, category));
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];
            string status = g.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {g.GetDetailsString()} ({g.GetCategory()})");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _goals.Clear();
            _categoryScores.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string type = parts[0];
                if (type == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[5]));
                    if (bool.Parse(parts[4])) ((SimpleGoal)_goals[_goals.Count - 1]).RecordEvent();
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4]));
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                         int.Parse(parts[5]), int.Parse(parts[4]), parts[7]);
                    int completed = int.Parse(parts[6]);
                    for (int c = 0; c < completed; c++)
                        cg.RecordEvent();
                    _goals.Add(cg);
                }
                if (!_categoryScores.ContainsKey(parts[parts.Length - 1]))
                {
                    _categoryScores[parts[parts.Length - 1]] = 0;
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    private void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("Enter goal number: ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;

        if (goalNum >= 0 && goalNum < _goals.Count)
        {
            int points = _goals[goalNum].RecordEvent();
            _score += points;
            string category = _goals[goalNum].GetCategory();
            _categoryScores[category] += points; // Exceed requirement: update category score
            Console.WriteLine($"Event recorded! You earned {points} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}
