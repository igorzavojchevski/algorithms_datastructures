namespace AL_DS.LeetCode
{
    public static class _1207_UniqueNumberOfOccurrences
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                    dic.Add(arr[i], 1);
                else
                    dic[arr[i]]++;
            }

            HashSet<int> set = new HashSet<int>();

            foreach (var item in dic.Values)
            {
                if (set.Contains(item))
                    return false;
                else
                    set.Add(item);
            }

            return true;
        }
    }
}
