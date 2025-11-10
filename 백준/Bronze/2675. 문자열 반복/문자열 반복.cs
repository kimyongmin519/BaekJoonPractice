using System.Security.Cryptography.X509Certificates;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());


            for (int i = 0; i < numbers; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                for (int j = 0; j < inputs[1].Length; j++)
                {
                    for (int l = 0; l < (int)Char.GetNumericValue(inputs[0][0]); l++)
                    {
                        Console.Write(inputs[1][j]);
                    }
                }
                Console.WriteLine();
            }

            

        }
    }
}
