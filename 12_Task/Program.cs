using System;

namespace _12_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Десетична бройна система : ");
            int decimalN = int.Parse(Console.ReadLine());

            int rest;
            string result = string.Empty;
            while (decimalN > 0)
            {
                rest = decimalN % 2;
                decimalN /= 2;
                result += rest.ToString();
            }

            Console.WriteLine("Двоична бройна система:  {0}", result);
        }
    }
}
