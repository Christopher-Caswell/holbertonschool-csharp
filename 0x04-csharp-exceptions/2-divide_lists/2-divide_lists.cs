using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        // for (int j = 0; j < list2.Count;)
        // {
        // if (list2[j] == 0)
        //     j++;
        //     Console.WriteLine("Cannot divide by zero");
        //     break;
        // }
        
        // if (list1.Count > list2.Count || list1.Count < list2.Count)
        // {
        //     Console.WriteLine("Out of range");
        // }


        for (int i = 0; i < listLength; i++)
        {
            try
            {
                result.Add(list1[i] / list2[i]);
            }
            
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return result;
    }
}
