namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[2];

            arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int n = arr[0];
            int m = arr[1];

            int[,] h1 = new int[n, m];
            int[,] h2 = new int[n, m];

            int[,] result = new int[n, m];


            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    h1[i, j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    h2[i, j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = h1[i, j] + h2[i, j];
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
