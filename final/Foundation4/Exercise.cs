
public abstract class Exercise{

    string date;
    protected double activityLength;

    public Exercise(string _date, double _activityLength)
    {
        date = _date;
        activityLength = _activityLength;
    }


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public void DisplaySummary()
    {
        Console.WriteLine($"{date} ({activityLength} Min)- Distance {GetDistance()}, Speed {GetSpeed()} Pace: {GetPace()} min/mile");
    }

}