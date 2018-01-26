using System;

namespace TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            var tables = int.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var cover = tables * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            var box = tables * (lenght / 2) * (lenght / 2);
            var dollarPrice = cover * 7 + box * 9;
            var levaPrice = dollarPrice * 1.85;
            Console.WriteLine("{0:f2} USD", dollarPrice);
            Console.WriteLine("{0:f2} BGN", levaPrice);
        }
    }
}
