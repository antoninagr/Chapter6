using System;

namespace _17_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведете число k = ");
            int k = int.Parse(Console.ReadLine());

            int gcd = 1;
            if (0 < n && 0 < k)
            {
                for (int i = Math.Min(n, k); i > 0; i--)
                {
                    if (n % i == 0 && k % i == 0)
                    {
                        gcd = i;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(
                    "Невалидни числа. Нека: 0 < n && 0 < k.");
            }
            Console.WriteLine(
               "Най-голям общ делител = " + gcd);
        }
    }
}
