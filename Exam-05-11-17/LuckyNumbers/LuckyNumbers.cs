﻿using System;

namespace LuckyNumbers
{
    class LuckyNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if ((i + j) == (k + l))
                            {
                                if (n % (i + j) == 0)
                                {
                                    Console.Write("{0}{1}{2}{3} ", i, j, k, l);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
