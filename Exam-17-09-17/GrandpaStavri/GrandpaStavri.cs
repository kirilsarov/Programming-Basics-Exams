using System;

namespace GrandpaStavri
{
    class GrandpaStavri
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var litersRakia = 0.0;
            var degreecesRakia = 0.0;
            var allLitersRakia = 0.0;
            var stack = 0.0;
            var litersStack = 0.0;
            for (int i = 1; i <= days; i++)
            {
                litersRakia = double.Parse(Console.ReadLine());
                degreecesRakia = double.Parse(Console.ReadLine());
                stack = litersRakia * degreecesRakia;
                allLitersRakia += stack;
                litersStack += litersRakia;
            }
            var midDegreecesRakia = allLitersRakia / litersStack;
            Console.WriteLine($"Liter: {litersStack:f2}");
            Console.WriteLine($"Degrees: {midDegreecesRakia:f2}");
            if (midDegreecesRakia < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (midDegreecesRakia >= 38 && midDegreecesRakia <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (midDegreecesRakia > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
