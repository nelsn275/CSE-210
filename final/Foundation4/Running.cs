
public class Running : Exercise{
    double distance;

    public Running(string _date, double _activityLength, double _distance) : base(_date, _activityLength)
    {
        distance = _distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetPace()
    {
        double pace = activityLength / distance;
        return pace;
    }
     public override double GetSpeed()
    {
        double speed = 60 / GetPace();
        return speed;
    }

}