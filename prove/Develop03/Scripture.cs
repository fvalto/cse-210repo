public class Scripture
{
    List<Word> _words = new List<Word>();
    private string _text;
    Reference _reference = new Reference();
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _text = text;
        SplitText(_text);
    }
    public Scripture(string book, int chapter, int verse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        _text = text;
        SplitText(_text);
    }
    public void DisplayReference()
    {
        Console.Write(_reference.FormReference());
    }
    public void DisplayText()
    {
        _text = "";
        foreach (Word wordInstance in _words)
        {
            _text += wordInstance.GetWord() + " ";
        }
        Console.WriteLine(_text);
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
        int randomIndex = random.Next(_words.Count);
        if (_words[randomIndex].IsHidden() == false)
        {
            _words[randomIndex].Hide();
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