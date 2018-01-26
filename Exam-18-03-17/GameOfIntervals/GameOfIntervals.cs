using System;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            var moves = int.Parse(Console.ReadLine());
            var result = 0.0;
            var counter0to9 = 0.0;
            var counter10to19 = 0.0;
            var counter20to29 = 0.0;
            var counter30to39 = 0.0;
            var counter40to50 = 0.0;
            var counterInvalid = 0.0;
            for (int i = 1; i <= moves; i++)
            {
                var step = int.Parse(Console.ReadLine());
                if (step >= 0 && step <= 9)
                {
                    result += 0.2 * step;
                    counter0to9++;
                }
                else if (step >= 10 && step <= 19)
                {
                    result += 0.3 * step;
                    counter10to19++;
                }
                else if (step >= 20 && step <= 29)
                {
                    result += 0.4 * step;
                    counter20to29++;
                }
                else if (step >= 30 && step <= 39)
                {
                    result += 50;
                    counter30to39++;
                }
                else if (step >= 40 && step <= 50)
                {
                    result += 100;
                    counter40to50++;
                }
                else if (step > 50 || step < 0)
                {
                    result = result / 2;
                    counterInvalid++;
                }
            }
            var percent0to9 = (counter0to9 / moves) * 100;
            var percent10to19 = (counter10to19 / moves) * 100;
            var percent20to29 = (counter20to29 / moves) * 100;
            var percent30to39 = (counter30to39 / moves) * 100;
            var percent40to50 = (counter40to50 / moves) * 100;
            var percentInvalid = (counterInvalid / moves) * 100;
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {percent0to9:f2}%");
            Console.WriteLine($"From 10 to 19: {percent10to19:f2}%");
            Console.WriteLine($"From 20 to 29: {percent20to29:f2}%");
            Console.WriteLine($"From 30 to 39: {percent30to39:f2}%");
            Console.WriteLine($"From 40 to 50: {percent40to50:f2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");
        }
    }
}
