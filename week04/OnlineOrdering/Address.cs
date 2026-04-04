public class Address
{
    private string _street;
    private string _city;
    private string _states;
    private string _country;
    private string _address;

    public Address()
    {
        
    }
    public Address(string street, string city, string states, string country)
    {
        _street = street;
        _city = city;
        _states = states;
        _country = country.ToLower();
        _address = $"{_street} {_city} {_states} {_country}";
    }
    public bool InStates()
    {
        return _country == "usa";
    }

    public string GetAddress()
    {
        return _address;
    }
}