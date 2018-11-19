using System;

namespace _15_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Шеснадесетична бройна система: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
            Console.WriteLine("Десетична бройна система {0}", toDecimal);
             
        }
    }
}
