public class Customer
{
    bool _isFromUSA;
    private string _customerName;
    private Adress _adress = new Adress();
    private string _fullStringAdress;
    
    public Customer(string customerName, string streetAdress, string city, string state, string country)
    {
        _customerName = customerName;
        _adress.SetStreetAdresss(streetAdress);
        _adress.SetCity(city);
        _adress.SetState(state);
        _adress.SetCountry(country);
        IsFromUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool IsFromUSA()
    {
        if (_adress.GetCountry() == "USA")
        {
            _isFromUSA = true;
        }
        else
        {
            _isFromUSA = false;
        }
        return _isFromUSA;
    }

    public string FullAdressString()
    {
        _fullStringAdress = _adress.GetFullAdressString();
        return _fullStringAdress;
    }
}