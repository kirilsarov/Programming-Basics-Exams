using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var progress = double.Parse(Console.ReadLine());
            var minSalary = double.Parse(Console.ReadLine());
            var scholarshipGrade = 0.0;
            var scholarshipSocial = 0.0;
            if (progress <= 4.50 || income > minSalary && progress < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            if (progress > 4.50 && income < minSalary)
            {
                scholarshipSocial = Math.Floor(minSalary * 0.35);
            }
            if (progress >= 5.50)
            {
                scholarshipGrade = Math.Floor(progress * 25);
            }
            if (scholarshipGrade > scholarshipSocial)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", scholarshipGrade);
            }
            else if (scholarshipGrade < scholarshipSocial)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", scholarshipSocial);
            }
        }
    }
}
