namespace AL_DS_Lib.LeetCode
{
    public static class _0001_TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> alreadyPassed = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int value = target - nums[i];
                if (alreadyPassed.ContainsKey(value))
                    return new[] { alreadyPassed[value], i };

                if (!alreadyPassed.ContainsKey(nums[i]))
                    alreadyPassed.Add(nums[i], i);
            }

            return null;
        }
    }
}
