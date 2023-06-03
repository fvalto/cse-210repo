public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic) //calling base class constructor and adding the two specific ones
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}