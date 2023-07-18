
public class Swimming : Exercise{
    public int numLaps;

    public Swimming(string _date, double _activityLength, int _numlaps) : base( _date,  _activityLength)
    {
        numLaps = _numlaps;
    }

    public override double GetDistance()
    {
        double distance =  numLaps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double GetPace()
    {
        double pace = activityLength / GetDistance();
        return Math.Round(pace, 2);
    }

    public override double GetSpeed()
    {
        double speed = 60 / GetPace();
        return Math.Round(speed, 2);
    }
}
