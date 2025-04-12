using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 5);
        shapes.Add(s1);
        
        Rectangle r1 = new Rectangle("red", 6, 8);
        shapes.Add(r1);
        
        Circle c1 = new Circle("pink", 2);
        shapes.Add(c1);

        foreach (Shape item in shapes)
        {
            string color = item.GetColor();

            double area = item.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}");

        }
    }
}