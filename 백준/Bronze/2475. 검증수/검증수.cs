using System.Text;
using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fivenumber = Array.ConvertAll((Console.ReadLine().Split()),int.Parse);
            int[] gumArray = new int[fivenumber.Length];

            for (int i = 0; i < fivenumber.Length; i++)
            {
                gumArray[i] = fivenumber[i] * fivenumber[i];
            }
            Console.WriteLine((gumArray.Sum() % 10));
        }
    }
}
