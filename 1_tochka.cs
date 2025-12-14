using System;
public struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public double DistanceTo(Point other)
    {
        int dx = X - other.X;
        int dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 4);
        Console.WriteLine($"Первая точка: ({p1.X}, {p1.Y})");
        Console.WriteLine($"Вторая точка: ({p2.X}, {p2.Y})");
        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Расстояние между точками: {distance}");
    }
}
