using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void Write() 
    {
        Entry entry = new Entry(); 
        PromptGenerator promptgenerator = new PromptGenerator();
        // populate entry
        entry._date = DateTime.Now.ToShortDateString();
        entry._time = DateTime.Now.ToString("h:mm:ss tt");;
        entry._prompt = promptgenerator.GetPrompt();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        Console.Write("Wich was the overall feeling?: ");
        entry._overallFeeling = Console.ReadLine();

        // add it to list
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        Console.Write("Please, enter the fileName: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string commaString = entry.GetCommaDelimitedSaveString();
                outputFile.WriteLine(commaString);
            }
        }
        Console.WriteLine("File saved!");
    }

    public void LoadFile()
    {
        Console.Write("Please, enter the fileName: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._time = parts[1];
            entry._prompt = parts[2];
            entry._response = parts[3];
            entry._overallFeeling = parts[4];
            _entries.Add(entry);
        }
    }
}