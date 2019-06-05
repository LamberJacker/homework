using System;

namespace homework_all
{
    class GameDogHard
    {
        static void Main()
        {
            //Дано:
            char[][] arr = new char[10][];
            // Заполним массив
            Random rnd = new Random();
            byte rndBomb = 0;
            byte rndMedic = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                char[] arrtemp = new char[10];
                do 
                    {
                        rndBomb = (byte) rnd.Next(1, arrtemp.Length-2); //место для бомбочки
                        rndMedic = (byte) rnd.Next(1, arrtemp.Length-2); //место для аптечки
                    }while(rndBomb == rndMedic);
                for (int j = 0; j < arrtemp.Length; j++ )
			    {
                    if (i == 0 & j == 0)
                    {
                        arrtemp[j] = '@';
                        continue;
                    }
                    if (j == rndBomb) //записуем бомбочку
                    {
                        arrtemp[j] = '*';
                        continue;
                    }
                    if (j == rndMedic) //записуем аптечку
                    {
                        arrtemp[j] = '+';
                        continue;
                    }
                    arrtemp[j] = '_';
			    }
                arr[i] = arrtemp;
            }

            // Правила игры:
            Console.WriteLine("Мы играем в игру \"Собачка\"");
            Console.WriteLine("Нажимай \"a\",\"w\",\"s\",\"d\" что бы двигать собачку");
            Console.WriteLine("Доберись до нижнего правого угла что бы выиграть!\nОкуратно на пути будут трудности." );
            // Нужные поля:
            bool flag = false; //конец программы
            int hp = 100; //здоровье собаки
            sbyte dmg = -5; //урон от хода
            sbyte positionX = 0; // позиция по Х
            sbyte positionY = 0; // позиция по У
            char temp = ' '; //для записи значения когда произошел взрыв или лечение

