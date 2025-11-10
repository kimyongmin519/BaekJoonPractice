

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine().Split().Take(2).Select(int.Parse).ToArray();

            Console.WriteLine(MaxLoserSiu(inputs[0], inputs[1]));
            Console.WriteLine(MinWinnerSiu(inputs[0], inputs[1]));
            
        }
        static int MaxLoserSiu(int a, int b)
        {
            int number = a >= b ? a : b;
            int maxSiu = 0;

            for (int i = 1; i < number + 1; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    if (i > maxSiu)
                    {
                        maxSiu = i;
                    }
                }
            }

            return maxSiu;
        }

        static int MinWinnerSiu(int a, int b)
        {
            int siu = 1;

            while (!(siu % a == 0 && siu % b == 0))
            {
                siu++;
            }

            return siu;
        }
    }
}
