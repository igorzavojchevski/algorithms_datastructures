using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AL_DS.CTCI._01
{
    public class _04_PalindromePermutation
    {
        /*
         * 1.4 Palindrome Permutation
         * Given a string, write a function to check if it is a permutation of a palindrome.
         * A palimdrome is a word or phrase that is the same forwards and backwards.
         * A permutation is rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
         * You can ignore casing and non-letter characters.
         */

        //Time complexity: O(N)
        //Space complexity: O(1) -> O(25) -> O(constant) -> O(1)
        public static bool PalindromePermutation(string palindrome, string stringToCheck)
        {
            if (palindrome.Length != stringToCheck.Length) return false;

            int[] frequencyArray = new int[26];

            foreach (char character in palindrome)
            {
                int value = GetCharNumber(character);
                if (value != -1)
                    frequencyArray[value]++;
            }

            bool foundOdd = false;
            foreach (int item in frequencyArray)
            {
                if (item % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    foundOdd = true;
                }
            }

            return true;
        }

        private static int GetCharNumber(char c)
        {
            int a = Convert.ToInt16('a');
            int z = Convert.ToInt16('z');
            int val = Convert.ToInt16(c);

            if (a <= val && val <= z)
            {
                return val - a;
            }
            return -1;
        }
    }
}
