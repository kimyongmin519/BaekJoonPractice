

namespace Baekjoon
{
    internal class Program
    {
        static void Main()
        {
            int classNumber = int.Parse(Console.ReadLine());

            double[] scores = Console.ReadLine().Split().Select(double.Parse).Take(classNumber).ToArray();
            double maxScore = scores.Max();

            double[] newScores = new double[classNumber];

            for (int i = 0; i < classNumber; i++)
            {
                newScores[i] = (scores[i] / maxScore) * 100;
            }

            Console.WriteLine((newScores.Sum() / classNumber));

        }
    }
}
