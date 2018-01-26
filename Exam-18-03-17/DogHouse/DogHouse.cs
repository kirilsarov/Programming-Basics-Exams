using System;

namespace DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var sides = 2 * (a * (a / 2));
            var backSideSquare = (a / 2) * (a / 2);
            var backSideTriangle = ((a / 2) * (b - a / 2)) / 2;
            var backSide = backSideSquare + backSideTriangle;
            var door = (a / 5) * (a / 5);
            var frontSide = backSide - door;
            var roof = 2 * (a * (a / 2));
            var redPaint = roof / 5;
            var greenPaint = (sides + backSide + frontSide) / 3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
