using System;

namespace VladyslavMartynovskyi
{
    class YanukovichName
    {
        static void Main()
        {
        	string userImput;
        	bool flag0, flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8, flag9, flag10, flag11, flag12, flag13, flag14, flag15;
            do
            {
            	Console.WriteLine("Please, write your full name in one row, only like <lastname> <name> <patronymic>:");
	            
	            userImput = Console.ReadLine(); // cчитуем строку пользователя
	            
	            // снижаем ризк неправильного ввода
	            flag0 = userImput.Contains("0");
	            flag1 = userImput.Contains("1");
	            flag2 = userImput.Contains("2");
	            flag3 = userImput.Contains("3");
	            flag4 = userImput.Contains("4");
	            flag5 = userImput.Contains("5");
	            flag6 = userImput.Contains("6");
	            flag7 = userImput.Contains("7");
	            flag8 = userImput.Contains("8");
	            flag9 = userImput.Contains("9");
	            flag10 = userImput.Contains("@");
	            flag11 = userImput.Contains(".");
	            flag12 = userImput.Contains(",");
	            flag13 = userImput.Contains("-");
	            flag14 = userImput.Contains("!");
	            flag15 = userImput.Contains("/");

	        } while (flag0 || flag1 || flag2 || flag3 || flag4 || flag5 || flag6 || flag7 || flag8 || flag9 || flag10 || flag11 || flag12 || flag13 || flag14 || flag15);

           	while (userImput.Contains("  ")) //убираем лишние пробелы
           	{ 
           		userImput = userImput.Replace("  ", " ");
           	}

           	string[] wordsSplit = userImput.Trim().Split(' ');//разбиваем массив по пробелам
           	
           	// Логика программы:
            for (int i = 0; i < wordsSplit.Length; i++)
            {
            	string tempWord = ""; // дополнительная переменая для записи слова из чаров
            	for(int j = 0; j < wordsSplit[i].Length; j++)
        		{
        			if (j == 0)
        			{	
        				string firstLetter = ""; // string переменая для записи большой первой буквы
        				firstLetter = wordsSplit[i][j].ToString().ToUpper();
        				tempWord += firstLetter;
        			}
        			else
        			{	
        				tempWord += wordsSplit[i][j];
        			}
    			}
  				
  				if(i == 0) 
  				{	
					wordsSplit[i] = tempWord; //записуем первое слово полностью
  				}
  				else 
  				{	
  					wordsSplit[i] = wordsSplit[i].Substring(0,1).ToUpper() + "."; //записуем первую букву в большом регистре
  				}
  						
            }

            // Выводим данные
			for (int i = 0; i < wordsSplit.Length; i++)
			{	
				Console.Write(wordsSplit[i]+" ");
			}
			
            Console.ReadKey();      
        }
    }
}
