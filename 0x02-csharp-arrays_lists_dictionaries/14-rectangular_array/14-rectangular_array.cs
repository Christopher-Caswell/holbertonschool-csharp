﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] woot = new int[5, 5];

        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                if (y == 2 && x == 2)
                {
                woot[y, x] = 1;
                Console.Write("1");
                }
                else
                {
                woot[y, x] = 0;
                Console.Write("0");
                }
                if (x != 4)
                {
                Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
