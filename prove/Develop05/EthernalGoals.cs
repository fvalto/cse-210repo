public class EthernalGoals : Goals
{
    public EthernalGoals(string name, string description, int points): base(name, description, points)
    {
        SetTypeOfGoal("EthernalGoal");
    }
    public override string SaveGoal()
    {
        string type = GetTypeOfGoal();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();

        return $"{type}|{name}|{description}|{points}";
    }
    // public override string DisplayGoal()
    // {
    //     return $"{GetCheckMark()} {GetName()} {GetDescription()}";
    // }
    public override void DisplayGoal()
    {
        char checkMark = GetCheckMark();
        string name = GetName();
        string description = GetDescription();
        string fullDisplay = $"[{checkMark}] {name}: {description}";
        Console.WriteLine(fullDisplay);
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
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
    }
}