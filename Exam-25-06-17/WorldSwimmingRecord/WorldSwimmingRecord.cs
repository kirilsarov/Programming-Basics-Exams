using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var oneMeterTime = double.Parse(Console.ReadLine());
            var ivanchoTime = lenght * oneMeterTime;
            var slowing = Math.Floor(lenght / 15) * 12.5;
            var ivanchoTimeFull = ivanchoTime + slowing;
            if (record <= ivanchoTimeFull)
            {
                var difference = ivanchoTimeFull - record;
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
            else if (record > ivanchoTimeFull)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTimeFull:f2} seconds.");
            }
        }
    }
}
