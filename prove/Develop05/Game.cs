using System;
using System.Collections.Generic;
public class Game
{
    private int _totalPoints;
    private List<Goals> _listOfGoals = new List<Goals>();
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SaveFile()
    {
        Console.Write("Please, enter the fileName: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goals goal in _listOfGoals)
            {
                string pipString = goal.SaveGoal();
                outputFile.WriteLine(pipString);
            }
        }
        Console.WriteLine("File saved!");
    }
    public void LoadFile()
    {
        Console.Write("Please, enter the fileName: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoals simpleGoal = new SimpleGoals(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _listOfGoals.Add(simpleGoal);
            }
            else if (parts[0] == "EthernalGoal")
            {
                EthernalGoals ethernalGoal = new EthernalGoals(parts[1], parts[2], int.Parse(parts[3]));
                _listOfGoals.Add(ethernalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoals checklistGoal = new ChecklistGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]),int.Parse(parts[6]) ,bool.Parse(parts[7]));
                _listOfGoals.Add(checklistGoal);
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Ethernal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Wich type of goal would you like to create?: ");

        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
            SimpleGoals simpleGoal = new SimpleGoals("", "", 0, false);
            simpleGoal.SetGoal();
            Console.WriteLine();
            _listOfGoals.Add(simpleGoal);
        }
        else if (userInput == "2")
        {
            EthernalGoals ethernalGoal = new EthernalGoals("", "", 0);
            ethernalGoal.SetGoal();
            Console.WriteLine();
            _listOfGoals.Add(ethernalGoal);
        }
        else if (userInput == "3")
        {
            ChecklistGoals checklistGoal = new ChecklistGoals("", "", 0, 0, 0, 0,false);
            checklistGoal.SetGoal();
            Console.WriteLine();
            _listOfGoals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("That's not a valid option, please try again");
        }
    }
    public void DisplayGoalList()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goals goal in _listOfGoals)
        {
            Console.Write($"  {i}. ");
            goal.DisplayGoal();
            i++;
        }
    }
    public void RecordEvent()
    {
        DisplayGoalList();
        Console.Write("Which goal did you accomplish?: ");
        int index = int.Parse(Console.ReadLine())-1;
        Goals goal = _listOfGoals[(index)];
        if (goal is SimpleGoals simpleGoal)
        {
            if (simpleGoal.IsCompleted())
            {
                Console.WriteLine("Sorry, you have already reached this task, try creating a new goal");
            }
            else
            {
                simpleGoal.OneTimeAccomplish();
                _totalPoints = _totalPoints + simpleGoal.GetPoints();
            }
        }
        else if (goal is EthernalGoals ethernalGoal)
        {
            ethernalGoal.OneTimeAccomplish();
            _totalPoints = _totalPoints + ethernalGoal.GetPoints();
        }
        else if (goal is ChecklistGoals checklistGoal)
        {
            int timesDoneCheck = checklistGoal.GetTimesDone()+1;
            if (timesDoneCheck == checklistGoal.GetTimesToComplete())
            {
                _totalPoints = _totalPoints + checklistGoal.GetPoints();
                _totalPoints = _totalPoints + checklistGoal.GetBonus();
            }
            else if (timesDoneCheck < checklistGoal.GetTimesToComplete())
            {
                _totalPoints = _totalPoints + checklistGoal.GetPoints();
            }
            checklistGoal.OneTimeAccomplish();
        }
    }
}