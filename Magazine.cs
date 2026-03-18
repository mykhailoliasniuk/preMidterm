namespace ConsoleApp6;

public class Magazine : LibItem
{
    public int Number { get; private set; }

    public Magazine(string name, int year, int number) : base(name, year)
    {
        Number = number;
    }

    public override string GetInfo()
    {
        return $"Magazine: {Name}, № {Number}, {Year}";
    }
}