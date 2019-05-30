using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            for (int i = 0; i < 10; i++) //Инициализируем массивы значениями "-1"
            {
                a[i] = b[i] = c[i] = -1;
            }

            bool flagByte = false; //флаг для заполнения массива типа byte
            bool flagShort = false; //флаг для заполнения массива типа short
            bool flagInt = false; //флаг для заполнения массива типа int

            Random rnd = new Random(0, 9223372036854775807); //Создадим экземпляр класса Random
            int rndValue = 0; //число которое рандомно генерируеться

            int i = 0; //счетчик для цыкла byte
            int j = 0; //счетчик для цыкла short
            int k = 0; //счетчик для цыкла Int

            while(flagByte == false & flagShort== false & flagInt == false)
            {
                rndValue=rnd.Next();
                Console.WriteLine("Проверка самого себя рандомное число = "+ rndValue);
                switch(rndValuse)
                {
                case int check when (rndValue<128):
                        {
                        if(rndValue == arrByte[10])
                        {
                        flagByte == true;
                        goto case 2; 
                        }                       
                        arrByte[i]=rndValue;
                        i++;
                        }
                case int check when (rndValue<32768):
                        {
                        if(rndValue == arrShort[10])
                        {
                        flagShort == true;
                        goto case 3; 
                        }                     
                        arrShort[j]=rndValue;
                        j++;
                        }
                default:
                        {
                        if(rndValue == arrShort[10]);                       
                        arrInt[k]=rndValue;
                        k++;
                        }


                }
            }
        }
    }
}
