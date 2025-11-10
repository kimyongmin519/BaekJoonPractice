using System.Text;
using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testcaseNumber = int.Parse(Console.ReadLine());
            int[] caseArray = new int[testcaseNumber];
            int x = 0;

            for (int i = 0; i < testcaseNumber; i++)
            {
                int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for (int j = 0; j < array.Length; j++)
                {
                    x += array[j];
                }
                caseArray[i] = x;
                x = 0;
            }
            for (int i = 0; i < caseArray.Length; i++)
            {
                Console.WriteLine(caseArray[i]);
            }
        }
    }
}
