namespace ConsoleApp6;

public class Libruary
{
    private List<LibItem> libruary = new List<LibItem>();

    public void Add(LibItem item)
    {
        libruary.Add(item);
    }

    public void ShowAll()
    {
        foreach (var item in libruary)
        {
            Console.WriteLine(item.GetInfo());
        }
    }
}