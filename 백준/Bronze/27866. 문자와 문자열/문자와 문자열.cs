using System.Text;
using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int charNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(word[charNumber - 1]);
        }
    }
}
