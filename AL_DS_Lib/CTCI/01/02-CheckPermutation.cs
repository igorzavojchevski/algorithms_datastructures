namespace AL_DS_Lib.CTCI._01
{
    public static class _02_CheckPermutation
    {

        /*
         * 1.2 Check Permutation
         * Given two strings, write a method to decide if one is a permutation of the other.
         */

        // Time: O(N log N) -> N length of string, log N sorting
        // Space: O(N) -> used for sorting the strings
        public static bool CheckPermutation1(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            Array.Sort(s1.ToCharArray());
            Array.Sort(s2.ToCharArray());

            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] != s2[i]) 
                    return false;
            }

            return true;
        }

        // Time: O(N log N) -> N length of string while checking equality, log N sorting
        // Space: O(N) -> used for sorting the strings
        public static bool CheckPermutation2(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            Array.Sort(s1.ToCharArray());
            Array.Sort(s2.ToCharArray());

            return s1.Equals(s2);
        }


        // Time: O(N) -> N length of string
        // Space: O(1)
        public static bool CheckPermutation3(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            int[] letters = new int[256];

            for(int i = 0; i < s1.Length; i++)
            {
                letters[s1[i]]++;
            }

            for(int i = 0; i < s2.Length; i++)
            {
                letters[s2[i]]--;
                if (letters[s2[i]] < 0) //Cannot have positive at the end, if it has negatives
                    return false;
            }

            return true;
        }


























        //public static bool Permutation(string s1, string s2)
        //{
        //    if (s1.Length != s2.Length) return false;

        //    for (int i = 0, j = s1.Length - 1; i < s1.Length; i++, j--)
        //    {
        //        if (s1[i] != s2[j]) return false;
        //    }

        //    return true;
        //}
    }
}
