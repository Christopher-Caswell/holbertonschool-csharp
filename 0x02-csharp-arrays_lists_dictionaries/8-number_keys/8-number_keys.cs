using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static int NumberOfKeys(Dictionary<string, string> myDict)
        {
        int woot = 0;
        
        foreach (KeyValuePair<string, string> thing_item_or_whatever in myDict)
        {
            woot++;
        }
        return woot;
    }
    }
