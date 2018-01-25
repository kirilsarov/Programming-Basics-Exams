using System;

namespace ChristmasSock
{
    class ChristmasSock
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("|");
            Console.Write(new string('-', 2 * n));
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write(new string('*', 2 * n));
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write(new string('-', 2 * n));
            Console.WriteLine("|");
            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write("|");
                Console.Write(new string('-', n - row));
                Console.Write(new string('~', row * 2));
                Console.Write(new string('-', n - row));
                Console.WriteLine("|");
            }
            for (int row = n - 2; row >= 1; row--)
            {
                Console.Write("|");
                Console.Write(new string('-', n - row));
                Console.Write(new string('~', row * 2));
                Console.Write(new string('-', n - row));
                Console.WriteLine("|");
            }
            for (int row = 0; row < n + 2; row++)
            {

                if (row == n / 2)
                {
                    Console.Write(new string('-', n / 2));
                    Console.Write('\\');
                    Console.Write(new string('.', n - 2));
                    Console.Write("MERRY");
                    Console.Write(new string('.', n - 2));
                    Console.WriteLine('\\');
                }
                else if (row == n / 2 + 2)
                {
                    Console.Write(new string('-', n / 2 + 2));
                    Console.Write('\\');
                    Console.Write(new string('.', n - 2));
                    Console.Write("X-MAS");
                    Console.Write(new string('.', n - 2));
                    Console.WriteLine('\\');
                }
                else
                {
                    Console.Write(new string('-', row));
                    Console.Write('\\');
                    Console.Write(new string('.', 2 * n + 1));
                    Console.WriteLine('\\');
                }
            }
            Console.Write(new string('-', n + 2));
            Console.Write('\\');
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(')');
        }
    }
}
