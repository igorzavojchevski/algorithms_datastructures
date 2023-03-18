namespace AL_DS.LeetCode
{
    public static class _0118_PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            int[][] triangle = new int[numRows][];

            for (int row = 0; row < numRows; row++)
            {
                if (row == 0)
                {
                    triangle[0] = new int[] { 1 };
                    continue;
                }

                triangle[row] = new int[row + 1];
                for (int i = 0; i < triangle[row].Length; i++)
                {
                    if (i == 0)
                    {
                        triangle[row][i] = triangle[row - 1][0];
                    }
                    else if (i == triangle[row].Length - 1)
                    {
                        triangle[row][i] = triangle[row - 1][0];

                    }
                    else
                    {
                        triangle[row][i] = triangle[row - 1][i] + triangle[row - 1][i - 1];
                    }
                }
            }

            return triangle;
        }
    }
}
