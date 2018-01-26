using System;

namespace ThreeBrothers
{
    class ThreeBrothers
    {
        static void Main(string[] args)
        {
            var firstBrother = double.Parse(Console.ReadLine());
            var secondBrother = double.Parse(Console.ReadLine());
            var thirdBrother = double.Parse(Console.ReadLine());
            var father = double.Parse(Console.ReadLine());
            var brothersTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            var timeWithRelax = Math.Round((brothersTime * 0.15 + brothersTime), 2);
            if (father >= timeWithRelax)
            {
                var timeLeft = Math.Floor(father - timeWithRelax);
                Console.WriteLine($"Cleaning time: {timeWithRelax:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }
            else
            {
                var shortage = Math.Ceiling(timeWithRelax - father);
                Console.WriteLine($"Cleaning time: {timeWithRelax:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {shortage} hours.");
            }
        }
    }
}
