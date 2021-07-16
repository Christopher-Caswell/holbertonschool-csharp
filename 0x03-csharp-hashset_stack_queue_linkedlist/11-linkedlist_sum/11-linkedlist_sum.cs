using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
    int ite = 0;
    foreach (int woot in myLList)
    {
    ite += woot;
    }
    return ite;
    }
}
