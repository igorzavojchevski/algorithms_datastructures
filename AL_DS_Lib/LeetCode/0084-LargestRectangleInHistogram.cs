namespace AL_DS_Lib.LeetCode
{
    public static class _0084_LargestRectangleInHistogram
    {
        //Input: heights = [2,1,5,6,2,3]
        //Output: 10
        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            int n = heights.Length;
            Stack<int> st = new Stack<int>();
            st.Push(-1);

            for (int i = 0; i < n; i++)
            {
                while (st.Peek() != -1 && heights[i] <= heights[st.Peek()])
                {
                    int currentHeight = heights[st.Pop()];
                    int currentWidth = i - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, currentHeight * currentWidth);
                }

                st.Push(i);
            }

            while (st.Peek() != -1)
            {
                int currentHeight = heights[st.Pop()];
                int currentWidth = n - st.Peek() - 1;
                maxArea = Math.Max(maxArea, currentHeight * currentWidth);
            }

            return maxArea;
        }
    }
}
