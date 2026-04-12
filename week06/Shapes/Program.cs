using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new("red",5.5);
        shapes.Add(s);

        Circle c = new("yellow",5);
        shapes.Add(c);

        Rectangle r = new("blue",10,5);
        shapes.Add(r);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {shape} is {color}, and has an area of {area}.");
        }

    }
}