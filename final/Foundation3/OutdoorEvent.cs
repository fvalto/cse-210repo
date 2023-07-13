public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string eventTitle, string description, string type, string weather) : base(eventTitle, description, type)
    {
        _weather = weather;
        SetSpecificInfoString($"Weather: {_weather}");
    }
}