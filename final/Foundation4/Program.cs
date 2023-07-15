using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _listOfActivities = new List<Activity>();

        RunningActivity activity1 = new RunningActivity(2023, 11, 3, 30, 4.8f);
        _listOfActivities.Add(activity1);

        RunningActivity activity2 = new RunningActivity(2023, 11, 8, 40, 5.9f);
        _listOfActivities.Add(activity2);

        CyclingActivity activity3 = new CyclingActivity(2023, 11, 15, 60, 23);
        _listOfActivities.Add(activity3);

        CyclingActivity activity4 = new CyclingActivity(2023, 11, 23, 60, 25);
        _listOfActivities.Add(activity4);

        SwimmingActivity activity5 = new SwimmingActivity(2023, 11, 29, 30, 20);
        _listOfActivities.Add(activity5);

        SwimmingActivity activity6 = new SwimmingActivity(2023, 12, 11, 30, 40);
        _listOfActivities.Add(activity6);

        foreach (Activity activity in _listOfActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}