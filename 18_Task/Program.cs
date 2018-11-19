using System;

namespace _18_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число n = "); 
            int n = int.Parse(Console.ReadLine());

            if (1 < n && n < 21)
            {
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
                int row = 0, column = 0, rowOffset = 0, columnOffset = 1,
                   count = 0;
                while (matrix[row, column] == 0)
                {
                    matrix[row, column] = ++count;

                    if (row + rowOffset > n - 1 ||
                        row + rowOffset < 0 ||
                        column + columnOffset > n - 1 ||
                        column + columnOffset < 0 ||
                        matrix[row + rowOffset, column + columnOffset] > 0)
                    {
                        if (rowOffset == 0)
                        {
                            rowOffset = columnOffset;
                            columnOffset = 0;
                        }
                        else
                        {
                            columnOffset = -rowOffset;
                            rowOffset = 0;
                        }
                    }
                    row += rowOffset;
                    column += columnOffset;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,4}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(
                    "Невалидно число. Нека: 1 < n && n < 21.");
            }

        }
    }
}
