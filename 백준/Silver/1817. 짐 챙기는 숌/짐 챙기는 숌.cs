namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split()
                .Take(2).ToArray(), int.Parse);

            int n = arr[0];
            int m = arr[1];

            int[] bookMs = new int[n];
            if (n != 0)
                bookMs = Array.ConvertAll(Console.ReadLine()!.Split().
                    Take(n).ToArray(), int.Parse);

            int sumM = 0;
            int result = 0;

            for (int i = 0; i < bookMs.Length; i++)
            {

                if (sumM == 0)
                    result++;

                if (sumM + bookMs[i] > m)
                {
                    sumM = 0;
                    sumM += bookMs[i];
                    result++;
                }
                else
                    sumM += bookMs[i];
            }

            Console.WriteLine(result);
        }
    }
}
