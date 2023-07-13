public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string eventTitle, string description, string type, string speaker, int capacity) : base(eventTitle, description, type)
    {
        _speaker = speaker;
        _capacity = capacity;
        SetSpecificInfoString($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }
}