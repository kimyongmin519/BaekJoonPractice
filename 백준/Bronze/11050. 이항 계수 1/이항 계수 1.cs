namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(Facto(inputs[0]) / (Facto(inputs[1]) * Facto((inputs[0] - inputs[1]))));
        }

        static int Facto(int a)
        {
            int result = 1;

            for (int i = 0; i < a; i++)
            {
                result *= a - i;
            }

            return result;
        }
    }
}
