using System;

namespace VladyslavMartynovskyi
{
    class YanukovichName
    {
        static void Main()
        {
        	string[] arrString = {"Ivan 20 Kiev","Leha 23 Harkiv","Vika 23 Kiev"}; // создаем массив
            Console.WriteLine("Ты зашел в базу данных троих студентов в ней записано имя, возраст, город");
            Console.WriteLine("Введи нужный параметр (имя, возраст, город) для вывода на экран нужного студента");
            
            string userInput = Console.ReadLine();
            
            while (userInput.Contains("  ")) //убираем лишние пробелы между словами
           	{ 
           		userInput = userInput.Replace("  ", " ");
           	}
            string[] userInputArray =  userInput.Trim().Split(' '); // создаем массив даних от пользователя
            
            string[] arrStud1 = arrString[0].Trim().Split(' ');
            string[] arrStud2 = arrString[1].Trim().Split(' ');
            string[] arrStud3 = arrString[2].Trim().Split(' ');
                
            bool flag1 = false, flag2 = false, flag3 = false; //флаги совпадения
            
            for (int j = 0; j < userInputArray.Length ; j++)
            {
                for (int i = 0; i < arrStud1.Length; i++ )
                {
                    if (userInputArray[j] == arrStud1[i]) flag1 = true;
                    if (userInputArray[j] == arrStud2[i]) flag2 = true;
                    if (userInputArray[j] == arrStud3[i]) flag3 = true;  
                }
                
                if (flag1 == true || flag2 == true || flag3 == true)
                {
                    if (flag1 == true)
                    {
                        Console.WriteLine("\nСовпадение есть у первого студента :");
                        for (int i = 0; i < arrStud1.Length; i++ )
                        {
                            Console.Write(arrStud1[i] + " ");
                        }
                    }
                
                    if (flag2 == true)
                    {
                        Console.WriteLine("\nСовпадение есть у второго студента :");
                        for (int i = 0; i < arrStud2.Length; i++ )
                        {
                            Console.Write(arrStud2[i] + " ");
                        }
                    }

                    if (flag3 == true)
                    {
                        Console.WriteLine("\nСовпадение есть у третего студента :");
                        for (int i = 0; i < arrStud3.Length; i++ )
                        {
                            Console.Write(arrStud3[i] + " ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Совпадений не найденно, таких студентов нет");
                }
            }
        Console.ReadKey();      
        }
    }
}
