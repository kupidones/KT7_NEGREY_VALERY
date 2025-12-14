using System;
public struct Money
{
    public int Rubles;
    public int Kopecks;
    public Money(int rubles, int kopecks)
    {
        Rubles = rubles + kopecks / 100;
        Kopecks = kopecks % 100;
    }
    public static Money operator +(Money a, Money b) =>
        new Money(a.Rubles + b.Rubles, a.Kopecks + b.Kopecks);
    public static Money operator -(Money a, Money b) =>
        new Money(a.Rubles - b.Rubles, a.Kopecks - b.Kopecks);
    public override string ToString() => $"{Rubles} руб. {Kopecks:D2} коп.";
}
class Program
{
    static void Main()
    {
        Money m1 = new Money(10, 150);
        Money m2 = new Money(5, 75);
        Money total = m1 + m2;
        Console.WriteLine($"Сумма: {total}");
    }
}
