using System;

namespace EnergyLoss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var dancers = int.Parse(Console.ReadLine());
            var energyAll = 100.00 * days * dancers;
            var energy = 0.0;
            for (int day = 1; day <= days; day++)
            {
                var hours = int.Parse(Console.ReadLine());
                if (day % 2 == 1 && hours % 2 == 1)
                {
                    energy += 30;
                }
                else if (day % 2 == 0 && hours % 2 == 0)
                {
                    energy += 68;
                }
                else if (day % 2 == 1 && hours % 2 == 0)
                {
                    energy += 49;
                }
                else if (day % 2 == 0 && hours % 2 == 1)
                {
                    energy += 65;
                }
            }
            var energyLeft = energyAll - (energy * dancers);
            var energyLeftPerDancer = energyLeft / days / dancers;
            if (energyLeftPerDancer > 50)
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", energyLeftPerDancer);
            }
            else if (energyLeftPerDancer <= 50)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", energyLeftPerDancer);
            }
        }
    }
}
