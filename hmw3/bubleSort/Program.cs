using System;

namespace homework_all
{
    class arrSort
    {
        static void Main()
        {
            //Исходные даные
            int[] arr = new int [10]; //Длина массива
            Random rnd = new Random(); //Создадим экземпляр класса Random
            int rndValue = 0; //число которое рандомно генерируеться
            
            //Инициализируем массив случайными числами
            for (int i = 0; i < arr.Length; i++)
            {
                rndValue=rnd.Next(100);
                arr[i] = rndValue;
            }

            // Выводим на экран изначатьный:
            Console.WriteLine("Данно массив: ");
            for (int i = 0; i < arr.Length; i++)
			{
                Console.Write(arr[i]+"\t");
			}

            //Сортировка по возростанию
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; i < arr.Length-1-j; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            // Выводим на экран:
            Console.WriteLine("\n");
            Console.WriteLine("Получим массив: ");
            for (int i = 0; i < arr.Length; i++)
			{
                Console.Write(arr[i]+"\t");
			}
            Console.ReadKey();
        }
    }
}
