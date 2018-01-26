using System;

namespace Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write(new string('.', row));
                Console.Write('*');
                Console.Write(new string('.', n - row));
                Console.Write('*');
                Console.Write(new string('.', n - row));
                Console.Write('*');
                Console.WriteLine(new string('.', row));
            }
            Console.Write(new string('.', n - 1));
            Console.Write(new string('*', 5));
            Console.WriteLine(new string('.', n - 1));
            Console.WriteLine(new string('*', 2 * n + 3));
            Console.Write(new string('.', n - 1));
            Console.Write(new string('*', 5));
            Console.WriteLine(new string('.', n - 1));
            for (int row = n - 1; row > 0; row--)
            {
                Console.Write(new string('.', row - 1));
                Console.Write('*');
                Console.Write(new string('.', n - row + 1));
                Console.Write('*');
                Console.Write(new string('.', n - row + 1));
                Console.Write('*');
                Console.WriteLine(new string('.', row - 1));
            }
        }
    }
}
