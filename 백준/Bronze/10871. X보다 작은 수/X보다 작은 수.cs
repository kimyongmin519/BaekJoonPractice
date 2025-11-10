namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setting = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < setting[0]; i++)
            {
                if (numbers[i] < setting[1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
