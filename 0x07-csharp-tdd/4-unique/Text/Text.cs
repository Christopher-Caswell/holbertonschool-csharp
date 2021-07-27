using System;

namespace Text
{
    /// <summary>
    /// Stringy stuff
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Return the index of the first non-repetitive character in a string.
        /// </summary>
        public static int UniqueChar(string s)
        {
            for (int auce = 0; auce < s.Length; auce++)
            {
                for (int alty = 0; alty < s.Length; alty++)
                {

                if (alty == auce)
                {

                if (alty == s.Length - 1)
                {

                return auce;
                }
                continue;
                }

                if (s[auce] == s[alty])
                {
                break;
                }

                if (alty == s.Length - 1)
                {
                return auce;
                }
                }
            }

            return -1;
        }
    }
}
