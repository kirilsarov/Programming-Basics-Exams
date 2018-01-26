using System;

namespace GroupName
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char upperLetter = char.Parse(Console.ReadLine().ToUpper());
            char lowerLetter1 = char.Parse(Console.ReadLine().ToLower());
            char lowerLetter2 = char.Parse(Console.ReadLine().ToLower());
            char lowerLetter3 = char.Parse(Console.ReadLine().ToLower());
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = 'A'; i <= upperLetter; i++)
            {
                for (char j = 'a'; j <= lowerLetter1; j++)
                {
                    for (char k = 'a'; k <= lowerLetter2; k++)
                    {
                        for (char l = 'a'; l <= lowerLetter3; l++)
                        {
                            for (int m = 0; m <= num; m++)
                            {
                                if (i == upperLetter && j == lowerLetter1 && k == lowerLetter2 && l == lowerLetter3 && m == num)
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
