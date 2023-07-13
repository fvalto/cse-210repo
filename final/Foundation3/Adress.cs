public class Adress
{
    private string _streetAdress;
    private string _city;
    private string _state;

    public Adress(string streetAdress, string city, string state)
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
    }

    public string GetStreetAdress()
    {
        return _streetAdress;
    }

    public void SetStreetAdresss(string streetAdress)
    {
        _streetAdress = streetAdress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetFullAdressString()
    {
        return $"{_streetAdress}, {_city}, {_state}";
    }
}