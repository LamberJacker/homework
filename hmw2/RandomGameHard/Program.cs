using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework_all
{
    class Task3_RandomGameHard
    {
        static void Main()
        {
            Random rnd = new Random();
            int startValue = rnd.Next(0, 1000000);

            //-----------------------------------------

            Console.WriteLine(startValue); //строка для самопроверки

            //-----------------------------------------
            int numbers = ((int) Math.Log10(startValue))+1;
            Console.WriteLine("Количество чисел в загаданом числе составляет: {0}", numbers);
            //-----------------------------------------
            long sum = 0;
            for (int i = 3; i<=startValue; i++)
            {
                if (i%3 == 0)
                {
                    sum+=i;
                }
            }
            Console.WriteLine("Сумма всех чисел кратное трем равна: {0}", sum);
            //-----------------------------------------
            long count = 0;
            for (int i = 0; i<=startValue; i++)
            {
                if (i%2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество всех не четных чисел равна: {0}", (startValue-count));
            Console.ReadKey();
        }
    }
}
