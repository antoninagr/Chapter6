using System;

namespace _01_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
