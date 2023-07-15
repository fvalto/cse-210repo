public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(int year, int month, int day, int lengthMinutes, float speed) : base(year, month, day, lengthMinutes)
    {
        _speed = speed;
        SetActivityName("Cycling");
    } 

    public override float Distance()
    {
        return (GetLengthMinutes()/60)*Speed(); //first convert minutes to hours and the mutiply by speed, that makes distance in km, at the end round to two decimals
    }

    public override float Speed()
    {
        return _speed;
    }

    public override float Pace()
    {
        return 60/_speed;
    }
}