using System;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var oneLev = int.Parse(Console.ReadLine());
            var twoLev = int.Parse(Console.ReadLine());
            var fiveLev = int.Parse(Console.ReadLine());
            var amouth = int.Parse(Console.ReadLine());
            for (int i = 0; i <= oneLev; i++)
            {
                for (int j = 0; j <= twoLev; j++)
                {
                    for (int k = 0; k <= fiveLev; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == amouth)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {amouth} lv.");
                        }
                    }
                }
            }
        }
    }
}
