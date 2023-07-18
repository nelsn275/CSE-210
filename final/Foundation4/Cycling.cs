
public class Cycling : Exercise{
    double speed;

    public Cycling(string _date, double _activityLength, double _speed) : base(_date, _activityLength)
    {
        speed = _speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        double distance = (activityLength * speed) / 60;
        return distance;
    }

    public override double GetPace()
    {
        double pace = activityLength / GetDistance();
        return pace;
    }

    
}