using System;

namespace NewYearsEveParty
{
    class NewYearsEveParty
    {
        static void Main(string[] args)
        {
            var guests = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());
            var cuverts = guests * 20;
            if (budget > cuverts)
            {
                var moneyLeft = budget - cuverts;
                var pyro = Math.Round(0.4 * moneyLeft);
                var donation = moneyLeft - pyro;
                Console.WriteLine($"Yes! {pyro} lv are for fireworks and {donation} lv are for donation. ");
            }
            else
            {
                var difference = cuverts - budget;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {difference} lv more.");
            }
        }
    }
}
