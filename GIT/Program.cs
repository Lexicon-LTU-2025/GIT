using System.Dynamic;

namespace GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int a = 1;
            int b = 2;

            int res = Sum(a, b);

            Console.WriteLine(res);

            int[] numbers = Enumerable.Range(1, 100).ToArray();

            foreach (var nr in numbers)
            {
                int x = nr;
            }

        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
