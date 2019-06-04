using System;

namespace homework_all
{
    class Months
    {
        static void Main()
        {
            //Исходные даные
            int[] arr = new int[12];

            //Заполнение массива
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 1)
                {
                    arr[i] = 28;
                    continue;
                }
                if (i == 7)
                {
                    arr[i] = 31;
                    continue;
                }
                if (i % 2 == 0 & i < 7) arr[i] = 31;
                else if (i < 7) arr[i] = 30;
                else if (i % 2 == 0 & i > 7) arr[i] = 30;
                else arr[i] = 31;
            }

            // Выводим на экран:
            Console.WriteLine("Дней в месяцах года: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("В " + (i + 1) + " месяце " + arr[i] + " дней ");
            }
            Console.ReadKey();
        }
    }
}
