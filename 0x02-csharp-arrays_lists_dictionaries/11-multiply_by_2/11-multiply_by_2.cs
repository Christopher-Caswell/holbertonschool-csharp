using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict) {
        Dictionary<string, int> noot = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> pair in myDict) {
            noot.Add(pair.Key, pair.Value * 2);
        }

        return noot;
    }
}
