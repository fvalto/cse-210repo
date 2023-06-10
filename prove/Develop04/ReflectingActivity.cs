public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description) : base(name, description)
    {
       
    }
    private List<string> _prompts = new List<string>() 
    {
        "--- Think of a time when you did something really difficult. ---\n",
        "--- Think of a time when you had to reach to the Lord to take an important desition in your life. ---\n",
        "--- Think of a time when you had to help someone with something difficult in his/her life. ---\n",
        "--- Think of a time when you did something truly selfless. ---\n"
    };

    private List<string> _questions = new List<string>() 
    {
        "How did you feel when it was complete? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations?",
        "How did the Lord's guide you in through experience?",
        "What would you do better?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"        
    };
    public void Run()
    {
        StartActivity();
        //Here goes the activity code
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine(_prompts[GetRandomIndex(_prompts)]);
        Console.WriteLine("When you have something in mind, press anything to continue: \n");
        Console.ReadKey();
        Console.Write("\b");
        Console.WriteLine("Now ponder on each of the following questions related to this experience.");
        Console.Write($"You may bengin in: ");
        CountdownAnimation(5);


        Console.Clear();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration()); 
        while (DateTime.Now < end)
        {
            Console.Write(_questions[GetRandomIndex(_questions)]);
            DisplaySpinner(6);
            Console.WriteLine();
        }

        EndActivity();
    }
}