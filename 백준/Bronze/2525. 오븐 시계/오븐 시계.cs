using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    internal class Beakjoon2
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse).
            Take(2).ToArray();

            int h = arr[0], m = arr[1];
            int time = int.Parse(Console.ReadLine()!);

            int resultH = h;
            int resultM = m;

            resultH += time / 60;
            time = time % 60;
            resultM += time;

            if (resultM >= 60)
            {
                resultM -= 60;
                resultH++;
            }
            if (resultH >= 24)
            {
                resultH = resultH - 24;
            }
            
            Console.WriteLine(resultH + " " + resultM);

        }
    }
}
