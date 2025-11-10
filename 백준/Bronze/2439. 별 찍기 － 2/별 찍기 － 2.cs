using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = x - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
