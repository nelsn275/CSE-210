using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square nsquare = new Square("Green", 5);
        shapes.Add(nsquare);
        Rectangle nrectangle = new Rectangle("Blue", 7, 12);
        shapes.Add(nrectangle);
        Circle ncircle = new Circle("Red", 6);
        shapes.Add(ncircle);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The color is {color} and the area is {area}");
        }

    }

}