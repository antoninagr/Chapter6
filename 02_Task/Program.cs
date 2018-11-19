using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете n = ");

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) == 0)
                {
                    Console.WriteLine(" ");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


