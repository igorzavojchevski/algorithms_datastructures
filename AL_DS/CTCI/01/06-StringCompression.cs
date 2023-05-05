using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_DS.CTCI._01
{
    public class _06_StringCompression
    {
        /*
         * 1.6 String Compression
         * Implement a method to perform basic string compression using the counts of repeated characters.
         * For example, the string aabcccccaaa would become a2b1c5a3. 
         * If the "compressed" string would not become smaller than the original string,
         * your method should return the original string.
         * You can assume the string has only uppercase and lowercase letters (a-z).
         */

        public static string StringCompression(string s)
        {
            int counter = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                counter++;
                if (i + 1 >= s.Length || s[i] != s[i + 1])
                {
                    sb.Append(s[i]);
                    sb.Append(counter);
                    counter = 0;
                }
            }
            return sb.ToString();
        }
    }
}
