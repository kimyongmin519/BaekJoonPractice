namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(input[0] + input[1]);
            Console.WriteLine(input[0] - input[1]);
            Console.WriteLine(input[0] * input[1]);
            Console.WriteLine(input[0] / input[1]);
            Console.WriteLine(input[0] % input[1]);
        }
    }
}
