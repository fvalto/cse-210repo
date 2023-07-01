public class SimpleGoals : Goals
{
    
    public SimpleGoals(string name, string description, int points, bool isCompleted): base(name, description, points)
    {
        SetTypeOfGoal("SimpleGoal");
        SetIsCompleted(isCompleted);
    }
    public override void DisplayGoal()
    {
        char checkMark = GetCheckMark();
        string name = GetName();
        string description = GetDescription();
        string fullDisplay = $"[{checkMark}] {name}: {description}";
        Console.WriteLine(fullDisplay);
    }
    // public override void SaveGoal(List<Goals> listOfGoals)
    // {
    //     listOfGoals
    // }
    public override string SaveGoal()
    {
        string type = GetTypeOfGoal();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool isCompleted = IsCompleted();

        return $"{type}|{name}|{description}|{points}|{isCompleted}";
    }
    public override void SetGoal()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("Give a short description of it: ");
        string description = Console.ReadLine();
        SetDescription(description);

        Console.Write("What is the amount of points associated to this goal?: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }
    public override void OneTimeAccomplish()
    {
        
        SetIsCompleted(true);
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
    }
}