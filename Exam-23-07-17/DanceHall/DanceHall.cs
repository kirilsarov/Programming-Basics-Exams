using System;

namespace DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var furnitureSide = double.Parse(Console.ReadLine());
            var room = (lenght * 100) * (width * 100);
            var furniture = (furnitureSide * 100) * (furnitureSide * 100);
            var bench = room / 10;
            var freeSpace = room - furniture - bench;
            var dancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
