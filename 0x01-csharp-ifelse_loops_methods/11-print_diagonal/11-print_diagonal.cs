using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
    for (int woot = 0; woot < length; woot++)
    {
        for (int noot = 0; noot < woot; noot++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("\\");
    }
    Console.WriteLine();
    }
}
