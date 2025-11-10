namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).Take(2).ToArray();
            int a = inputs[0];
            int b = inputs[1];

            Console.WriteLine($"{(a + b) * (a - b)}");

        }
    }
}
