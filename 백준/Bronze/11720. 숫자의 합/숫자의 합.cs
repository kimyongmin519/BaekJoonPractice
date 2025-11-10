namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string n2 = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result += n2[i] - '0';
            }

            Console.WriteLine(result);
        }
    }
}
