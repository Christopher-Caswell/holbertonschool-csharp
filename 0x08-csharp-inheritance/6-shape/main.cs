using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();

        if (typeof(Rectangle).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Rectangle is a subclass of Shape");
        else
            Console.WriteLine("Rectangle is a NOT subclass of Shape");

        try
        {
            aRect.Width = 2;
            Console.WriteLine("Width: {0}", aRect.Width);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            aRect.Height = -6;
            Console.WriteLine("Height: {0}", aRect.Height);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Console.WriteLine("Area: {0}", aRect.Area());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
