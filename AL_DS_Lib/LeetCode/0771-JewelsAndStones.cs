namespace AL_DS_Lib.LeetCode
{
    public static class _0771_JewelsAndStones
    {
        public static int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < jewels.Length; i++)
            {
                if (!set.Contains(jewels[i]))
                    set.Add(jewels[i]);
            }

            int jewelStones = 0;
            HashSet<char> set2 = new HashSet<char>();
            for (int i = 0; i < stones.Length; i++)
            {
                if (set.Contains(stones[i]))
                {
                    jewelStones++;
                    //set2.Add(stones[i]);
                }
            }
            return jewelStones;
        }
    }
}
