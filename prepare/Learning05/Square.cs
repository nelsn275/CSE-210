
public class Square : Shape{

    double side;

    public Square(string color, double _side) : base (color)
    {
        side = _side;
    }

    public override double GetArea()
    {
        return side * side;
    }
}