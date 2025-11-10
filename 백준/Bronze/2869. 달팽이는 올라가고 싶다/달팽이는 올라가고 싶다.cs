namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            double[] inputs = Console.ReadLine().Split().Take(3).Select(double.Parse).ToArray();

            double days = ((inputs[2] - inputs[1]) / (inputs[0] - inputs[1]));


            Console.WriteLine((int)Math.Ceiling(days));
        }
    }
}
