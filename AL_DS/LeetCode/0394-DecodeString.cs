using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_DS.LeetCode
{
    public static class _0394_DecodeString
    {
        public static string DecodeString(string s)
        {
            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    StringBuilder repeat = new StringBuilder();
                    while (chars.Peek() != '[')
                    {
                        repeat.Insert(0, chars.Pop());
                    }
                    chars.Pop();

                    StringBuilder repeatTimes = new StringBuilder();
                    while (chars.Count != 0 && Char.IsDigit(chars.Peek()))
                    {
                        repeatTimes.Insert(0, chars.Pop());
                    }

                    int.TryParse(repeatTimes.ToString(), out int numberOfRepeats);

                    StringBuilder tempRepeat = new StringBuilder();
                    for (int j = 0; j < numberOfRepeats; j++)
                    {
                        tempRepeat.Append(repeat);
                    }

                    foreach (char tempChar in tempRepeat.ToString())
                    {
                        chars.Push(tempChar);
                    }
                }
                else
                {
                    chars.Push(s[i]);
                }
            }

            StringBuilder finalString = new StringBuilder();

            while (chars.Count > 0)
            {
                finalString.Insert(0, chars.Pop());
            }

            return finalString.ToString();
        }
    }
}
