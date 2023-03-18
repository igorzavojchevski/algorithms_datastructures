namespace AL_DS.LeetCode
{
    public static class _0977_SquaresSortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int left = 0;
            int right = n - 1;

            int[] result = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                int square;
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    square = nums[left];
                    left++;
                }
                else
                {
                    square = nums[right];
                    right--;
                }
                result[i] = square * square;
            }
            return result;
        }
    }
}
