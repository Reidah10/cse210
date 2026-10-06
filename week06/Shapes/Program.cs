using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 5);
        Circle circle = new Circle("Blue", 3);
        Rectangle rectangle = new Rectangle("Green", 4, 6);

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {color}, Area: {area}");
        }
    }
}