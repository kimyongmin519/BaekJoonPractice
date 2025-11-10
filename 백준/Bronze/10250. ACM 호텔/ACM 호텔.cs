using System.Security.Cryptography.X509Certificates;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int[][] rooms = new int[number][]; 

            for (int i = 0; i < number; i++)
            {
                rooms[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }

            for (int i = 0; i < number; i++)
            {
                ChoiceRooms(rooms[i]);
            }


            void ChoiceRooms(int[] data)
            {
                int currentH = 1;
                int currentW = 1;

                for (int i = 1; i < data[2]; i++)
                {
                    if (currentH >= data[0])
                    {
                        currentH = 1;
                        currentW++;
                    }
                    else
                    {
                        currentH++;
                    }
                }

                Console.WriteLine($"{(currentH * 100) + currentW}");
            }

        }
    }
}