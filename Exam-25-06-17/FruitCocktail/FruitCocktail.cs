using System;

namespace FruitCocktail
{
    class FruitCocktail
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var size = Console.ReadLine().ToLower();
            var drinks = int.Parse(Console.ReadLine());
            var totalPrice = 0.0;
            if (size == "small")
            {
                if (fruit == "watermelon")
                {
                    var price = 2 * 56;
                    totalPrice = price * drinks;
                }
                else if (fruit == "mango")
                {
                    var price = 2 * 36.66;
                    totalPrice = price * drinks;
                }
                else if (fruit == "pineapple")
                {
                    var price = 2 * 42.10;
                    totalPrice = price * drinks;
                }
                else if (fruit == "raspberry")
                {
                    var price = 2 * 20;
                    totalPrice = price * drinks;
                }
            }
            else if (size == "big")
            {
                if (fruit == "watermelon")
                {
                    var price = 5 * 28.70;
                    totalPrice = price * drinks;
                }
                else if (fruit == "mango")
                {
                    var price = 5 * 19.60;
                    totalPrice = price * drinks;
                }
                else if (fruit == "pineapple")
                {
                    var price = 5 * 24.80;
                    totalPrice = price * drinks;
                }
                else if (fruit == "raspberry")
                {
                    var price = 5 * 15.20;
                    totalPrice = price * drinks;
                }
            }
            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice = 0.85 * totalPrice;
            }
            else if (totalPrice > 1000)
            {
                totalPrice = 0.5 * totalPrice;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
