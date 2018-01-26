using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if (i < j && j < k && i + j + k == n)
                        {
                            flag = 1;
                            Console.WriteLine($"{i} + {j} + {k} = {n}");
                        }
                        if (i > j && j > k && i * j * k == n)
                        {
                            flag = 1;
                            Console.WriteLine($"{i} * {j} * {k} = {n}");
                        }
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
