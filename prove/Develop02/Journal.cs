public class Journal
{
    public List<string> _listOfEntries = new List<string>();

    public void SaveFile(string fileName, Journal journal)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in journal._listOfEntries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }


    public void LoadFile(string fileName, Journal journal)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            journal._listOfEntries.Add(line);
        }
    }
}