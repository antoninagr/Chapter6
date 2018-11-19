using System;

namespace _13_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Двуична бройна система: ");
            int n = int.Parse(Console.ReadLine());
            string toDouble = Convert.ToString((n , 2) , 10);
            Console.WriteLine("Десетична бройна система {0}", toDouble);
        }
    }
}
