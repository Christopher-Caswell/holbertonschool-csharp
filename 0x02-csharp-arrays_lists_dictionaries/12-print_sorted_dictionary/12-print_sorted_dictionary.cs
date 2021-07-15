using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> woot = new List<string>(myDict.Keys);

        woot.Sort();

        foreach (string noot in woot)
        {
        Console.WriteLine("{0}: {1}", noot, myDict[noot]);
        }
    }
}
