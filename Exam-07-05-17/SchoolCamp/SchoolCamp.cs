using System;

namespace SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var groupType = Console.ReadLine().ToLower();
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var sport = string.Empty;
            var price = 0.0;
            if (season == "winter")
            {
                if (groupType == "boys")
                {
                    sport = "Judo";
                    price = 9.60 * students * nights;
                }
                else if (groupType == "girls")
                {
                    sport = "Gymnastics";
                    price = 9.60 * students * nights;
                }
                else if (groupType == "mixed")
                {
                    sport = "Ski";
                    price = 10 * students * nights;
                }
            }
            else if (season == "summer")
            {
                if (groupType == "boys")
                {
                    sport = "Football";
                    price = 15 * students * nights;
                }
                else if (groupType == "girls")
                {
                    sport = "Volleyball";
                    price = 15 * students * nights;
                }
                else if (groupType == "mixed")
                {
                    sport = "Swimming";
                    price = 20 * students * nights;
                }
            }
            else if (season == "spring")
            {
                if (groupType == "boys")
                {
                    sport = "Tennis";
                    price = 7.20 * students * nights;
                }
                else if (groupType == "girls")
                {
                    sport = "Athletics";
                    price = 7.20 * students * nights;
                }
                else if (groupType == "mixed")
                {
                    sport = "Cycling";
                    price = 9.50 * students * nights;
                }
            }
            if (students >= 50)
            {
                price = 0.5 * price;
            }
            else if (students >= 20 && students < 50)
            {
                price = 0.85 * price;
            }
            else if (students >= 10 && students < 20)
            {
                price = 0.95 * price;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
