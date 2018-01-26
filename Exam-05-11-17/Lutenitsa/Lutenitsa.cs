using System;

namespace Lutenitsa
{
    class Lutenitsa
    {
        static void Main(string[] args)
        {
            var tomatos = double.Parse(Console.ReadLine());
            var boxes = int.Parse(Console.ReadLine());
            var jars = int.Parse(Console.ReadLine());
            var lutenica = tomatos / 5;
            var jarsLutenica = lutenica / 0.535;
            var boxesLutenica = jarsLutenica / jars;
            if (boxesLutenica > boxes)
            {
                var differenceBoxes = Math.Floor(boxesLutenica - boxes);
                var differenceJars = Math.Floor(jarsLutenica - (boxes * jars));
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenica));
                Console.WriteLine("{0} boxes left.", differenceBoxes);
                Console.WriteLine("{0} jars left.", differenceJars);
            }
            else if (boxes > boxesLutenica)
            {
                var differenceBoxes = Math.Floor(boxes - boxesLutenica);
                var differenceJars = Math.Floor((jars * boxes) - jarsLutenica);
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenica));
                Console.WriteLine("{0} more boxes needed.", differenceBoxes);
                Console.WriteLine("{0} more jars needed.", differenceJars);
            }
        }
    }
}
