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
            BigInteger money = 0;
            BigInteger num = 0;
            
            BigInteger[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), BigInteger.Parse);
            money = arr[0];
            num = arr[1];

            Console.WriteLine(money / num);
            Console.WriteLine(money % num);
        }
    }
}
