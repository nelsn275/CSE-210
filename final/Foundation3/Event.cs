
public class Event{
    public string eventName, description, date, time, type;
    public Address address;

    public Event(string _eventName, string _description, string _date, string _time, string _eventType)
    {
        eventName = _eventName;
        description = _description;
        date = _date;
        time = _time;
        type =  _eventType;
    }

    public void SetAddress(Address _address)
    {
        address = _address;
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine(eventName);
        Console.WriteLine($"-- {description} --");
        Console.WriteLine($"{time} {date}");
        Console.WriteLine(address.GetFullAddress());
    }


    public void DisplayShortDescription()
    {
        Console.WriteLine($"{type} - {eventName}");
        Console.WriteLine(date);
    }
}