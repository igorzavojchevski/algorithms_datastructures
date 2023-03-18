namespace AL_DS.LeetCode
{
    public static class _0242_ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (letters.ContainsKey(s[i]))
                    letters[s[i]]++;
                else
                    letters.Add(s[i], 1);
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!letters.ContainsKey(t[i]))
                    return false;

                if (--letters[t[i]] == 0)
                    letters.Remove(t[i]);
            }

            return letters.Count() == 0;
        }
    }
}
