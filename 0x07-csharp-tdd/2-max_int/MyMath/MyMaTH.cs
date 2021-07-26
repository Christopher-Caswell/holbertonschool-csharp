using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Concrete implementation of the MyMath interface.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Find the maximum of a series of integers.
        /// </summary>
        public static int Max(List<int> nums)
        {
            int x = int.MinValue;

            if (nums.Count == 0)
            {
            return 0;
            }

            foreach (int y in nums)
            {
                
            if (y > x)
            {
            x = y;
            }
            }

            return x;
        }
    }
}
