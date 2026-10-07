// I added a feature for the program to be able to check if a goal is a daily goal to be completed once a day. If it has already been completed the program encourages the user to work on another goal.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            goalManager.DisplayScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal(goalManager);
            }

            else if (choice == 2)
            {
                goalManager.DisplayGoals();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter a filename to save.");
                string fileName = Console.ReadLine();
                goalManager.SaveGoals(fileName);
                Console.WriteLine($"Goals saved to {fileName}");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter a filename to load: ");
                string fileName = Console.ReadLine();
                goalManager.LoadGoals(fileName);
                Console.WriteLine($"Goals loaded from {fileName}");
            }

            else if (choice == 5)
            {
                goalManager.DisplayGoals();

                Console.Write("Which goal did you accomplish? ");
                int goalNumber = int.Parse(Console.ReadLine());

                goalManager.RecordGoal(goalNumber);
            }

            else if (choice == 6)
            {
                Console.WriteLine("Thanks for using the EternalQuest Goal Manager! Goodbye!");
                break;
            }
        }
    }

    static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            Console.Write("Is this a daily goal? (yes/no): ");
            string dailyInput = Console.ReadLine();
            bool isDaily = dailyInput.ToLower() == "yes";

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isDaily);
            goalManager.AddGoal(simpleGoal);
        }
        else if (goalType == 2)
        {
            Goal eternalGoal = new EternalGoal(name, description, points);
            goalManager.AddGoal(eternalGoal);
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetAmount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetAmount, bonus);
            goalManager.AddGoal(checklistGoal);
        }
    }
}