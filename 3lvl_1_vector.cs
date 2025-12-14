using System;
public struct Vector2D
{
    public double X;
    public double Y;
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double Length() => Math.Sqrt(X * X + Y * Y);
    public Vector2D Normalize()
    {
        double len = Length();
        return new Vector2D(X / len, Y / len);
    }
    public double Dot(Vector2D other) => X * other.X + Y * other.Y;
}
class Program
{
    static void Main()
    {
        Vector2D v1 = new Vector2D(3, 4);
        Vector2D v2 = new Vector2D(1, 2);
        Console.WriteLine($"Длина вектора v1: {v1.Length()}");
        Console.WriteLine($"Нормализованный вектор v1: ({v1.Normalize().X}, {v1.Normalize().Y})");
        Console.WriteLine($"Скалярное произведение: {v1.Dot(v2)}");
    }
}
