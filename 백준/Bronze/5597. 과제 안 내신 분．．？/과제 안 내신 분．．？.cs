namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int[] students = new int[31];

            for (int i = 0; i < 28; i++)
            {
                int a = int.Parse(Console.ReadLine());

                students[a] = a;
            }

            for (int i = 1; i < students.Length; i++)
            {
                if (students[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
