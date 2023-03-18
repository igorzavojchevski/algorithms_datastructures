namespace AL_DS.LeetCode
{
    public static class _0283_MoveZeroes
    {
        public static void MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[nonZeroIndex];
                    nums[nonZeroIndex] = nums[i];
                    nums[i] = temp;
                    nonZeroIndex++;
                }
            }
        }
    }
}
