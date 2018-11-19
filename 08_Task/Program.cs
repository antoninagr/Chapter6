using System;

namespace _08_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число N: (N >=0 ) ");
            int n = Int32.Parse(Console.ReadLine());

            int fact2N = 2 * n, factNplus1 = n + 1;

            for (int i = fact2N - 1; i > 0; i--) fact2N *= i;
            for (int i = factNplus1 - 1; i > 0; i--) factNplus1 *= i;
            for (int i = n - 1; i > 0; i--) n *= i;

            Console.WriteLine("Резулатът е {0}", fact2N / (factNplus1 * n));
        }
    }
}
