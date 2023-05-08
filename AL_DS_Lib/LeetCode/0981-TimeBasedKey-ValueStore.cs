namespace AL_DS_Lib.LeetCode
{
    public class _0981_TimeBasedKey_ValueStore
    {
        Dictionary<string, List<KeyValuePair<int, string>>> keyTimeMap;

        public _0981_TimeBasedKey_ValueStore()
        {
            keyTimeMap = new Dictionary<string, List<KeyValuePair<int, string>>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!keyTimeMap.ContainsKey(key))
            {
                keyTimeMap[key] = new List<KeyValuePair<int, string>>();
            }

            // Store '(timestamp, value)' pair in 'key' bucket.
            keyTimeMap[key].Add(new KeyValuePair<int, string>(timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            // If the 'key' does not exist in map we will return empty string.
            if (!keyTimeMap.ContainsKey(key))
            {
                return "";
            }

            if (timestamp < keyTimeMap[key][0].Key)
            {
                return "";
            }

            // Using binary search on the list of pairs.
            int left = 0;
            int right = keyTimeMap[key].Count;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (keyTimeMap[key][mid].Key <= timestamp)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            // If iterator points to first element it means, no time <= timestamp exists.
            if (right == 0)
            {
                return "";
            }

            return keyTimeMap[key][right - 1].Value;
        }
    }
}
