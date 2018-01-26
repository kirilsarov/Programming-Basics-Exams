using System;

namespace Java
{
    class Java
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var poorMark = 0;
            var satisfactoryMark = 0;
            var goodMark = 0;
            var veryGoodMark = 0;
            var excellentMark = 0;
            for (int i = 1; i <= n; i++)
            {
                var mark = double.Parse(Console.ReadLine());
                if (mark >= 0 && mark < 22.5)
                {
                    poorMark += 1;
                }
                else if (mark >= 22.5 && mark < 40.5)
                {
                    satisfactoryMark += 1;
                }
                else if (mark >= 40.5 && mark < 58.5)
                {
                    goodMark += 1;
                }
                else if (mark >= 58.5 && mark < 76.5)
                {
                    veryGoodMark += 1;
                }
                else if (mark >= 76.5 && mark <= 100)
                {
                    excellentMark += 1;
                }
            }
            var poorMarkPercent = (poorMark / n) * 100;
            var satisfactoryMarkPercent = (satisfactoryMark / n) * 100;
            var goodMarkPercent = (goodMark / n) * 100;
            var veryGoodMarkPercent = (veryGoodMark / n) * 100;
            var excellentMarkPercent = (excellentMark / n) * 100;
            Console.WriteLine("{0:f2}% poor marks", poorMarkPercent);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactoryMarkPercent);
            Console.WriteLine("{0:f2}% good marks", goodMarkPercent);
            Console.WriteLine("{0:f2}% very good marks", veryGoodMarkPercent);
            Console.WriteLine("{0:f2}% excellent marks", excellentMarkPercent);
        }
    }
}
