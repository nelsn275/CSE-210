public class Customer{
    string name;
    Address address;

    public Customer(string _name, Address _address)
    {
        name = _name;
        address = _address;
    }
    public string GetName()
    {
        return name;
    }

    public void DisplayAddress()
    {
        Console.WriteLine(address.GetFullAddress());
    }
    public bool LivesInUSA()
    {
        string country = address.GetCountry();
        
        if (country == "USA" || country == "United States" || country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}