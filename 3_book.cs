using System;
public struct Book
{
    public string Title;
    public string Author;
    public int Year;
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{Title} — {Author} ({Year})");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("1984", "Джордж Оруэлл", 1949);
        book.DisplayInfo();
    }
}
