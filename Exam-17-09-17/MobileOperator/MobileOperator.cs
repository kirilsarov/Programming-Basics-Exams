using System;

namespace MobileOperator
{
    class MobileOperator
    {
        static void Main(string[] args)
        {
            var contractLenght = Console.ReadLine().ToLower();
            var contractType = Console.ReadLine().ToLower();
            var addedInternet = Console.ReadLine().ToLower();
            var monthsToPay = int.Parse(Console.ReadLine());
            if (contractLenght == "one")
            {
                if (contractType == "small")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (5.50 + 9.98);
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 9.98;
                        Console.WriteLine($"{payment:f2} lv.");
                    }

                }
                else if (contractType == "middle")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (4.35 + 18.99);
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 18.99;
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                }
                else if (contractType == "large")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (4.35 + 25.98);
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 25.98;
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                }
                else if (contractType == "extralarge")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (3.85 + 35.99);
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 35.99;
                        Console.WriteLine($"{payment:f2} lv.");
                    }
                }
            }
            else if (contractLenght == "two")
            {
                if (contractType == "small")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (5.50 + 8.58);
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 8.58;
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }

                }
                else if (contractType == "middle")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (4.35 + 17.09);
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 17.09;
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                }
                else if (contractType == "large")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (4.35 + 23.59);
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 23.59;
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                }
                else if (contractType == "extralarge")
                {
                    if (addedInternet == "yes")
                    {
                        var payment = monthsToPay * (3.85 + 31.79);
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                    else
                    {
                        var payment = monthsToPay * 31.79;
                        var paymentWithDiscount = payment - (payment * 0.0375);
                        Console.WriteLine($"{paymentWithDiscount:f2} lv.");
                    }
                }
            }
        }
    }
}
