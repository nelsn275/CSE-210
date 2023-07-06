
public abstract class Shape{
    string color;

    public Shape(string _color)
    {
        color = _color;
    }

    public void SetColor(string _color)
    {
        color = _color;
    }

    public string GetColor()
    {
        return color;
    }

    public abstract double GetArea();
}