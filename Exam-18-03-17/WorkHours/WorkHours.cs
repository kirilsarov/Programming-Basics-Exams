using System;

namespace WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());
            var workHours = workers * workDays * 8;
            if (workHours >= hoursNeeded)
            {
                var difference = workHours - hoursNeeded;
                Console.WriteLine($"{difference} hours left");
            }
            else if (workHours < hoursNeeded)
            {
                var difference = hoursNeeded - workHours;
                var commision = difference * workDays;
                Console.WriteLine($"{difference} overtime");
                Console.WriteLine($"Penalties: {commision}");
            }
        }
    }
}
