namespace AL_DS_Lib.LeetCode
{
    public static class _1165_SingleRowKeyboard
    {
        public static int CalculateTime(string keyboard, string word)
        {

            Dictionary<int, int> hashKeyboard = new Dictionary<int, int>();
            for (int i = 0; i < keyboard.Length; i++)
            {
                hashKeyboard[keyboard[i] - 'a'] = i;
            }

            int pathCount = 0;
            int prev = 0;
            for (int i = 0; i < word.Length; i++)
            {
                pathCount = pathCount + Math.Abs(prev - hashKeyboard[word[i] - 'a']);
                prev = hashKeyboard[word[i] - 'a'];
            }

            //Dictionary<char, int> hashKeyboard = new Dictionary<char, int>();
            //for (int i = 0; i < keyboard.Length; i++)
            //{
            //    hashKeyboard[keyboard[i]] = i;
            //}

            //int pathCount = hashKeyboard[word[0]] - hashKeyboard[keyboard[0]];
            //for (int i = 1; i < word.Length; i++)
            //{
            //    pathCount = pathCount + Math.Abs(hashKeyboard[word[i]] - hashKeyboard[word[i - 1]]);
            //}

            return pathCount;
        }
    }
}
