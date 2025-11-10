using System.Linq;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Take(number).ToArray();

            int sosiuuNum = 0;

            bool isPrime = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 2) continue;

                isPrime = true;

                for (int j = 2; j * j <= numbers[i]; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime) sosiuuNum++;
            }

            Console.WriteLine(sosiuuNum);
        }
    }
}
