//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/majority-element
//-----------------------------------------------------------------------------

namespace AL_DS_Lib.LeetCode
{
    public static class _0169_MajorityElement
    {
        //Using Dictionary(HashMap)
        //public static int MajorityElement(int[] nums)
        //{
        //    if (nums == null || nums.Length == 0)
        //        return 0;

        //    if (nums.Length == 1) return nums[0];

        //    Dictionary<int, int> elements = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (elements.ContainsKey(nums[i]))
        //        {
        //            elements[nums[i]]++;
        //            if (elements[nums[i]] > nums.Length / 2) 
        //                return nums[i];
        //        }
        //        else
        //        {
        //            elements.Add(nums[i], 1);
        //        }
        //    }

        //    return 0;
        //}

        //Boyer-Moore Voting Algorithm
        public static int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                    candidate = num;
                count = count + ((num == candidate) ? 1 : -1);
            }

            return candidate;
        }
    }
}
