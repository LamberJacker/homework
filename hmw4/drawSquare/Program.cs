    
using System;

namespace homework_all
{
    class drawSquare
    {
        static void Main()
        {
            //Исходные даные
            Console.WriteLine("Введите на сколько рядков и столбцов отрисовать квадрат");
            Console.WriteLine("Введи количество рядков и столбцов (непарное натуральное число до 100): ");
            Console.WriteLine("Думаю такого квадрата тебе хватит");
            
            string userValue = Console.ReadLine();
            int rowcol = 0; //переменная количества строк и колоннок
            bool canConvert = Int32.TryParse(userValue, out rowcol); //проба конвертировать число
            
            if (canConvert == false) //Проверка значения числа на число с плавующей точкой и ввод букв
            {
                Console.WriteLine("Ты мне наврал и ввел плохое число!");
                Console.ReadKey();
            }
            else
            {
                bool check = true;
                    
                if (rowcol%2 == 0 || rowcol >= 100 || rowcol < 0) //Проверка значения числа на парность, не более 100, менее нуля
                {
                    check = false;
                    Console.WriteLine("Ты мне наврал и ввел плохое число!");
                    Console.ReadKey();
                    return;
                }

                char[][] arr = new char[rowcol][];
                
                //Логика:
                if (check == true)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        char[] temp = new char[rowcol];
                        for (int j = 0; j < temp.Length; j++)
                        {
                            if (i == 0 || j == 0 || i == arr.Length-1 || j == temp.Length-1) 
                            {
                                temp[j] = '*';
                            }
                            else if (i == arr.Length/2 & j == arr.Length/2)
                            {
                                temp[j] = '*';
                            }
                            else if (i == arr.Length/2-1 & j == arr.Length/2)
                            {
                                temp[j] = '*';
                            }
                            else if (i == arr.Length/2+1 & j == arr.Length/2)
                            {
                                temp[j] = '*';
                            }
                            else if (i == arr.Length/2 & j == arr.Length/2+1)
                            {
                                temp[j] = '*';
                            }
                            else if (i == arr.Length/2 & j == arr.Length/2-1)
                            {
                                temp[j] = '*';
                            }
                            else
                            {
                                temp[j] = ' ';
                            }
                        }
                        arr[i] = temp;
                    }
                }

                //Выводим на экран:
                if (check == true) 
                {
                    Console.WriteLine("\n");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr[i].Length; j++)
                        {
                            Console.Write(arr[i][j]);
                        }
                        Console.WriteLine();
                    }
                }
                else 
                {
                    Console.WriteLine("Ты мне наврал и ввел плохое число!");
                }
                Console.ReadKey();
            }
        }
    }
}
