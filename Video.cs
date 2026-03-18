namespace ConsoleApp6;

public class Video : LibItem
{
    public int Duration { get; private set; }

    public Video(string name, int year, int durationMin) : base(name, year)
    {
        Duration = durationMin;
    }

    public override string GetInfo()
    {
        return $"Video: {Name}, Duration: {Duration}min, {Year}";
    }
}