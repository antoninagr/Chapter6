using System;

namespace _11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число n = ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            if (-1 < n)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    int j = i;
                    while (j % 5 == 0)
                    {
                        j = j / 5;
                        count++;
                    }
                }
                Console.WriteLine("Числото е  " + count);
            }
            else
            {
                Console.WriteLine("Невалидно число. Нека: -1 < n.");
            }
        }
    }
}
