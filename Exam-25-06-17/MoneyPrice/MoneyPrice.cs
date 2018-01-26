using System;

namespace MoneyPrice
{
    class MoneyPrice
    {
        static void Main(string[] args)
        {
            var projectParts = int.Parse(Console.ReadLine());
            var pricePerPoint = double.Parse(Console.ReadLine());
            var points = 0.0;
            var allPoints = 0.0;
            for (int part = 1; part <= projectParts; part++)
            {
                var pointsPerPart = int.Parse(Console.ReadLine());
                if (part % 2 == 0)
                {
                    points = pointsPerPart * 2;
                }
                else if (part % 2 == 1)
                {
                    points = pointsPerPart;
                }
                allPoints = allPoints + points;
            }
            var price = allPoints * pricePerPoint;
            Console.WriteLine($"The project prize was {price:f2} lv.");
        }
    }
}
