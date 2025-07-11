namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            string yS = y.ToString();
            int y1 = yS[2] -'0';
            int y2 = yS[1] - '0';
            int y3 = yS[0] - '0';

            int[] intArray = new int[3];
            intArray[0] = y1 * x;
            intArray[1] = y2 * x;
            intArray[2] = y3 * x;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine(x * y);

        }
    }
}
