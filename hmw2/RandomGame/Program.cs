using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_all
{
    class Task2_RandomGameHard
    {
        static void Main()
        {
           Random rnd = new Random();
            int startValue = rnd.Next(0, 100);
            
            //-----------------------------------------
            Console.WriteLine("Компьютер загадал это число: " + startValue); //строка для самопроверки
            //-----------------------------------------

        	Console.WriteLine("\nУ тебя есть 5 попыток угадать загаданое число от 0 до 100 включительно.\nПоехали...");
            int userValue = 0;
            bool check = false;
			int i;

            for (i = 1; i<=5; i++)
            {
                Console.WriteLine("\nТы угадуешь " + i + " раз. Пиши число:");
                userValue = Convert.ToInt32(Console.ReadLine());
                if(userValue == startValue)
                {
                    check = true;
                    break;
                }
                else
                {
                    Console.WriteLine("- Ты не угадал " + userValue + " не то число которое я загадал");
                    Console.WriteLine("- Даю тебе подсказку, мое число " + (startValue > userValue ? "больше" : "меньше"));
                }
            }
            if (check == true) 
            {
            Console.WriteLine("- Ты угадал! C " + i + " раза. КРАСАВА!");
            }
            else 
            {   
            Console.WriteLine("- Ты LOOSER, сыграй еще)");
            }
            Console.ReadKey();
        }
    }
}
