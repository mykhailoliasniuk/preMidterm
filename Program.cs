namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        var i = new Book("Harry Potter", 1999);
        var j = new Book("Tyhrolovy", 1986);
        var m = new Magazine("Visnyk", 2008, 22);
        var v = new Video("OOP Guide", 1999, 18);
        var l = new Libruary();
        l.Add(i);
        l.Add(j);
        l.Add(m);
        l.Add(v);
        l.ShowAll();
    }
}