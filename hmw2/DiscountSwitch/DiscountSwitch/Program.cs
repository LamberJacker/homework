using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_all
{
    class Task2_DiscountSwitch
    {
        static void Main()
        {
            Console.WriteLine("Нипиши на сколько денег ты кипил товаров?");
			decimal money = Convert.ToDecimal(Console.ReadLine());
            decimal discount;

            switch (true)
            {
            case (money<0m): 
            Console.WriteLine("вам не хватет денег купить что-то, идите работать");
            break;
            case (money<300m):
            Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составит $0.000", money);
            break;
            case (money<400m): 
            discount=0.03m;
            Console.WriteLine("цена вашей покупки ${0:#.##}, ваша скидка составит ${1:#.##}", money-=money*discount, money*discount);
            break;
            case (money<500m): 
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
