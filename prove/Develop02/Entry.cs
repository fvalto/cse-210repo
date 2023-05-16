public class Entry
{
    string _date = DateTime.Now.ToShortDateString();
    string _time = DateTime.Now.ToString("h:mm:ss tt");

    public void WriteEntry(Journal journal)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();
        Console.WriteLine("How was the overall feeling?");
        string overallFeeling = Console.ReadLine();

        string text = $"{_date} - {prompt}\n{entry} - Overall Feeling: {overallFeeling}\nRecording time: {_time}\n";
        journal._listOfEntries.Add(text);
        Console.WriteLine("Entry added to the journal.");
    }

    public void DisplayEntries(Journal journal)
    {
        foreach (string entry in journal._listOfEntries)
        {
            Console.WriteLine(entry);
        }
    }
}