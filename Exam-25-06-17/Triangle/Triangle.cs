using System;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('#', (4 * n) + 1));
            for (int row = 0; row < n; row++)
            {
                if (row == n / 2)
                {
                    Console.Write(new string('.', row + 1));
                    Console.Write(new string('#', (2 * n) - (2 * row) - 1));
                    Console.Write(new string(' ', row - 1));
                    Console.Write("(@)");
                    Console.Write(new string(' ', row - 1));
                    Console.Write(new string('#', (2 * n) - (2 * row) - 1));
                    Console.WriteLine(new string('.', row + 1));
                }
                else
                {
                    Console.Write(new string('.', row + 1));
                    Console.Write(new string('#', (2 * n) - (2 * row) - 1));
                    Console.Write(new string(' ', 1 + 2 * row));
                    Console.Write(new string('#', (2 * n) - (2 * row) - 1));
                    Console.WriteLine(new string('.', row + 1));
                }
            }
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', n + row));
                Console.Write(new string('#', (2 * n) - (2 * row) + 1));
                Console.WriteLine(new string('.', n + row));
            }
        }
    }
}
