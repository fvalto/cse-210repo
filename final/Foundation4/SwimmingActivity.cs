public class SwimmingActivity : Activity
{
    private int _numOfLaps;

    public SwimmingActivity(int year, int month, int day, int lengthMinutes, int numOfLaps) : base(year, month, day, lengthMinutes)
    {
        _numOfLaps = numOfLaps;
        SetActivityName("Swimming");
    } 

    public override float Distance()
    {
        return ((_numOfLaps*50)/1000);
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