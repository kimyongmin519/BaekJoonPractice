using System.Text;
using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] facNumbers = new int[number];
            int result = 1;

            for (int i = number - 1; i > -1; i--)
            {   
                facNumbers[i] = i+1;
            }
            for (int i = 0; i < number; i++)
            {
                result *= facNumbers[i];
            }
            Console.Write(result);
        }
    }
}
