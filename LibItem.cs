namespace ConsoleApp6;

public abstract class LibItem
{
    public string Name { get; set; }
    public int Year { get; set; }

    public LibItem(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public abstract string GetInfo();
}