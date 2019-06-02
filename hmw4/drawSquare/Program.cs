using System;

namespace homework_all
{
    class drawSquare
    {
        static void Main()
        {
            //Исходные даные
            Console.WriteLine("Введите на сколько рядков и столбцов отрисовать квадрат");
            Console.WriteLine("Введи количество рядков и столбцов (непарное число) : ");
            int rowcol = Convert.ToInt32(Console.ReadLine());
            bool check = true;

            if (rowcol%2 == 0)
            {
                check = false;
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
                Console.WriteLine("Ты мне наврал и ввел неправильное число!");
            }
            Console.ReadKey();
        }
    }
}
