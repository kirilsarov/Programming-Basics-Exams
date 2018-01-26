using System;

namespace Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());
            var aquarium = length * width * hight;
            var liters = aquarium * 0.001;
            var other = percent * 0.01;
            var answer = liters * (1 - other);
            Console.WriteLine("{0:0.000}", answer);
        }
    }
}
