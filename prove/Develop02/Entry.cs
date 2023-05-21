using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _time;
    public string _prompt;
    public string _response;
    public string _overallFeeling;
    // public void WriteEntry(Journal journal)
    // {
    //     _prompt = promptGenerator.GetPrompt();
    //     Console.WriteLine(_prompt);
    //     _response = Console.ReadLine();
    //     Console.WriteLine("Wich was the overall feeling?");
    //     _overallFeeling = Console.ReadLine();

    //     string text = $"{_date} - {_prompt}\n{_response} - Overall Feeling: {_overallFeeling}\nRecording time: {_time}\n";
    //     journal._entries.Add(text);
    //     Console.WriteLine("Entry added to the journal.");
    // }

    public void Display() 
    {
        Console.WriteLine($"{_date} - {_prompt}\n{_response}"); 
        Console.WriteLine($"Overall Feeling: {_overallFeeling}");
        Console.WriteLine($"Record Time: {_time}\n");
    }

    public string GetCommaDelimitedSaveString() 
    {
        return $"{_date},{_time},{_prompt},{_response},{_overallFeeling}";
    }
}