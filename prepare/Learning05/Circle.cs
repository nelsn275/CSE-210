
public class Circle : Shape
{
    double radius;

    public Circle(string color, double _radius) : base (color)
    {
        radius = _radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}