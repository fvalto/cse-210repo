public class ReceptionEvent : Event
{
    private string _RSVP;
    private string _guestName;

    public ReceptionEvent(string eventTitle, string description, string type, string guestName) : base(eventTitle, description, type)
    {
        _RSVP = $"Thanks {_guestName} for confirming your attendance to our {GetEventTitle()} Event, here is your link to your CODE for registration the event day, see you there!"; 
        _guestName = guestName;
        SetSpecificInfoString($"RSVP: {_RSVP}");
    }
}