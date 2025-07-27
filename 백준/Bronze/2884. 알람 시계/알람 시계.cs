using System.Threading.Channels;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] time = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (time[1] < 45)
            {
                time[0]--;
                time[1] = 60 - (45 - time[1]);
                if (time[0] < 0)
                    time[0] = 23;
            }
            else
            {
                time[1] -= 45;
            }

            Console.Write(time[0] + " " + time[1]);
        }
    }
}
