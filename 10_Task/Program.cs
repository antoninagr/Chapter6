using System;

namespace _10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число(n<20) n =");
            int n = int.Parse(Console.ReadLine());

            if (0 < n && n < 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < i + 1 + n; j++)
                    {
                        Console.Write("{0,3}", j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Невалидно число. Нека да е  0 < n < 20.");
            }
        }
    }
}
