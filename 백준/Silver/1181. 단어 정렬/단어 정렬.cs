namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] strArr = new string[n];


            for (int i = 0; i < n; i++)
            {
                strArr[i] = Console.ReadLine()!;
            }

            strArr = strArr.Distinct().
                OrderBy(w => w.Length).
                ThenBy(w => w).
                ToArray();

            foreach (string str in strArr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
