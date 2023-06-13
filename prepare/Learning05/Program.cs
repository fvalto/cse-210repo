using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Green", 5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine();

        Rectangle rectangle = new Rectangle("Red", 2, 5);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine();

        Circle circle = new Circle("Blue", 10);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());
        // Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine();
        }
    }
}