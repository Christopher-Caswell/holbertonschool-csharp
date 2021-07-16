using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
    int blah = 0;
    foreach (int noot in myLList)
    {
    if (blah == n)
    {
    return noot;
    }
    blah++;
    }
    return 0;
    }
}
