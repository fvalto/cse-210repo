public class Word
{
    private bool _isHidden; 
    private string _word;
    public Word (string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void Hide()
    {
        _word = new string('_', _word.Length);
        _isHidden = true;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public bool IsHidden() 
    {
        return _isHidden;
    }
    public void DisplayWord() 
    {
        Console.Write(_word);
    }
    public string GetWord() 
    {
        return _word;
    }
}