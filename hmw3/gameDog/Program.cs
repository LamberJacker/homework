using System;

namespace homework_all
{
    class GameDog
    {
        static void Main()
        {
            //Исходные даные:
            bool flag = false;
            int hp = 100;
            sbyte dmg = -5;
            sbyte position = 0;
            char temp = ' ';
            int counter = 0;
            //Дано:
            char[] arr = {'@', '_', '_', '_', '_', '_', '_', '_', '_', '_'};
            // Правила игры:
            Console.WriteLine("Мы играем в игру \"Собачка\"");
            Console.WriteLine("Нажимай \"a\" или \"d\" что бы двигать собачку влево или вправо соответсвенно");
            Console.WriteLine("Выйдешь за карту - Ты проиграл!");
            Console.WriteLine("Доберись до конца что бы выиграть! \nТвой путь:" );
            // Отрисовуем массив (трассу):
            for (int i = 0; i < arr.Length; i++)
			{
                Console.Write(arr[i]+" ");
			}
            //Спаун бомбы и медицыны:
            Random rnd = new Random();
            byte rndBomb = 0;
            byte rndMedic = 0;
            do
            {
                rndBomb = (byte) rnd.Next(1, arr.Length-2);
                rndMedic = (byte) rnd.Next(1, arr.Length-2);
            }while(rndBomb == rndMedic);
            arr[rndBomb] = '*';
            arr[rndMedic] = '+';
            
            // Отрисовуем массив (проверка):
            Console.WriteLine("\nПолученный массив для проверки :");
            for (int i = 0; i < arr.Length; i++)
			{
                Console.Write(arr[i]+" ");
			}
            
            //Логика программы:
            do
            {
                Console.WriteLine("\nДелай ход твое здоровье равно {0} из 100. Ты на {1} ячейке", hp, position+1);
                string turn = Console.ReadLine(); //user turn
                switch(turn)
                {
                case "a":
                        position--;
                        hp+=dmg; //урон от хода
                        if (hp <= 0 || position < 0) //проверка здоровья
                        {
                            Console.WriteLine("Ты проиграл!");
                            flag = true;
                            break;
                        }
                        //Перекидуем значение
                        temp = arr[counter];
                        arr[counter] = arr[counter-1];
                        arr[counter-1] = temp;
                        counter--;
                        
                        // Отрисовуем массив БЕЗ бомбачек и аптечек:
                        Console.WriteLine("\nВот твоя позиция :");
                        for (int i = 0; i < arr.Length; i++)
			            {
                            if (arr[i] == '+' || arr[i] == '*')
                            {
                                Console.Write("_ ");
                                continue;
                            }
                            Console.Write(arr[i]+" ");
			            }
                        break;
                case "d":
                        position++;
                        hp+=dmg; //урон от хода
                        if (hp <= 0) //проверка здоровья
                        {
                            Console.WriteLine("Ты проиграл");
                            flag = true;
                            break;
                        }
                        if (position == 9) //проверка здоровья
                        {
                            Console.WriteLine("Ты пооообедил!!!");
                            flag = true;
                            break;
                        }
                        if(arr[counter+1] == '*')
                        {
                            Console.WriteLine("\nТы подорвался отхвати -40HP");
                            hp = hp-35;
                            arr[counter+1] = '_';
                        }
                        if(arr[counter+1] == '+')
                        {
                            Console.WriteLine("\nТы подобрал аптечку получи +40HP");
                            hp = hp+45;
                            arr[counter+1] = '_';
                        }
                        //Перекидуем значение:
                        temp = arr[counter];
                        arr[counter] = arr[counter+1];
                        arr[counter+1] = temp;
                        counter++;
                        
                        // Отрисовуем массив БЕЗ бомбачек и аптечек:
                        Console.WriteLine("\nВот твоя позиция :");
                        for (int i = 0; i < arr.Length; i++)
			            {
                            if (arr[i] == '+' || arr[i] == '*')
                            {
                                Console.Write("_ ");
                                continue;
                            }
                            Console.Write(arr[i]+" ");
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
