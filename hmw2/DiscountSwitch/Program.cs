using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_all
{
    class Task1_DiscountSwitch
    {
        static void Main()
        {
            Console.WriteLine("Нипиши на сколько денег ты купил товаров?");
			decimal money = Convert.ToDecimal(Console.ReadLine());
            decimal discount;

            switch (money)
            {
                case decimal check when (check<0m): 
                    Console.WriteLine("вам не хватет денег купить что-то, идите работать");
                    break;
                case decimal check when (check<300m):
                    discount=0.00m;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составит ${1}", money, discount);
                    break;
                case decimal check when (check<400m): 
                    discount=0.03m;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составит ${1:#.##}", money-=money*discount, money*discount);
                    break;
                case decimal check when (check<500m): 
                    discount=0.05m;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составит ${1:#.##}",  money-=money*discount, money*discount);
                    break;
                default:
                    discount=0.07m;
                    Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составит ${1:#.##}",  money-=money*discount, money*discount);
                    break;
        	}
        	Console.ReadKey();
        }
    }
}
