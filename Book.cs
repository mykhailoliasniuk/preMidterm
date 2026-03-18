namespace ConsoleApp6;

public class Book : LibItem
{
    public Book(string name, int year) : base(name, year) {}

    public override string GetInfo() => $"Book: {Name}, Year: {Year}";

}