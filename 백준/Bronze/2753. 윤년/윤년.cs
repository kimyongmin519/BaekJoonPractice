using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 4 == 0 && (x % 100 != 0 || x % 400 == 0))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
