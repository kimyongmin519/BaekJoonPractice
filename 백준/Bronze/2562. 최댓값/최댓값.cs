namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int result = 0;
            int order = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (result < numbers[i])
                {
                    result = numbers[i];
                    order = i + 1;  
                }
            }

            Console.WriteLine(result);
            Console.WriteLine(order);

        }
    }
}
