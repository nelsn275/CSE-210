
public class Lecture : Event{


    public string speakerName;
    public int eventCapacity;

    public Lecture(string _eventName, string _description, string _date, string _time, string _eventType, string _speakerName, int _capacity) : base(_eventName, _description, _date, _time, _eventType)
    {
        speakerName = _speakerName;
        eventCapacity = _capacity;
    }


    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Speaker: {speakerName}");
        Console.WriteLine($"Capacity: {eventCapacity}");
    }
}