namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        var i = new Book("Harry Poter", 1999);
        var j = new Book("Tyhrolovy", 1986);
        var l = new Libruary();
        l.Add(i);
        l.Add(j);
        l.ShowAll();
    }
}