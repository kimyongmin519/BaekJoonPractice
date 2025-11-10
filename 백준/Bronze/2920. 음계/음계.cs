namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];

            numbers = Console.ReadLine().Split().Select(int.Parse)
            .Take(8).ToArray();
            


            bool asc = true;
            bool desc = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != i + 1) asc = false;
                if (numbers[i] != 8 - i) desc = false;
            }

            if (asc) Console.WriteLine("ascending");
            else if (desc) Console.WriteLine("descending");
            else Console.WriteLine("mixed");
                

        }
    }
}
