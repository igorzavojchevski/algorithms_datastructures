//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/contains-duplicate
//-----------------------------------------------------------------------------
namespace AL_DS_Lib.LeetCode
{
    public static class _0217_ContainsDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                    return true;
                hashSet.Add(nums[i]);
            }
            return false;
        }
    }
}
