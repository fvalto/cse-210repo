public class BreathingActivity : Activity
{
   public BreathingActivity(string name, string description) : base(name, description)
   {

   }
   public void Run()
   {
        StartActivity();
        //Here goes the activity code
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            CountdownAnimation(4);
            Console.Write("\nNow breathe out...");
            CountdownAnimation(6);
        }
        EndActivity();
   }
}