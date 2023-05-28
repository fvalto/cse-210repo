public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference ()
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string FormReference()
    {
        string fullReference;
        if (_endVerse == 0) 
        {
            fullReference = $"{_book} {_chapter}:{_verse} ";
        }
        else 
        {
            fullReference = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        return fullReference;
    }
}