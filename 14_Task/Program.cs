using System;

namespace _14_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Десетична бройна система: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);
            Console.WriteLine("Шеснадесетична бройна система {0}", toDecimal);
        }
    }
}

