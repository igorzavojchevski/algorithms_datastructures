using System.Text;

namespace AL_DS_Lib.LeetCode
{
    public static class _0049_GroupAnagrams
    {
        //O(N*K)
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0) return (IList<IList<string>>)new List<List<string>>();

            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
            int[] alphabet = new int[26];

            foreach (string str in strs)
            {
                //char[] charArray = str.ToCharArray();
                //Array.Sort<char>(charArray);
                //string key = new string(charArray);
                alphabet = new int[26];
                foreach (char c in str.ToCharArray()) alphabet[c - 'a']++;

                StringBuilder sb = new StringBuilder("");
                for (int i = 0; i < 26; i++)
                {
                    sb.Append('#');
                    sb.Append(alphabet[i]);
                }

                string key = sb.ToString();

                if (anagrams.ContainsKey(key))
                    anagrams[key].Add(str);
                else
                    anagrams.Add(key, new List<string>() { str });
            }

            return (IList<IList<string>>)anagrams.Values.ToList();
        }

        /*
        //O(N * K * log(N))
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0) return (IList<IList<string>>)new List<List<string>>();

            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

            foreach(string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort<char>(charArray);
                string key = new string(charArray);

                if (anagrams.ContainsKey(key))
                    anagrams[key].Add(str);
                else
                    anagrams.Add(key, new List<string>() { str });
            }

            return (IList<IList<string>>)anagrams.Values.ToList();
        }
        */
    }
}
