public class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private Adress _adress;
    private string _type;
    private string _specificInfoString;

    //CONSTRUCTOR
    public Event(string eventTitle, string description, string type)
    {
        _eventTitle = eventTitle;
        _description = description;
        _type = type;
    }
    //SETTERS
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDate(int year, int month, int day, int hour, int minute, int second)
    {
        DateTime date = new DateTime(year, month, day, hour, minute, second);
        _date = date;
    }

    public void SetAdresss(string streetAdress, string city, string state)
    {
        Adress adress = new Adress(streetAdress, city, state);
        _adress = adress;
    }

    public void SetSpecificInfoString(string specificInfoString)
    {
        _specificInfoString = specificInfoString;
    }

    //GUETTERS
    public string GetTypeOfEvent()
    {
        return _type;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    //MAIN METHODS
    public string GetDateFormat()
    {
        return _date.ToString("dddd, dd MMMM yyyy");
    }

    public string GetTimeFormat()
    {
        return _date.ToString("hh:mm tt");
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine(
$@"STANDARD DETAILS:
Event Title: {_eventTitle}
Description: {_description}
Date: {GetDateFormat()}
Time: {GetTimeFormat()}
Adress: {_adress.GetFullAdressString()}");
        Console.WriteLine();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(
$@"FULL DETAILS:
Event Title: {_eventTitle}
Description: {_description}
Date: {GetDateFormat()}
Time: {GetTimeFormat()}
Adress: {_adress.GetFullAdressString()}
Type of Event: {_type}
{_specificInfoString}");
        Console.WriteLine();
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine(
$@"SHORT DESCRIPTION:
Type of Event: {_type}
Event Title: {_eventTitle}
Date: {GetDateFormat()}");
        Console.WriteLine();
    }
}