namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int sn = 0;
            int result = 0;

            int[] arr = new int[n];

            arr = Console.ReadLine().Split().Select(int.Parse).Take(n).ToArray();

            sn = int.Parse(Console.ReadLine());

            foreach (var item in arr)
            {
                if (item == sn)
                {
                    result++;
                }
            }

            Console.WriteLine(result);

        }
    }
}
