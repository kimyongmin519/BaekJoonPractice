namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            char[] Scores = { 'A', 'B', 'C', 'D', 'F' };

            string input = Console.ReadLine()!;

            float result = 0.0f;

            for (int i = 0; i < Scores.Length; i++)
            {
                if (input[0] == Scores[i])
                {
                    result = 4 - i;

                    if (result <= 0)
                        break;

                    if (input[1] == '+')
                        result += 0.3f;
                    else if (input[1] == '-')
                        result -= 0.3f;
                }
            }

            Console.WriteLine(result.ToString("F1"));

        }
    }
}
