using System;

namespace PhotoPictures
{
    class PhotoPictures
    {
        static void Main(string[] args)
        {
            var pictures = int.Parse(Console.ReadLine());
            var type = Console.ReadLine().ToLower();
            var order = Console.ReadLine().ToLower();
            var price = 0.0;
            if (type == "9x13")
            {
                price = pictures * 0.16;
                if (pictures >= 50)
                {
                    price = price * 0.95;
                }
            }
            else if (type == "10x15")
            {
                price = pictures * 0.16;
                if (pictures >= 80)
                {
                    price = price * 0.97;
                }
            }
            else if (type == "13x18")
            {
                price = pictures * 0.38;
                if (pictures >= 50 && pictures <= 100)
                {
                    price = price * 0.97;
                }
                else if (pictures > 100)
                {
                    price = price * 0.95;
                }
            }
            else if (type == "20x30")
            {
                price = pictures * 2.90;
                if (pictures >= 10 && pictures <= 50)
                {
                    price = price * 0.93;
                }
                else if (pictures > 50)
                {
                    price = price * 0.91;
                }
            }
            if (order == "online")
            {
                price = price * 0.98;
            }
            else if (order == "office")
            {
                price = price * 1;
            }
            Console.WriteLine("{0:f2}BGN", price);
        }
    }
}
