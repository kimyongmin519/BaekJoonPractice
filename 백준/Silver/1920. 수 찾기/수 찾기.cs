using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    internal class Beakjoon2
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] arrN = Array.ConvertAll(Console.ReadLine()!.Split()
                .Take(N).ToArray(), int.Parse);

            int M = int.Parse(Console.ReadLine()!);
            int[] arrM = Array.ConvertAll(Console.ReadLine()!.Split()
                .Take(M).ToArray(), int.Parse);

            StringBuilder strBulider = new StringBuilder();
            HashSet<int> numList = new HashSet<int>();

            for (int i = 0; i < N; ++i)
            {
                numList.Add(arrN[i]);
            }

            for (int i = 0; i < M; ++i)
            {
                if (numList.Contains(arrM[i]))
                {
                    strBulider.AppendLine(1.ToString());
                }
                else
                {
                    strBulider.AppendLine(0.ToString());
                }
            }

            Console.WriteLine(strBulider);
        }
    }
}
