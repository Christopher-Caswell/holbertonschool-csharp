using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
    LinkedList<int> noot = new LinkedList<int>();
    for (int x = 0; x < size; x++)
    {
    noot.AddLast(x);
    Console.WriteLine("{0}", x);
    }
    return noot;
    }
}
