using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> MyList, int n)
    {
        int i;
        for (i = 0; i < n; i++)
        {
        try
        {
            Console.WriteLine("{0}", MyList[i]);
        }       
        catch
        {
            return i;
        }
    }
    return i;
}
}
