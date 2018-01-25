using System;

namespace IvanovisFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var firstKid = double.Parse(Console.ReadLine());
            var secondKid = double.Parse(Console.ReadLine());
            var thirdKid = double.Parse(Console.ReadLine());
            var allKids = firstKid + secondKid + thirdKid;
            var moneyLeft = budget - allKids;
            var tax = 0.1 * moneyLeft;
            var donation = moneyLeft - tax;
            Console.WriteLine($"{donation:f2}");
        }
    }
}
