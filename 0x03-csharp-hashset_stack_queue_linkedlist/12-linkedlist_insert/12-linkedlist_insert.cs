using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
    foreach (int woot in myLList)
    {
    if (n < woot)
    {
    return myLList.AddBefore(myLList.Find(woot), n);
    }
    }
    return myLList.AddLast(n);
    }
}
