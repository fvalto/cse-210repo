public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(int year, int month, int day, int lengthMinutes, float distance) : base(year, month, day, lengthMinutes)
    {
        _distance = distance;
        SetActivityName("Running");
    } 

    public override float Distance()
    {
        return _distance;
    }

    public override float Speed()
    {
        return Distance()/(GetLengthMinutes()/60);
    }

    public override float Pace()
    {
        return GetLengthMinutes()/Distance();
    }
}