using System;

namespace Text
{
    /// <summary>
    /// String stuff
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Palindrome checker
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            int front = 0;
            int end = s.Length - 1;
            string case_insensitive = s.ToLower();

            if (s.Length < 2)
            {
            return true;
            }

            while (case_insensitive[front] < 'a' || case_insensitive[front] > 'z')
            {
            front++;
            }

            while (case_insensitive[end] < 'a' || case_insensitive[end] > 'z')
            {
            end--;
            }

            while (case_insensitive[front] == case_insensitive[end])
            {
            front++;
            end--;

            while (case_insensitive[front] < 'a' || case_insensitive[front] > 'z')
            {
            front++;
            }

            while (case_insensitive[end] < 'a' || case_insensitive[end] > 'z')
            {
            end--;
            }

            if (front >= end)
            {
            return true;
            }
            }

        return false;
        }
    }
}
