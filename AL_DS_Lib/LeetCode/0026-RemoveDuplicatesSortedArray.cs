﻿namespace AL_DS_Lib.LeetCode
{
    public static class _0026_RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int insertIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[insertIndex] = nums[i];
                    insertIndex++;
                }
            }
            return insertIndex;
        }
    }
}
