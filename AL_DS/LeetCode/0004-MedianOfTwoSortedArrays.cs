namespace AL_DS.LeetCode
{
    public static class _0004_MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] newArray = new int[nums1.Length + nums2.Length];
            int m = 0;
            int n = 0;
            int i = 0;
            while (m < nums1.Length && n < nums2.Length)
            {
                if (nums1[m] < nums2[n])
                    newArray[i++] = nums1[m++];
                else
                    newArray[i++] = nums2[n++];
            }

            while (m < nums1.Length)
            {
                newArray[i] = nums1[m];
                m++;
                i++;
            }

            while (n < nums2.Length)
            {
                newArray[i] = nums2[n];
                n++;
                i++;
            }

            int newArrayCount = newArray.Length;
            if (newArrayCount % 2 != 0)
                return newArray[(newArrayCount / 2)];
            else
                return (newArray[newArrayCount / 2 - 1] + newArray[newArrayCount / 2]) / 2.0;
        }
    }
}
