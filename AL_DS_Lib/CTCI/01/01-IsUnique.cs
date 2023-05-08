namespace AL_DS_Lib.CTCI._01
{
    public static class _01_IsUnique
    {
        /*
         * 1.1 Is Unique
         * Implement an algorithm to determine if a string has all unique characters.
         * What if you cannot use additional data structures?
         */

        // Time: O(N)
        // Space: O(N)
        public static bool IsUnique1(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;

            HashSet<char> characters = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!characters.Contains(s[i]))
                {
                    characters.Add(s[i]);
                    continue;
                }

                return true;
            }
            return false;
        }

        //Time: O(N log N)
        //Space: O(N)
        public static bool IsUnique2(string s)
        {
            //H E L L O
            if (string.IsNullOrWhiteSpace(s)) return false;

            Array.Sort(s.ToCharArray());

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        //Time: O(N)
        //Space: O(1) -> O(256) -> O(constant) -> O(1)
        public static bool IsUnique3(string s)
        {
            //H E L L O
            if (string.IsNullOrWhiteSpace(s)) return false;

            if (s.Length > 256) // String should contain ASCII + ASCII extended characters. ASCII 127 + extended ASCII has 256.
            {
                return false;
            }

            bool[] array = new bool[256];

            for (int i = 0; i < s.Length; i++)
            {
                int value = (int)s[i];
                if (array[value])
                {
                    return false;
                }
                array[value] = true;
            }
            return true;
        }
    }
}
