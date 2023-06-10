public class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description)
    {

    }
    private List<string> _prompts = new List<string>() 
    {
        "--- Who are people that you appreciate? ---\n",
        "--- What are personal strengths of yours? ---\n",
        "--- Who are people that you have helped this week? ---\n",
        "--- When have you felt the Holy Ghost this month?---  ---\n",
        "--- Who are some of your personal heroes? ---"
    };
    private int _responses = 0;

    public void Run()
    {
        Console.Clear();
        StartActivity();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(_prompts[GetRandomIndex(_prompts)]);
        Console.Write("You may begin in: ");
        CountdownAnimation(5);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration()); 
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses++;
        }
        Console.WriteLine($"You listed {_responses} responses.");
        EndActivity();
    }
}