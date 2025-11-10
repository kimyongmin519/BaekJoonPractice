namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            long[] inputs = Console.ReadLine().Split().Select(long.Parse).Take(2).ToArray();
            long a = inputs[0];
            long b = inputs[1];

            Console.WriteLine($"{(a + b) * (a - b)}");

        }
    }
}
