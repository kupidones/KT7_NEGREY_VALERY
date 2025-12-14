using System;
public struct ComplexNumber
{
    public double Real;
    public double Imag;
    public ComplexNumber(double real, double imag)
    {
        Real = real;
        Imag = imag;
    }
    public static ComplexNumber Add(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real + b.Real, a.Imag + b.Imag);
    }
    public static ComplexNumber Subtract(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real - b.Real, a.Imag - b.Imag);
    }
    public static ComplexNumber Multiply(ComplexNumber a, ComplexNumber b)
    {
        double realPart = a.Real * b.Real - a.Imag * b.Imag;
        double imagPart = a.Real * b.Imag + a.Imag * b.Real;
        return new ComplexNumber(realPart, imagPart);
    }
    public override string ToString() => $"{Real} + {Imag}i";
}
class Program
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(3, 4);
        ComplexNumber c2 = new ComplexNumber(1, 2);
        Console.WriteLine($"Сложение: {ComplexNumber.Add(c1, c2)}");
        Console.WriteLine($"Вычитание: {ComplexNumber.Subtract(c1, c2)}");
        Console.WriteLine($"Умножение: {ComplexNumber.Multiply(c1, c2)}");
    }
}
