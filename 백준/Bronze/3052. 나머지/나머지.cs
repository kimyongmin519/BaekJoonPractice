namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            List<int> answer = new List<int>();

            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int.Parse(Console.ReadLine())) % 42;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!answer.Contains(numbers[i]))
                {
                    answer.Add(numbers[i]);
                }
            }

            Console.WriteLine(answer.Count);
        }
    }
}
