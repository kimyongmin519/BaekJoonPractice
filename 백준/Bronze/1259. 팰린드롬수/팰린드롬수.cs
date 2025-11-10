

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                string inputSt = input.ToString();
                int stack = 0;

                for (int i = 0; i < inputSt.Length; i++)
                {
                    if (inputSt[i] == inputSt.Reverse().ToArray()[i])
                    {
                        stack++;
                    }
                }
                if (stack == inputSt.Length)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
                input = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
