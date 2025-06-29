namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            Console.WriteLine(input[0] / input[1]);
        }
    }
}
