using System.Text;

namespace AL_DS_Lib.CTCI._01
{
    public static class _03_URLify
    {
        /*
         * 1.3 URLify
         * Write a method to replace all spaces in a string with '%20'.
         * You may assume that the string has sufficient space at the end to hold the additional characters,
         * and that you are given the "true" length of the string.
         */

        //Time complexity: O(N)
        //Space complexity: O(N)
        public static string URLify1(string s, int trueLength)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length < trueLength) return string.Empty;

            int whiteSpacesCount = 0;
            for(int i = 0; i < trueLength; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    s = s[..i] + "%20" + s[(i + 1)..];
                    whiteSpacesCount++;
                }
            }

            int size = trueLength - 1 + 2 * whiteSpacesCount;
            if(size + 1 < s.Length)
            {
                s = s.Substring(0, size + 1); 
            }

            return s;
        }

        //Time complexity: O(N) - N is the true length of the string
        //Space complexity: O(1) -> algorithm is with the same char array
        public static string URLify2(char[] s, int trueLength)
        {
            if (s == null || s.Length < trueLength) return string.Empty;

            //Count whitespaces
            int whiteSpaceCount = 0;
            for(int i = 0; i < trueLength; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                    whiteSpaceCount++;
            }

            //New start index -> from the back of the string
            int newEndIndex = trueLength - 1 + whiteSpaceCount * 2;

            //If the full string is larger than the true string, fill with blank
            if (newEndIndex + 1 < s.Length) s[newEndIndex + 1] = '\0';

            //Iterate from the last index until 0
            for(int i = trueLength - 1; i >= 0; i--)
            {
                //If whitespace
                if (char.IsWhiteSpace(s[i]))
                {
                    //Insert '%20', shift the index 3 spaces
                    s[newEndIndex] = '0';
                    s[newEndIndex - 1] = '2';
                    s[newEndIndex - 2] = '%';
                    newEndIndex = newEndIndex - 3;
                }
                else
                {
                    //Shift values to new end index
                    s[newEndIndex] = s[i];
                    newEndIndex--;
                }
            }

            return new string(s);
        }

        //
        //public static void ReplaceSpaces(string s, int trueLength)
        //{
        //    s = s.TrimEnd();
        //    for (int i = 0; i < trueLength; i++)
        //    {
        //        if (s[i] == ' ')
        //        {
        //            s = s.Substring(0, i) + "%20" + s.Substring(i + 1);
        //        }
        //    }
        //}
    }
}
