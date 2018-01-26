using System;

namespace Crown
{
    class Crown
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("@");
            Console.Write(new string(' ', n - 2));
            Console.Write("@");
            Console.Write(new string(' ', n - 2));
            Console.Write("@");
            Console.WriteLine();
            Console.Write(new string('*', 2));
            Console.Write(new string(' ', n - 3));
            Console.Write('*');
            Console.Write(new string(' ', n - 3));
            Console.Write(new string('*', 2));
            Console.WriteLine();
            for (int row = 0; row <= (n / 2) - 3; row++)
            {
                Console.Write('*');
                Console.Write(new string('.', row + 1));
                Console.Write('*');
                Console.Write(new string(' ', (n - 5 - (2 * row))));
                Console.Write('*');
                Console.Write(new string('.', 1 + 2 * row));
                Console.Write('*');
                Console.Write(new string(' ', (n - 5 - (2 * row))));
                Console.Write('*');
                Console.Write(new string('.', row + 1));
                Console.Write('*');
                Console.WriteLine();
            }
            Console.Write('*');
            Console.Write(new string('.', n / 2 - 1));
            Console.Write('*');
            Console.Write(new string('.', n - 3));
            Console.Write('*');
            Console.Write(new string('.', n / 2 - 1));
            Console.Write('*');
            Console.WriteLine();
            Console.Write('*');
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', n / 2 - 2));
            Console.Write('.');
            Console.Write(new string('*', n / 2 - 2));
            Console.Write(new string('.', n / 2));
            Console.Write('*');
            Console.WriteLine();
            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
