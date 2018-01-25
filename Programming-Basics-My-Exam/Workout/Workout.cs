using System;

namespace Workout
{
    class Workout
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var firstDayKms = double.Parse(Console.ReadLine());
            var nextDayKilometers = firstDayKms;
            var allKilometers = 0.0;
            for (int i = 1; i <= days; i++)
            {
                var percentsMore = int.Parse(Console.ReadLine());
                nextDayKilometers = nextDayKilometers + ((percentsMore * nextDayKilometers) / 100);
                allKilometers += nextDayKilometers;
            }
            var finalAllKilometers = allKilometers + firstDayKms;
            if (finalAllKilometers > 1000)
            {
                var difference = Math.Ceiling(finalAllKilometers - 1000);
                Console.WriteLine($"You've done a great job running {difference} more kilometers! ");
            }
            else if (finalAllKilometers < 1000)
            {
                var difference = Math.Ceiling(1000 - finalAllKilometers);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {difference} more kilometers");
            }
        }
    }
}
