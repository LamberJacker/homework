using System;

namespace homework_all
{
    class ThreeArray
    {
        static void Main()
        { 
            //Исходные даные
            byte[] arrByte = new byte [10];
            short[] arrShort = new short [10];
            int[] arrInt = new int [10];

            Random rnd = new Random(); //Создадим экземпляр класса Random
            int rndValue = 0; //число которое рандомно генерируеться

            int i = 0; //счетчик для цыкла byte
            int j = 0; //счетчик для цыкла short
            int k = 0; //счетчик для цыкла Int
            int counter = 0; //счетчик для цыкла Int

            while(i < 10 || j < 10 || k < 10)
            {
                rndValue=rnd.Next(); //поставил условие максимального числа для быстрой проверки (чтобы быстро забить массивы)
                //Console.WriteLine("Проверка самого себя рандомное число = "+ rndValue);
                counter++;
                if (rndValue <= byte.MaxValue && i < 10)
                {
                    arrByte[i++] = (byte) rndValue;
                }
                    else if (rndValue <= short.MaxValue && j < 10)
                    {
                        arrShort[j++] = (short) rndValue;
                    }   
                        else if (k < 10)
                        {
                        arrInt[k++] = rndValue;
                        }
            }

            // Выводим на экран:
            Console.WriteLine(" ");
            for (int m = 0; m < 10; m++)
			{
                Console.WriteLine("Byte ["+ m + "]" + " = " + arrByte[m]);
			}
            Console.WriteLine(" ");
            for (int m = 0; m < 10; m++)
			{
                Console.WriteLine("Short ["+ m + "]" + " = " + arrShort[m]);
			}
            Console.WriteLine(" ");
            for (int m = 0; m < 10; m++)
			{
                Console.WriteLine("Int ["+ m + "]" + " = " + arrInt[m]);
            }
            Console.WriteLine("\ncounter = "+counter);
            Console.ReadKey();
        }
    }
}
