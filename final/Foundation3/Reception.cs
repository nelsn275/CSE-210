
public class Reception : Event{

    string RSVPEmail;

    public Reception(string _eventName, string _description, string _date, string _time, string _eventType, string _rsvpEmail) : base (_eventName, _description, _date, _time, _eventType)
    {
        RSVPEmail = _rsvpEmail;
    }

    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Email for RSVP {RSVPEmail}");
    }
}