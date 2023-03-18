namespace AL_DS.LeetCode
{
    public static class _0015_3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    int k = -(nums[i] + nums[j]);

                    if (dic.ContainsKey(k))
                    {
                        if (!dic[k].Contains(nums[i]))
                            dic[k].Add(nums[i]);
                        if (!dic[k].Contains(nums[j]))
                            dic[k].Add(nums[j]);
                    }
                    else if (!dic.ContainsKey(nums[j]))
                        dic.Add(nums[j], new List<int>() { nums[j] });
                }
            }
            var test = dic.Values.ToArray();
            return test;
        }
    }
}
