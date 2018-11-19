using System;

namespace _09_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, temp = 1;
            Console.Write("Въведете число n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете число x: ");
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }

            Console.WriteLine("Резултатът е: {0}", sum);

        }
    }
}
