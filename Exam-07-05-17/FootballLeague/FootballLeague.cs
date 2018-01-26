using System;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            var stadion = double.Parse(Console.ReadLine());
            var fans = double.Parse(Console.ReadLine());
            double sectorA = 0.0;
            double sectorB = 0.0;
            double sectorV = 0.0;
            double sectorG = 0.0;
            for (int i = 1; i <= fans; i++)
            {
                var sector = Console.ReadLine().ToUpper();
                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            var sectorAPercentage = (sectorA / fans).ToString("0.00%");
            var sectorBPercentage = (sectorB / fans).ToString("0.00%");
            var sectorVPercentage = (sectorV / fans).ToString("0.00%");
            var sectorGPercentage = (sectorG / fans).ToString("0.00%");
            var stadionPercentage = (fans / stadion).ToString("0.00%");
            Console.WriteLine($"{sectorAPercentage:f2}");
            Console.WriteLine($"{sectorBPercentage:f2}");
            Console.WriteLine($"{sectorVPercentage:f2}");
            Console.WriteLine($"{sectorGPercentage:f2}");
            Console.WriteLine($"{stadionPercentage:f2}");
        }
    }
}
