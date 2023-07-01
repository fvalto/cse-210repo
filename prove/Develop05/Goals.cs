public abstract class Goals
{
    private int _points;
    private string _description;
    private bool _isCompleted;
    private string _name;
    private string _typeOfGoal;
    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points; 
    }
    public string GetTypeOfGoal()
    {
        return _typeOfGoal;
    }
    public void SetTypeOfGoal(string type)
    {
        _typeOfGoal = type;
    
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool IsCompleted()
    {
        return _isCompleted;
    }
    public void SetIsCompleted(bool SetIsCompleted)
    {
        _isCompleted = SetIsCompleted;
    }
    public char GetCheckMark()
    {
        char checkMark = ' ';
        if (_isCompleted == false)
        {
            checkMark = ' ';
        }
        else if (_isCompleted == true)
        {
            checkMark = 'X';
        }
        return checkMark;
    }
    public abstract void DisplayGoal();
    public abstract string SaveGoal();
    public abstract void SetGoal();
    public abstract void OneTimeAccomplish();
}