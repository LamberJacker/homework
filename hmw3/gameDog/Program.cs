using System;

namespace homework_all
{
    class GameDog
    {
        static void Main()
        {
            //Исходные даные
            bool flagCheck = false;
            char[] arr = {'@', '_', '_', '_', '_', '_', '_', '_', '_', '_'};
            Console.WriteLine("Мы играем в игру \"Собачка\". \nДоберись до конца что бы выиграть! \nТвой путь:" );
            for (int i = 0; i < arr.Length; i++)
			{
                Console.Write(arr[i]+" ");
			}
            
            do
            {
                Console.Write("\n\nP.S. Нажимай \"a\" или \"d\" что бы двигать собачку влево вправо соответсвенно" );
                turn = Convert.ToChar(Console.Read()); //ход игрока
                
                if (arr[9] == '@') 
                {
                        
                break; 
                }
                    
                    switch(turn)
                    {
                        case 'a':
                        for (int i = 0; i < arr.Length; i++)
		            	{

		            	}
                        break;
                        case 'd':

                        break;
                        default:
                        Console.WriteLine("Ты не правильно управляешь собакой нажимай \"a\" или \"d\"" );
                        break;
                    }
            }while(chek == true);
            Console.ReadKey();
        }
    }
}
