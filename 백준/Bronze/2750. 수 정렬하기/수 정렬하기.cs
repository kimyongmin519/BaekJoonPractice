using System;

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
