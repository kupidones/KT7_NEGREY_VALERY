using System;
public struct Rectangle
{
    public double Width;
    public double Height;
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Area()
    {
        return Width * Height;
    }
    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 3);
        Console.WriteLine($"Площадь прямоугольника: {rect.Area()}");
        Console.WriteLine($"Периметр прямоугольника: {rect.Perimeter()}");
    }
}
