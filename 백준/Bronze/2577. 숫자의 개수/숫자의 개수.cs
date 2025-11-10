using System.Security.Cryptography.X509Certificates;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            int result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            result = numbers[0] * numbers[1] * numbers[2];


            string r = result.ToString();
            int[] realResult = new int[10];

            for (int i = 0; i < r.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((int)Char.GetNumericValue(r[i]) == j)
                    {
                        realResult[j]++;
                    }
                }
            }


            for (int i = 0; i < realResult.Length; i++)
            {
                Console.WriteLine(realResult[i]);
            }
        }
    }
}
