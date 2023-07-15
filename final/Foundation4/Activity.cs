public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;
    private string _activityName;

    public Activity(int year, int month, int day, int lengthMinutes)
    {
        DateTime date = new DateTime(year, month, day);
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public abstract float Distance();

    public abstract float Speed();

    public abstract float Pace();

    public string GetSummary()
    {
        string summary = "-> " + _date.ToString("dd MMM yyyy").ToUpper() + $" {_activityName} ({_lengthMinutes} min): Distance {Math.Round(Distance(), 2)} km, Speed: {Math.Round(Speed(), 2)} kph, Pace: {Math.Round(Pace(), 2)} min per km)";
        return summary;
    }
}