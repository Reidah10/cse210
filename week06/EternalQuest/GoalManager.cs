using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordGoal(int goalNumber)
    {
        Goal goal = _goals[goalNumber - 1];
        bool wasComplete = goal.IsComplete();

        if (goal.RecordEvent())
        { 
            _score += goal.GetPoints();

            if (!wasComplete && goal.IsComplete() && goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                _score += checklistGoal.GetBonus();
            }
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;

                    outputFile.WriteLine(
                        $"S|{simpleGoal.GetName()}|{simpleGoal.GetDescription()}|{simpleGoal.GetPoints()}|{simpleGoal.IsDaily()}|{simpleGoal.GetLastCompleted()}"
                        );  
                }
                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;

                    outputFile.WriteLine(
                        $"E|{eternalGoal.GetName()}|{eternalGoal.GetDescription()}|{eternalGoal.GetPoints()}"
                        );
                }

                else if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;

                    outputFile.WriteLine(
                        $"C|{checklistGoal.GetName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetPoints()}|{checklistGoal.GetTargetAmount()}|{checklistGoal.GetBonus()}|{checklistGoal.GetAmountCompleted()}"
                        );
                }
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            _score = int.Parse(inputFile.ReadLine());
            _goals.Clear();

            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                if (parts[0] == "S")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isDaily = bool.Parse(parts[4]);
                    DateTime lastCompleted = DateTime.Parse(parts[5]);

                    SimpleGoal goal = new SimpleGoal(name, description, points, isDaily);

                    goal.SetLastCompleted(lastCompleted);
                    _goals.Add(goal);
                }
                else if (parts[0] == "E")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }

                else if (parts[0] == "C")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int targetAmount = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, targetAmount, bonus);
                    goal.SetAmountCompleted(amountCompleted);
                    _goals.Add(goal);
                }
            }
        }
    }
}