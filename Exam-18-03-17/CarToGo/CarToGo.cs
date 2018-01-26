using System;

namespace CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            string classType = string.Empty;
            var carPrice = 0.0;
            string carType = string.Empty;
            if (budget > 500)
            {
                classType = "Luxury class";
                carPrice = 0.9 * budget;
                carType = "Jeep";
            }
            else if (budget > 100 && budget <= 500)
            {
                classType = "Compact class";
                if (season == "summer")
                {
                    carPrice = 0.45 * budget;
                    carType = "Cabrio";
                }
                else if (season == "winter")
                {
                    carPrice = 0.8 * budget;
                    carType = "Jeep";
                }
            }
            else if (budget <= 100)
            {
                classType = "Economy class";
                if (season == "summer")
                {
                    carPrice = 0.35 * budget;
                    carType = "Cabrio";
                }
                else if (season == "winter")
                {
                    carPrice = 0.65 * budget;
                    carType = "Jeep";
                }
            }
            Console.WriteLine(classType);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
