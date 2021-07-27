using System;

namespace Text
{
    /// <summary>
    /// Do me a string
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Count words in a string.
        /// </summary>
        public static int CamelCase(string s)
        {
            int my_hat_stacey = 1;

            if (s.Length == 0)
            {
            return 0;
            }

            foreach (char x in s)
            {
            
            if (x >= 'A' && x <= 'Z')
            {
            my_hat_stacey++;
            }
            }

            return my_hat_stacey;
        }
    }
}
