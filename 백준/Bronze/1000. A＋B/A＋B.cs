namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(ab[0] + ab[1]);
        }
    }
}