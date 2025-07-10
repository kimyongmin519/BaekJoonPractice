namespace BackTung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine((intA[0] + intA[1]) % intA[2]);
            Console.WriteLine(((intA[0] % intA[2]) + (intA[1] % intA[2])) % intA[2]);
            Console.WriteLine((intA[0] * intA[1]) % intA[2]);
            Console.WriteLine(((intA[0] % intA[2]) * (intA[1] % intA[2])) % intA[2]);
        }
    }
}
