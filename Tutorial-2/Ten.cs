using System;

namespace c__learn.Tutorial_2
{
    internal class Ten
    {
        public static int run(int[,] mat, int N, int M, int X)
        {
            int row = 0;
            int col = M - 1;

            while (row < N && col >= 0)
            {
                if (mat[row, col] == X)
                {
                    return 1;
                }
                else if (mat[row, col] > X)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            return 0;
        }

        public static void tens(string[] args)
        {
            int[,] mat =
            {
                {3, 30, 38},
                {44, 52, 54},
                {57, 60, 69}
            };

            int N = 3;
            int M = 3;
            int X = 62;

            int result = Ten.run(mat, N, M, X);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}