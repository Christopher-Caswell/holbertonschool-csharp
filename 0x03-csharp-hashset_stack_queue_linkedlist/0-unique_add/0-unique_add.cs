﻿using System;
using System.Collections.Generic;

    class List
    {
        public static int Sum(List<int> myList)
        {
        HashSet<int> womp = new HashSet<int>(myList);
        int total = 0;

        foreach (int ite in womp)
        {
        total += ite;
        }

        return total;
        }
    }
