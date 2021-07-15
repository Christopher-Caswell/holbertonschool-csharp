using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> woot = new KeyValuePair<string, int>("None", -1);

        foreach (KeyValuePair<string, int> duo in myList)
        {
            if (duo.Value > woot.Value)
            {
            woot = duo;
            }
        }
        return woot.Key;
    }
}
