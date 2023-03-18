namespace AL_DS.LeetCode
{
    public static class _0167_TwoSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int low = 0;
            int high = numbers.Length - 1;

            while (low < high)
            {
                int sum = numbers[low] + numbers[high];

                if (sum < target)
                {
                    low++;
                }
                else if (sum > target)
                {
                    high--;
                }
                else
                {
                    return new int[] { low + 1, high + 1 };
                }
            }

            return new int[] { -1, 1 };
        }
    }
}
