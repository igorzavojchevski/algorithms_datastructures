namespace AL_DS_Lib.CTCI._01
{
    public class _07_RotateMatrix
    {
        /*
         * 1.7 Rotate Matrix
         * Given an image represented by an N x N matrix, 
         * where each pixel in the image is represented by an integer, write a method to rotate the image by 90 degrees.
         * Can you do this in place?
         */

        //Time complexity: O(N^2) - cannot do better
        //Space complexity: O(1) - in place rotate
        public static void RotateMatrix(string[][] matrix)
        {
            int n = matrix.Length;

            for (int layer = 0; layer < n; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;

                    string top = matrix[first][i];
                    //left-top
                    matrix[first][i] = matrix[last - offset][first];

                    //bottom-left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    //right-bottom
                    matrix[last][last - offset] = matrix[i][last];

                    //top-right
                    matrix[i][last] = top;
                }
            }
        }

        public static void Run()
        {
            var matrix = new string[][]
            {
                new string[] { "0,0", "0,1", "0,2", "0,3" },
                new string[] { "1,0", "1,1", "1,2", "1,3" },
                new string[] { "2,0", "2,1", "2,2", "2,3" },
                new string[] { "3,0", "3,1", "3,2", "3,3" }
            };

            RotateMatrix(matrix);
        }
    }
}
