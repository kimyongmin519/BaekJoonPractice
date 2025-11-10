using System.Text;
using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < x + 1; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
