using System.Linq;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            int hypotenuseNumber = 0;
            int comValue = 0;

            while (true)
            {
                numbers = Console.ReadLine().Split().Select(int.Parse).Take(3).ToArray();

                if (numbers.All(n => n == 0))
                    break;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers.Max() == numbers[i])
                    {
                        hypotenuseNumber = i;
                        break;
                    }
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i != hypotenuseNumber)
                    {
                        comValue += (int)Math.Pow(numbers[i],2);
                    }
                }

                if (Math.Pow(numbers[hypotenuseNumber], 2) == comValue) Console.WriteLine("right");
                else Console.WriteLine("wrong");

                comValue = 0;
                hypotenuseNumber = 0;
            }
        }
    }
}
