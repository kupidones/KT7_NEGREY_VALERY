using System;
public struct SimpleDate
{
    public int Day;
    public int Month;
    public int Year;
    public SimpleDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }
    public bool IsLeapYear()
    {
        if (Year % 4 == 0)
        {
            if (Year % 100 == 0)
            {
                return Year % 400 == 0;
            }
            return true;
        }
        return false;
    }
    public override string ToString() => $"{Day:00}.{Month:00}.{Year}";
}
class Program
{
    static void Main()
    {
        SimpleDate date = new SimpleDate(29, 02, 2024);
        Console.WriteLine($"Дата: {date} — Високосный год: {date.IsLeapYear()}");
    }
}
