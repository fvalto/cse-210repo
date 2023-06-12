public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _reference = new Reference();
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        SplitText(text);
    }
    public Scripture(string book, int chapter, int verse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        SplitText(text);
    }
    public void DisplayReference()
    {
        Console.Write(_reference.FormReference());
    }
    public void DisplayText()
    {
        string text = "";
        foreach (Word wordInstance in _words)
        {
            text += wordInstance.GetWord() + " ";
        }
        Console.WriteLine(text);
    }

    public void SplitText(string fullText)
    {
        string[] parts = fullText.Split(" ");
        int i = 0;
        foreach (string singleWord in parts)
            {
                Word word = new Word(singleWord);
                _words.Add(word);
                i = i + 1;
            }
    }

    public bool isCompletelyHidden()
    {
        foreach (Word wordInstance in _words)
        {
            if (!wordInstance.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWords(string fullText)
    {
        Random random = new Random();
        while (true)
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                break;
            }
        }
    }

    public string Check(){
        string check = "quit";
        return check;
    }

    public void LoadScripture(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            int i = 0;
            foreach (string singleWord in parts)
            {
                _words[i].SetWord(singleWord);
                i = i + 1;
            }
        }
    }
}