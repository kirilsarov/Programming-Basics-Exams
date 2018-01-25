using System;

namespace IvanovisHoliday
{
    class IvanovisHoliday
    {
        static void Main(string[] args)
        {
            var nights = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine().ToLower();
            var transportType = Console.ReadLine().ToLower();
            var adultPrice = 0.0;
            var kidsPrice = 0.0;
            var adultTransport = 0.0;
            var kidsTransport = 0.0;
            if (destination == "miami")
            {
                if (nights >= 1 && nights <= 10)
                {
                    adultPrice = 2 * 24.99 * nights;
                    kidsPrice = 3 * 14.99 * nights;
                }
                if (nights >= 11 && nights <= 15)
                {
                    adultPrice = 2 * 22.99 * nights;
                    kidsPrice = 3 * 11.99 * nights;
                }
                if (nights > 15)
                {
                    adultPrice = 2 * 20 * nights;
                    kidsPrice = 3 * 10 * nights;
                }
            }
            else if (destination == "canary islands")
            {
                if (nights >= 1 && nights <= 10)
                {
                    adultPrice = 2 * 32.50 * nights;
                    kidsPrice = 3 * 28.50 * nights;
                }
                if (nights >= 11 && nights <= 15)
                {
                    adultPrice = 2 * 30.50 * nights;
                    kidsPrice = 3 * 25.60 * nights;
                }
                if (nights > 15)
                {
                    adultPrice = 2 * 28 * nights;
                    kidsPrice = 3 * 22 * nights;
                }
            }
            else if (destination == "philippines")
            {
                if (nights >= 1 && nights <= 10)
                {
                    adultPrice = 2 * 42.99 * nights;
                    kidsPrice = 3 * 39.99 * nights;
                }
                if (nights >= 11 && nights <= 15)
                {
                    adultPrice = 2 * 41 * nights;
                    kidsPrice = 3 * 36 * nights;
                }
                if (nights > 15)
                {
                    adultPrice = 2 * 38.50 * nights;
                    kidsPrice = 3 * 32.40 * nights;
                }
            }
            var finalPrice = adultPrice + kidsPrice;
            var dogPercent = 0.25 * finalPrice;
            var finalPriceWithDog = finalPrice + dogPercent;
            if (transportType == "train")
            {
                adultTransport = 2 * 22.30;
                kidsTransport = 3 * 12.50;
            }
            else if (transportType == "bus")
            {
                adultTransport = 2 * 45;
                kidsTransport = 3 * 37;
            }
            else if (transportType == "airplane")
            {
                adultTransport = 2 * 90;
                kidsTransport = 3 * 68.50;
            }
            var allTransport = adultTransport + kidsTransport;
            var allFinalPrice = finalPriceWithDog + allTransport;
            Console.WriteLine($"{allFinalPrice:f3}");
        }
    }
}
