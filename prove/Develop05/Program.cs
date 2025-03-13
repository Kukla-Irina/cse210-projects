using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {   

            Console.WriteLine("");
            goalManager.DisplayScore();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    SaveProgress(goalManager);
                    break;
                case "4":
                    LoadProgress(goalManager);
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please choose a number between 1 and 7.");
                    break;
            }
        }
    }

    static void AddGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal type\n1. Simple\n2. Eternal\n3. Checklist");
        Console.Write("\nWhich type goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, description, points, bonusPoints, targetCount));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        goalManager.RecordEvent(name);
    }

    static void SaveProgress(GoalManager goalManager)
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        goalManager.SaveProgress(filename);
    }

    static void LoadProgress(GoalManager goalManager)
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        goalManager.LoadProgress(filename);
    }

}