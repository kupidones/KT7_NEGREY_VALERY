using System;
public struct Color
{
    public byte R;
    public byte G;
    public byte B;
    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }
    public string ToHex()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }
    public override string ToString() => $"RGB({R}, {G}, {B})";
}
class Program
{
    static void Main()
    {
        Color color = new Color(255, 0, 0);
        Console.WriteLine($"Цвет: {color} -> {color.ToHex()}");
    }
}
