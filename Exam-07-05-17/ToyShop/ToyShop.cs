using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            var priceVacation = double.Parse(Console.ReadLine());
            var puzzle = int.Parse(Console.ReadLine());
            var dolls = int.Parse(Console.ReadLine());
            var bears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());
            var allToys = puzzle + dolls + bears + minions + trucks;
            var orderMoney = 0.9 * (puzzle * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2);
            if (allToys >= 50)
            {
                orderMoney = 0.75 * orderMoney;
            }
            if (orderMoney >= priceVacation)
            {
                var difference = orderMoney - priceVacation;
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else if (orderMoney < priceVacation)
            {
                var difference = priceVacation - orderMoney;
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
