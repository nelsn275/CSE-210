
public class OutdoorGathering : Event{
    
    public string weather;

    public OutdoorGathering(string _eventName, string _description, string _date, string _time, string _eventType, string _weather) : base(_eventName, _description, _date, _time, _eventType)
    {
        weather = _weather;
    } 

    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"The weather for this event will be {weather}");
    }
}

