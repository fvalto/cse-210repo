public class Adress
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

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

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetFullAdressString()
    {
        return $"{_streetAdress}\n{_city}, {_state}\n{_country}";
    }
}