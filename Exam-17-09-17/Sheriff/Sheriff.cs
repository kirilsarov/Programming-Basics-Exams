using System;

namespace Sheriff
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', ((3 * n - 1) / 2)));
            Console.Write('x');
            Console.WriteLine(new string('.', ((3 * n - 1) / 2)));
            Console.Write(new string('.', ((3 * n - 3) / 2)));
            Console.Write('/');
            Console.Write('x');
            Console.Write('\\');
            Console.WriteLine(new string('.', ((3 * n - 3) / 2)));
            Console.Write(new string('.', ((3 * n - 3) / 2)));
            Console.Write('x');
            Console.Write('|');
            Console.Write('x');
            Console.WriteLine(new string('.', ((3 * n - 3) / 2)));
            for (int row = 0; row < n / 2 + 1; row++)
            {
                Console.Write(new string('.', n / 2 - row));
                Console.Write(new string('x', n + row));
                Console.Write('|');
                Console.Write(new string('x', n + row));
                Console.WriteLine(new string('.', n / 2 - row));
            }
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('.', row));
                Console.Write(new string('x', ((3 * n) / 2) - row));
                Console.Write('|');
                Console.Write(new string('x', ((3 * n) / 2) - row));
                Console.WriteLine(new string('.', row));
            }
            Console.Write(new string('.', ((3 * n - 3) / 2)));
            Console.Write('/');
            Console.Write('x');
            Console.Write('\\');
            Console.WriteLine(new string('.', ((3 * n - 3) / 2)));
            Console.Write(new string('.', ((3 * n - 3) / 2)));
            Console.Write('\\');
            Console.Write('x');
            Console.Write('/');
            Console.WriteLine(new string('.', ((3 * n - 3) / 2)));
            for (int row = 0; row < n / 2 + 1; row++)
            {
                Console.Write(new string('.', n / 2 - row));
                Console.Write(new string('x', n + row));
                Console.Write('|');
                Console.Write(new string('x', n + row));
                Console.WriteLine(new string('.', n / 2 - row));
            }
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('.', row));
                Console.Write(new string('x', ((3 * n) / 2) - row));
                Console.Write('|');
                Console.Write(new string('x', ((3 * n) / 2) - row));
                Console.WriteLine(new string('.', row));
            }
            Console.Write(new string('.', ((3 * n - 3) / 2)));
            Console.Write('x');
            Console.Write('|');
            Console.Write('x');
            Console.WriteLine(new string('.', ((3 * n - 3) / 2)));
            Console.Write(new string('.', ((3 * n - 3) / 2)));
            Console.Write('\\');
            Console.Write('x');
            Console.Write('/');
            Console.WriteLine(new string('.', ((3 * n - 3) / 2)));
            Console.Write(new string('.', ((3 * n - 1) / 2)));
            Console.Write('x');
            Console.WriteLine(new string('.', ((3 * n - 1) / 2)));
        }
    }
}
