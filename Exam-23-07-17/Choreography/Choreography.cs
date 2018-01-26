using System;

namespace Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            var steps = double.Parse(Console.ReadLine());
            var dancers = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            double stepsPerDay = Math.Ceiling(((steps / days) / steps) * 100);
            double stepsForDancer = stepsPerDay / dancers;
            if (stepsPerDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", stepsForDancer);
            }
            else if (stepsPerDay > 13)
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepsForDancer);
            }
        }
    }
}
