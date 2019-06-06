using System;

namespace VladyslavMartynovskyi
{
    class YanukovichName
    {
        static void Main()
        {
            Random rnd = new Random(); // ссылка на метод рандом
            int words = rnd.Next(5, 10); // рандомное значения количества слов в массиве 
            int letters = rnd.Next(3, 8); // количество букв
        	string[] arrString = new string[words]; // создаем массив
            byte counterLetter = 0; // счетчик для согласных букв
        	string consonants = "bcdfghjklmnpqrstvwxyz"; // перечисление согласных
            
            // Инициализируем массив слов:
            for (int i = 0; i < words; i++)
			{   
                for (int j = 0; j < letters; j++)
			    {
                    char someChar = (char) rnd.Next(97, 122);
                    for (int k = 0; k < 21; k++)
			        {
                        if (someChar == consonants[k]) counterLetter++;
			        }
                    arrString[i] += someChar.ToString();
			    }
			}

            // Вывод на экран:
            for (int i = 0; i < words; i++)
            {
                Console.Write(arrString[i]+" ");
            }
            Console.WriteLine("\nВ данном предложении количество согласных букв равно : " + counterLetter + " шт.");
            Console.ReadKey();      
        }
    }
}
