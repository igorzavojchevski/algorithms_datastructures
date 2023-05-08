namespace AL_DS_Lib.LeetCode
{
    public static class _1010_PairsOfSongsWithTotalDurationsDivisibleBy60
    {
        public static int NumPairsDivisibleBy60(int[] time)
        {
            int[] remainders = new int[60];
            int count = 0;
            foreach (int t in time)
            {
                if (t % 60 == 0) // check if a%60==0 && b%60==0
                {
                    count += remainders[0];
                }
                else // check if a%60+b%60==60
                {
                    count += remainders[60 - t % 60];
                }
                remainders[t % 60]++; // remember to update the remainders
            }
            return count;
        }
    }
}
