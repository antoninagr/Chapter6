using System;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Въведете число: ");
            int lowest = 0;
            int highest = 0;
            int input;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                input = int.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Най-малко - {0}, Най-голямо - {1}", lowest, highest);
        }
    }
}
