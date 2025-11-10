namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(Console.OpenStandardInput());
            using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int siu = int.Parse(sr.ReadLine());
            int[][] numbers = new int[siu][];

            for (int i = 0; i < siu; i++)
            {
                numbers[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            }

            Array.Sort(numbers, (a,b) =>
            {
                if (a[0] == b[0])
                    return a[1].CompareTo(b[1]);
                else
                    return a[0].CompareTo(b[0]);
            });

            foreach (var item in numbers)
            {
                foreach (var i in item)
                {
                    sw.Write(i + " ");
                }
                sw.WriteLine();
            }
        }
    }
}
