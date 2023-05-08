namespace AL_DS_Lib.LeetCode
{
    public static class _0953_VerifyingAlienDictionary
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            int[] alphabet = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                alphabet[order[i] - 'a'] = i;
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j >= words[i + 1].Length) return false;

                    if (words[i][j] != words[i + 1][j])
                    {
                        int currentChar = words[i][j] - 'a';
                        int nextChar = words[i + 1][j] - 'a';

                        if (alphabet[currentChar] > alphabet[nextChar]) return false;
                        else break;
                    }
                }
            }

            return true;
        }
    }
}
