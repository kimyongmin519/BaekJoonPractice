namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.Write($"{numbers.Min()} { numbers.Max()}");
            

        }
    }
}