            //Логика программы:
            do
            {
                Console.WriteLine("\nДелай ход! Твое здоровье равно {0} из 100. Ты на ячейке [{1},{2}]", hp, positionY+1, positionX+1);
                // Отрисовуем массив (трассу):
                        for (int i = 0; i < arr.Length; i++)
                        {
                            for (int j = 0; j < arr.Length; j++ )
			                {
                                if (arr[i][j] == '*' || arr[i][j] == '+') //Cкрываем бомбочки от пользователя
                                {
                                    Console.Write("_ ");
                                    continue;
                                }
                                Console.Write(arr[i][j]+" ");
			                }
                            Console.WriteLine("\n");
                        }
                string turn = Console.ReadLine(); //ход человека
                switch(turn)
                {
                case "a": //ход влево
                        positionX--;
                        hp+=dmg; //урон от хода
                        if (hp <= 0) //проверка здоровья
                        {
                            Console.WriteLine("Ты проиграл!");
                            flag = true;
                            break;
                        }
                        if (positionY == 9 & positionX == 9) //Условие победы
                        {
                            Console.WriteLine("Ты победил и добрался к выходу!");
                            flag = true;
                            break;
                        }
                        if (positionX < 0) //ослеживаем позицию в массиве
                        {
                            positionX = 9;
                            //Перекидуем значение:
                            temp = arr[positionY][positionX];
                            arr[positionY][positionX] = arr[positionY][0];
                            arr[positionY][0] = temp;
                        }
                        else
                        {
                            if (arr[positionY][positionX] == '*') //проверка на наличие бомбочки
                            {
                                hp-=35;
                                Console.WriteLine("\nТы попал на бобму отхвати -40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (arr[positionY][positionX] == '+') //проверка на наличие аптечки
                            {
                                hp+=35;
                                Console.WriteLine("\nТы попал на хилку получи +40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (positionY == 9 & positionX == 9) //Условие победы
                            {
                                Console.WriteLine("Ты победил и добрался к выходу!");
                                flag = true;
                                break;
                            }
                            //Перекидуем значение:
                            temp = arr[positionY][positionX];
                            arr[positionY][positionX] = arr[positionY][positionX+1];
                            arr[positionY][positionX+1] = temp;
                        }
                        break;
                case "d": //ход вправо
                        positionX++;
                        hp+=dmg; //урон от хода
                        if (hp <= 0) //проверка здоровья
                        {
                            Console.WriteLine("Ты проиграл!");
                            flag = true;
                            break;
                        }
                        if (positionY == 9 & positionX == 9) //Условие победы
                        {
                            Console.WriteLine("Ты победил и добрался к выходу!");
                            flag = true;
                            break;
                        }
                        if (positionX > 9) //ослеживаем позицию в массиве
                        {
                            positionX = 0;
                            //Перекидуем значение:
                            temp = arr[positionY][positionX];
                            arr[positionY][positionX] = arr[positionY][9];
                            arr[positionY][9] = temp;
                        }
                        else
                        {
                            if (arr[positionY][positionX] == '*') //проверка на наличие бомбочки
                            {
                                hp-=35;
                                Console.WriteLine("\nТы попал на бобму отхвати -40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (arr[positionY][positionX] == '+') //проверка на наличие аптечки
                            {
                                hp+=35;
                                Console.WriteLine("\nТы попал на хилку получи +40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (positionY == 9 & positionX == 9) //Условие победы
                            {
                                Console.WriteLine("Ты победил и добрался к выходу!");
                                flag = true;
                                break;
                            }
                            //Перекидуем значение:
                            temp = arr[positionY][positionX-1];
                            arr[positionY][positionX-1] = arr[positionY][positionX];
                            arr[positionY][positionX] = temp;
                        }
                        break;
                case "w": //ход вверх
                        positionY--;
                        hp+=dmg; //урон от хода
                        if (hp <= 0) //проверка здоровья
                        {
                            Console.WriteLine("Ты проиграл!");
                            flag = true;
                            break;
                        }
                        if (positionY == 9 & positionX == 9) //Условие победы
                        {
                            Console.WriteLine("Ты победил и добрался к выходу!");
                            flag = true;
                            break;
                        }
                        if (positionY < 0) //ослеживаем позицию в массиве
                        {
                            positionY = 9;
                            //Перекидуем значение:
                            temp = arr[positionY][positionX];
                            arr[positionY][positionX] = arr[0][positionX];
                            arr[0][positionX] = temp;
                        }
                        else
                        {
                            if (arr[positionY][positionX] == '*') //проверка на наличие бомбочки
                            {
                                hp-=35;
                                Console.WriteLine("\nТы попал на бобму отхвати -40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (arr[positionY][positionX] == '+') //проверка на наличие аптечки
                            {
                                hp+=35;
                                Console.WriteLine("\nТы попал на хилку получи +40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (positionY == 9 & positionX == 9) //Условие победы
                            {
                                Console.WriteLine("Ты победил и добрался к выходу!");
                                flag = true;
                                break;
                            }
                            //Перекидуем значение:
                            temp = arr[positionY][positionX];
                            arr[positionY][positionX] = arr[positionY+1][positionX];
                            arr[positionY+1][positionX] = temp;
                        }
                        break;
                case "s": //ход вниз
                        positionY++;
                        hp+=dmg; //урон от хода
                        if (hp <= 0) //проверка здоровья
                        {
                            Console.WriteLine("Ты проиграл!");
                            flag = true;
                            break;
                        }
                        if (positionY == 9 & positionX == 9) //Условие победы
                        {
                            Console.WriteLine("Ты победил и добрался к выходу!");
                            flag = true;
                            break;
                        }
                        if (positionY > 9) //ослеживаем позицию в массиве
                        {
                            positionY = 0;
                            //Перекидуем значение:
                            temp = arr[positionY][positionX];
                            arr[positionY][positionX] = arr[9][positionX];
                            arr[9][positionX] = temp;
                        }
                        else
                        {
                            if (arr[positionY][positionX] == '*') //проверка на наличие бомбочки
                            {
                                hp-=35;
                                Console.WriteLine("\nТы попал на бобму отхвати -40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            if (arr[positionY][positionX] == '+') //проверка на наличие аптечки
                            {
                                hp+=35;
                                Console.WriteLine("\nТы попал на хилку получи +40HP!");
                                arr[positionY][positionX] = '_';
                            }
                            //Перекидуем значение:
                            temp = arr[positionY-1][positionX];
                            arr[positionY-1][positionX] = arr[positionY][positionX];
                            arr[positionY][positionX] = temp;
                        }
                        break;
                default:
                        Console.WriteLine("Ты ввел не правильний ход, повтори");
                        break;
                }   
            }while(flag != true);
            Console.ReadKey();
        }
    }
}