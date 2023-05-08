﻿namespace AL_DS_Lib.LeetCode
{
    public static class _0724_PivotIndex
    {
        public static int PivotIndex(int[] nums)
        {
            int sum = 0;
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;
                leftSum = leftSum + nums[i];
            }

            return -1;
        }
    }
}
