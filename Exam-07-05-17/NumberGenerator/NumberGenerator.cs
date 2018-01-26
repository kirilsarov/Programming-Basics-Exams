using System;

namespace NumberGenerator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var specialNum = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        if (specialNum < controlNum)
                        {
                            var num = i * 100 + j * 10 + k;
                            if (num % 3 == 0)
                            {
                                specialNum += 5;
                            }
                            else if (num % 10 == 5)
                            {
                                specialNum -= 2;
                            }
                            else if (num % 2 == 0)
                            {
                                specialNum = specialNum * 2;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            if (specialNum >= controlNum)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
            }
            else if (specialNum < controlNum)
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");
            }
        }
    }
}
