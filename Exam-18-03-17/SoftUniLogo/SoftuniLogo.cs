using System;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', 6 * n - 3));
            Console.Write('#');
            Console.WriteLine(new string('.', 6 * n - 3));
            for (int i = 1; i <= n * 2 - 1; i++)
            {
                Console.Write(new string('.', 6 * n - 3 - (3 * i)));
                Console.Write(new string('#', 3 * i));
                Console.Write('#');
                Console.Write(new string('#', 3 * i));
                Console.Write(new string('.', 6 * n - 3 - (3 * i)));
                Console.WriteLine();
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', 2 + 3 * i));
                Console.Write(new string('#', 12 * n - 11 - 2 * (3 * i)));
                Console.Write(new string('.', 3 + 3 * i));
                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', 3 * n - 4));
                Console.Write(new string('#', 6 * n + 1));
                Console.Write(new string('.', 3 * n - 3));
                Console.WriteLine();
            }
            Console.Write('@');
            Console.Write(new string('.', 3 * n - 4));
            Console.Write(new string('#', 6 * n + 1));
            Console.Write(new string('.', 3 * n - 3));
            Console.WriteLine();
        }
    }
}
