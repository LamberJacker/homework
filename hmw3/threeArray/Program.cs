using System;

namespace homework_all
{
    class Task1_ThreeArray
    {
        static void Main()
        {
            //Исходные даные
            byte[] arrByte = new byte [10];
            short[] arrShort = new short [10];
            int[] arrInt = new int [10];

            bool flagByte = false; //флаг для заполнения массива типа byte
            bool flagShort = false; //флаг для заполнения массива типа short
            bool flagInt = false; //флаг для заполнения массива типа int

            Random rnd = new Random(); //Создадим экземпляр класса Random
            int rndValue = 0; //число которое рандомно генерируеться

            int i = 0; //счетчик для цыкла byte
            int j = 0; //счетчик для цыкла short
            int k = 0; //счетчик для цыкла Int

            while(flagByte == false | flagShort == false | flagInt == false)
            {
                rndValue=rnd.Next(100000000000);
                Console.WriteLine("Проверка самого себя рандомное число = "+ rndValue);
                
                if (rndValue <= 255 & i < 10)
                {
                arrByte[i] = (byte) rndValue;
                i++;
                if (i == 10) flagByte = true;
                }
                else if (rndValue <= 32767 & j < 10)
                {
                arrShort[j] = (short) rndValue;
                j++;
                if (j == 10) flagShort = true;
                } else if (rndValue <= 2147483647 & k < 10)
                {
                arrInt[k] = rndValue;
                k++;
                if (k == 10) flagInt = true;
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
            Console.ReadKey();
        }
    }
}
