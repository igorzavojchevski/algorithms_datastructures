namespace AL_DS.LeetCode
{
    public static class _0739_DailyTemperatures
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            int[] answer = new int[temperatures.Length];
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (st.Count != 0 && temperatures[st.Peek()] < temperatures[i])
                {
                    int prevDay = st.Pop();
                    answer[prevDay] = i - prevDay;
                }
                st.Push(i);
            }

            return answer;
        }
    }
}
