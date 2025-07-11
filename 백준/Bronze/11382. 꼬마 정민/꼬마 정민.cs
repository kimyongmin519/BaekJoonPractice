namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input != null)
            {
                long[] jungminSay = Array.ConvertAll(input.Split(), long.Parse);
                long x = 0;

                for (int i = 0; i < jungminSay.Length; i++)
                {
                    x += jungminSay[i];
                }
                Console.Write(x);
            }
        }
    }
}
