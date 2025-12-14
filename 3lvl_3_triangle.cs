using System;
public struct Triangle
{
    public Point A;
    public Point B;
    public Point C;
    public Triangle(Point a, Point b, Point c)
    {
        A = a;
        B = b;
        C = c;
    }
    public double SideLength(Point p1, Point p2) =>
        Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
    public double Perimeter() => 
        SideLength(A, B) + SideLength(B, C) + SideLength(C, A);
    public double Area()
    {
        double s = Perimeter() / 2;
        double a = SideLength(A, B);
        double b = SideLength(B, C);
        double c = SideLength(C, A);
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 0);
        Point p3 = new Point(0, 4);
        Triangle t = new Triangle(p1, p2, p3);
        Console.WriteLine($"Периметр треугольника: {t.Perimeter()}");
        Console.WriteLine($"Площадь треугольника: {t.Area()}");
    }
}
