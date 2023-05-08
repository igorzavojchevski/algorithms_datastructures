namespace AL_DS_Lib.LeetCode
{
    public static class _1480_RunningSum1DArray
    {
        public static int[] RunningSum(int[] nums)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) continue;
                temp = nums[i - 1];
                nums[i] = temp + nums[i];
            }

            return nums;
        }
    }
}
