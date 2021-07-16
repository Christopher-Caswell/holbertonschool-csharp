using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> womp = new HashSet<int>(list1);

        womp.IntersectWith(list2);
        List<int> noot = new List<int>(womp);
        noot.Sort();

        return noot;
    }
}
