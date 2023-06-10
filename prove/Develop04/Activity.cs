using System;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _lengthTime;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void SetDuration(int lengthTime)
    {
        _lengthTime = lengthTime;
    }
    public int GetDuration()
    {
        return _lengthTime;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void DisplaySpinner(int timeToRun)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(timeToRun);

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        while (DateTime.Now < end)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"\n{_description}\n");
        Console.Write("How long, in seconds, would you like for this session?: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        GetReady();
    }
    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        DisplaySpinner(8);
    }
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner(6);
        Console.WriteLine($"\nYou have completed another {_lengthTime} seconds of the {_name}.");
        DisplaySpinner(6);
        Console.Clear();
    }
    public void CountdownAnimation(int number)
    {
        while(number > 0)
        {
            Console.Write(number);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            number--;
        }
        Console.WriteLine();
    }
    public int GetRandomIndex(List<string> list)
    {
        Random random = new Random();
        int randomIndex = random.Next(list.Count);
        return randomIndex;
    }
}