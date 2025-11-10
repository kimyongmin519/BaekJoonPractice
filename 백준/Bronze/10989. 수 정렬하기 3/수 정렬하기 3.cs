using System.Runtime.ExceptionServices;
using System.Text;

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {

            using var sr = new StreamReader(Console.OpenStandardInput());
            using var sw = new StreamWriter(Console.OpenStandardOutput());

            int siu = int.Parse(sr.ReadLine());
            int[] arr = new int[10001];

            for (int i = 0; i < siu; i++)
            {
                arr[int.Parse(sr.ReadLine())]++;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    for (int j = 0; j < arr[i]; j++)
                    {
                        sw.WriteLine(i);
                    }
                }
            }
        }
    }
}
