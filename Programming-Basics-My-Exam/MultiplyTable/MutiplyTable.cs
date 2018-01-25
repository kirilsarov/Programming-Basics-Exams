using System;

namespace MultiplyTable
{
    class MutiplyTable
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var numCopy = num;
            var digit1 = numCopy % 10;
            numCopy /= 10;
            var digit2 = numCopy % 10;
            numCopy /= 10;
            var digit3 = numCopy % 10;
            for (int i = 1; i <= digit1; i++)
            {
                for (int j = 1; j <= digit2; j++)
                {
                    for (int k = 1; k <= digit3; k++)
                    {
                        var result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}
