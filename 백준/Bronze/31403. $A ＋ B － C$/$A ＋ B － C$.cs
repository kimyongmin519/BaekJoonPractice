namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b - c);
            Console.WriteLine(int.Parse($"{a}{b}") - c);

        }
    }
}
