using System;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            var priceWhiskey = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var whiskey = double.Parse(Console.ReadLine());
            var priceRakia = 0.5 * priceWhiskey;
            var priceWine = priceRakia - (priceRakia * 0.4);
            var priceBeer = priceRakia - (priceRakia * 0.8);
            var totalWhikey = whiskey * priceWhiskey;
            var totalBeer = beer * priceBeer;
            var totalRakia = rakia * priceRakia;
            var totalWine = wine * priceWine;
            var totalAll = totalBeer + totalRakia + totalWhikey + totalWine;
            Console.WriteLine($"{totalAll:f2}");
        }
    }
}
