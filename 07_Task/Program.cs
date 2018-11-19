using System;

namespace _07_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число N: (1<K<N) ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведете число K: (1<K<N) ");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }

            n = n * k / (n - k);
            Console.WriteLine("Резултатът е: {0}", n);
        }
    }
}
