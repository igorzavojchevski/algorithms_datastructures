namespace AL_DS_Lib.LeetCode
{
    public static class _0074_Searcha2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int matrixRow = -1;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrixRow = i;
                if (target >= matrix[i][0])
                {
                    continue;
                }
                else if (target < matrix[i][0])
                {
                    matrixRow = i - 1;
                    break;
                }
            }

            if (matrixRow == -1) return false;

            int low = 0;
            int high = matrix[matrixRow].Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (target == matrix[matrixRow][mid])
                    return true;
                else if (target > matrix[matrixRow][mid])
                    low = mid + 1;
                else if (target < matrix[matrixRow][mid])
                    high = mid - 1;
            }

            return false;
        }
    }
}
