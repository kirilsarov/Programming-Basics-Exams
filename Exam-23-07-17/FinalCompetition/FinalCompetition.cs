using System;

namespace FinalCompetition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            var dancers = int.Parse(Console.ReadLine());
            var points = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var place = Console.ReadLine().ToLower();
            var price = 0.0;
            var cost = 0.0;
            if (place == "bulgaria")
            {
                price = dancers * points;
                if (season == "summer")
                {
                    cost = price * 0.05;
                }
                else if (season == "winter")
                {
                    cost = price * 0.08;
                }

            }
            else if (place == "abroad")
            {
                price = (dancers * points) + (0.5 * dancers * points);
                if (season == "summer")
                {
                    cost = price * 0.1;
                }
                else if (season == "winter")
                {
                    cost = price * 0.15;
                }
            }
            var income = price - cost;
            var charity = income * 0.75;
            var moneyPerDancer = (income - charity) / dancers;
            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}", moneyPerDancer);
        }
    }
}
