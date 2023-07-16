public class Address{

    public string streetAddress, city, stateProvince, country;

    public Address(string _streetAddress, string _city, string _stateProvince, string _country)
    {
        streetAddress = _streetAddress;
        city = _city;
        stateProvince = _stateProvince;
        country = _country;
    }
    public string GetFullAddress()
    {
        string fullAddress = $"{streetAddress} {city} {stateProvince}, {country}";
        return fullAddress;
    }

    public string GetCountry()
    {
        return country;
    }
}