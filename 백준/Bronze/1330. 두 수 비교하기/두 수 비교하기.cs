using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] comNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (comNum[0] > comNum[1])
                Console.WriteLine(">");
            else if (comNum[0] < comNum[1])
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}
