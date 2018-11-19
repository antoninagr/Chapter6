using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете брой на членовете на редицата, до който да се отпечата ");
            int n = int.Parse(Console.ReadLine());
            int a, b, s;
            a = 0;
            b = 1;
            s = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);


            for (int i = 2; i <= n; i++)
            {
                s = a + b;
                Console.WriteLine(s);
                a = b;
                b = s;

            }
        }
    }
}
