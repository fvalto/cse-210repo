public class ChecklistGoals : Goals
{
    private int _bonus;
    private int _timesDone;
    private int _timesToComplete;
    public ChecklistGoals(string name, string description, int points, int timesDone, int timesToComplete, int bonus,bool isCompleted): base(name, description, points)
    {
        SetTypeOfGoal("ChecklistGoal");
        _timesDone = timesDone;
        _timesToComplete = timesToComplete;
        _bonus = bonus;
        SetIsCompleted(isCompleted);
    }
    public int GetTimesDone()
    {
        return _timesDone;
    }
    public void SetTimesDone(int timesDone)
    {
        _timesDone = timesDone;
    }
    public int GetTimesToComplete()
    {
        return _timesToComplete;
    }
    public void SetTimesToComplete(int timesToComplete)
    {
        _timesToComplete = timesToComplete;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override string SaveGoal()
    {
        return $"{GetTypeOfGoal()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTimesDone()}|{GetTimesToComplete()}|{GetBonus()}|{IsCompleted()}";
    }
    // public override string DisplayGoal()
    // {
    //     return $"{GetCheckMark()} {GetName()} {GetDescription()} -- Currently {GetTimesDone()}/{GetTimesToComplete()}";
    // }
    public override void DisplayGoal()
    {
        char checkMark = GetCheckMark();
        string name = GetName();
        string description = GetDescription();
        int timesDone = GetTimesDone();
        int timesToComplete = GetTimesToComplete();
        string fullDisplay = $"[{checkMark}] {name}: {description} -- Currently {timesDone}/{timesToComplete}";
        Console.WriteLine(fullDisplay);
    }
    public override void OneTimeAccomplish()
    {
        if (_timesDone < _timesToComplete)
        {
            _timesDone ++;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
            if (_timesDone == _timesToComplete)
            {
                SetIsCompleted(true);
                Console.WriteLine("You have completed the goal!");
                Console.WriteLine($"Now you will get the {_bonus} bonus");
            }
        }
        else if (_timesDone >= _timesToComplete)
        {
            Console.WriteLine("Sorry, you have already reached this task, try creating a new goal");
        }
    }
    public override void SetGoal()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("Give a short description of it: ");
        string description = Console.ReadLine();
        SetDescription(description);

        Console.Write("What is the base amount of points associated to this goal?: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);

        Console.Write("How many times does this goal needs to be accomplished for a bonus: ");
        int timesToComplete = int.Parse(Console.ReadLine());
        SetTimesToComplete(timesToComplete);

        Console.Write("What is the bonus for accomplishing it that many times?: ");
        int bonus = int.Parse(Console.ReadLine());
        SetBonus(bonus);

        _timesDone = 0;
    }
}