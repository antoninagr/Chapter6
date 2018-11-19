using System;

namespace _06_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N: (1<K<N) ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведете K: (1<K<N) ");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }

            n /= k;
            Console.WriteLine("Резултата е {0}", n);
        }
    }
}
