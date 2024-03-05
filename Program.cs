public class MyPoint
{

    public int X { get; set; }
    public int Y { get; set; }


    public MyPoint()
    {
        X = 0;
        Y = 0;
    }
    public MyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
           public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public static MyPoint operator +(MyPoint p1, MyPoint p2)
    {
        return new MyPoint(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static MyPoint operator -(MyPoint p1, MyPoint p2)
    {
        return new MyPoint(p1.X - p2.X, p1.Y - p2.Y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyPoint p1 = new MyPoint(3, 4);
        MyPoint p2 = new MyPoint(5, 6);

        Console.WriteLine($"p1 = {p1}");
        Console.WriteLine($"p2 = {p2}");

        MyPoint p3 = p1 + p2;

        Console.WriteLine($"p1 + p2 = {p3}");

        MyPoint p4 = p1 - p2;

        Console.WriteLine($"p1 - p2 = {p4}");
    }
}
