using System.Linq;

namespace Baekjoon
{
    internal class Program
    {
        struct Pair
        {
            public string name;
            public int num;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Pair[] pairs = new Pair[n];

            for(int i = 0; i<n; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                pairs[i].num = int.Parse(inputs[0]);
                pairs[i].name = inputs[1];
            }

            var orderedPairs = pairs.OrderBy(pair => pair.num);
            foreach (var pair in orderedPairs)
            {
                Console.WriteLine($"{pair.num} {pair.name}");
            }
        }
    }
}
