using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_all
{
    class Task1_DiscountIfElse
    {
        static void Main(string[] args)
        {
            decimal price;
            decimal discount;

            price = 420m;

                if (price < 0m)
                {
                    Console.WriteLine("Вы ввели неправильную стоимость покупки! Введите правильное значение");
                }
                else if (price < 300m)
                {
                    discount = 0m;
                    price -= price * discount;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составила "+(price * discount), price);
                }
                else if (price < 400m)
                {
                    discount = 0.03m;
                    price -= price * discount;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составила "+(price * discount), price);
                }
                else if (price < 500m)
                {
                    discount = 0.05m;
                    price -= price * discount;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составила "+(price * discount), price);
                }
                else
                {
                    discount = 0.07m;
                    price -= price * discount;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составила "+(price * discount), price);
                }
            Console.ReadKey();
        }
    }
}
