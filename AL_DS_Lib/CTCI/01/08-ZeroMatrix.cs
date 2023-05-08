using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_DS_Lib.CTCI._01
{
    public class _08_ZeroMatrix
    {
        /*
         * 1.8 Zero Matrix
         * Write an algorithm such that if an element in an M x N matrix is 0, 
         * its entire row and column are set to 0.
         */

        public static void ZeroMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            HashSet<int> rowsToNullify = new HashSet<int>();
            HashSet<int> columnsToNullify = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!rowsToNullify.Contains(i))
                            rowsToNullify.Add(i);
                        if (!columnsToNullify.Contains(j))
                            columnsToNullify.Add(j);
                    }
                }
            }

            foreach (int row in rowsToNullify)
            {
                NullifyRow(matrix, row);
            }

            foreach (int column in columnsToNullify)
            {
                NullifyColumn(matrix, column);
            }
        }

        public static void NullifyRow(int[][] matrix, int row)
        {
            for (int j = 0; j < matrix[row].Length; j++)
            {
                matrix[row][j] = 0;
            }
        }

        public static void NullifyColumn(int[][] matrix, int column)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][column] = 0;
            }
        }
    }
}
