using System;

namespace WireNet
{
    class WireNet
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var weight = double.Parse(Console.ReadLine());
            var wall = (2 * lenght) + (2 * width);
            var wallPrice = wall * price;
            var wallAll = wall * height;
            var wallWeight = wallAll * weight;
            Console.WriteLine(wall);
            Console.WriteLine("{0:f2}", wallPrice);
            Console.WriteLine("{0:f3}", wallWeight);
        }
    }
}
