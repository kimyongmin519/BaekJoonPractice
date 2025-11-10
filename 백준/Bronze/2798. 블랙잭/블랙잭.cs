

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int[] settings = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] cards = Console.ReadLine().Split().Take(settings[0]).Select(int.Parse).ToArray();

            int sum = 0;
            int maxSum = 0;
            int[] arr = new int[3];

            for (int i = 0; i < settings[0]; i++)
            {
                for (int j = i + 1; j < settings[0]; j++)
                {
                    for (int z = j + 1; z < settings[0]; z++)
                    {
                        sum = cards[i] + cards[j] + cards[z];
                        if (maxSum < sum && settings[1] >= sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
