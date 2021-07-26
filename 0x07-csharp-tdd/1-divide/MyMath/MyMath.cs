using System;

namespace MyMath
{
    /// <summary>
    /// Do a matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide each element by a number
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
            Console.WriteLine("Num cannot be 0");
            return null;
            }

            if (matrix == null)
            {
            return null;
            }

            int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int y = 0; y < matrix.GetLength(0); y++)
            {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
            answer[y,x] = matrix[y,x] / num;
            }
            }

            return answer;
        }
    }
}
