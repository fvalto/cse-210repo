public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _listOfComments = new List<Comment>();
    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumOfComments()
    {
        int numOfComments = _listOfComments.Count();
        return numOfComments;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} - {_length} seconds");
        Console.WriteLine($"by {_author}\n");
        Console.WriteLine($"## {GetNumOfComments()} users have commented this video ##");
        foreach (Comment comment in _listOfComments)
        {
            comment.Display();
        }
        Console.WriteLine("\n\n");
    }

    public void AddCommentToVideo(Comment comment)
    {
        _listOfComments.Add(comment);
    }
}