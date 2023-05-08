using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_DS_Lib.CTCI._01
{
    public class _09_StringRotation
    {
        /*
         * 1.9 String Rotation
         * Assume you have a method isSubstring which cheks if one word is a substring of another.
         * Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring
         * (e.g. "waterbottle" is a rotation of "erbottlewat").
         */

        //Time complexity: O(N+M) worst case
        //Space complexity: O(1) constant if string concatenation is not used. If it is used then O(N).
        public static bool IsSubstring(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2) || s1.Length < s2.Length) return false;

            //string s1s1 = s1 + s1;

            int s2Counter = 0;
            for (int i = 0; i < (2 * s1.Length); i++)
            {
                if (i >= s1.Length) 
                    i = i - s1.Length;

                if (s1[i] == s2[s2Counter])
                {
                    if (s2Counter == s2.Length - 1)
                        return true;
                    s2Counter++;
                }
                else
                {
                    s2Counter = 0;
                }
            }

            return false;
        }

        public static void Run()
        {
            IsSubstring("waterbottle", "erbottlewat");
        }
    }
}
