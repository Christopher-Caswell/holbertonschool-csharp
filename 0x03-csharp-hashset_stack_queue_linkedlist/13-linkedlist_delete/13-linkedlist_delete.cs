using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
    LinkedListNode<int> womp = myLList.First;
    for (int ite = 0; ite < myLList.Count; ite++)
    {
    if (ite == index)
    {
    myLList.Remove(womp.Value);
    return;
    }
    womp = womp.Next;
    }
    }
}
