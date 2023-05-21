public class PromptGenerator
{
    public List<string> _listOfPrompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_listOfPrompts.Count);
        string ranprompt = _listOfPrompts[randomIndex];
        return ranprompt;
    }
}