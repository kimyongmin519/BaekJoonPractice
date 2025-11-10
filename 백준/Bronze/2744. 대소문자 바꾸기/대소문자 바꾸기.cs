namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            char[] resultArr = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 91)
                {
                    resultArr[i] = (char)((int)input[i] + 32);
                }
                if (input[i] > 96)
                {
                    resultArr[i] = (char)((int)input[i] - 32);
                }
            }

            foreach (var item in resultArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

        }
    }
}
