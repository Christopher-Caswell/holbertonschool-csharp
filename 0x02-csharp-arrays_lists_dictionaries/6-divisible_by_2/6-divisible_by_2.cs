using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
     List<bool> x = new List<bool>();

        foreach (int sel in myList)
        {
        x.Add(sel % 2 == 0);
        }
        return x;
    }
}
