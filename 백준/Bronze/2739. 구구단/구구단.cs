using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }
    }
}
