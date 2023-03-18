namespace AL_DS.LeetCode
{
    public static class _0153_FindMinimumInRotatedSortedArray
    {
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            if (nums.Length == 1 || nums[left] < nums[right]) return nums[left];

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > nums[mid + 1]) return nums[mid + 1];
                if (nums[mid - 1] > nums[mid]) return nums[mid];

                if (nums[left] < nums[mid]) left = mid + 1;
                else right = mid - 1;
            }

            return int.MaxValue;
        }
    }
}
