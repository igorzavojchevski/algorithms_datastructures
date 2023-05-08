using AL_DS_Lib.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_DS_Lib.CTCI._01
{
    public class _05_OneAway
    {
        /*
         * 1.5 One Away
         * There are three types of edits that can be performed on strings:
         *  - insert a character,
         *  - remove a character,
         *  - replace a character.
         *  Given two strings, write a function to check if they are one edit (or zero edits) away.
         */

        //Time complexity: O(N)
        //Space complexity: O(1)
        public static bool OneAway(string s1, string s2)
        {
            bool result = false;
            if (s1.Length == s2.Length)
            {
                //Replace
                result = CheckReplace(s1, s2);
            }
            else if (s1.Length + 1 == s2.Length)
            {
                result = CheckInsertRemove(s1, s2);
            }
            else if (s1.Length - 1 == s2.Length)
            {
                //Remove
                result = CheckInsertRemove(s2, s1);
            }

            return result;
        }

        private static bool CheckReplace(string s1, string s2)
        {
            bool alreadyReplaced = false;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (alreadyReplaced) return false;
                    alreadyReplaced = true;
                }
            }
            return true;
        }

        private static bool CheckInsertRemove(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;

            while(index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if(index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
