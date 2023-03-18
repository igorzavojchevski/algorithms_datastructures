namespace AL_DS.CTCI._01
{
    public static class _02_CheckPermutation
    {
        public static bool Permutation(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            for (int i = 0, j = s1.Length - 1; i < s1.Length; i++, j--)
            {
                if (s1[i] != s2[j]) return false;
            }

            return true;
        }
    }
}
