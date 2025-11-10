using System.Runtime.ExceptionServices;
using System.Text;

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(Console.OpenStandardInput());
            using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int siu = int.Parse(sr.ReadLine());
            int[] numbers = new int[siu];

            for (int i = 0; i < siu; i++)
            {
                numbers[i] = int.Parse(sr.ReadLine());
            }

            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                sw.WriteLine(item);
            }
        }
    }
}