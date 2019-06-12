    
using System;

namespace TaskFigure
{
    
    public class Circle
    {   
        private double radius;
        private double area;
        private double perim;
        private string color;

        public bool SetChacteristicFigure(string rad) // безопасно установить значение радиуса и посчитать характеристики фигуры
        {
            bool userInputRadiusTry = Double.TryParse(rad, out radius);
            if (userInputRadiusTry & radius > 0) 
            {
                perim = 2 * 3.14159265358979 * radius;
                area = 3.14159265358979 * radius * radius;
                string[] arrColor = {"Yellow","Green","Blue","Brown","White","Red","Orange","Pink","Gray","Black"};
                Random rnd = new Random();
                int rndValue = rnd.Next(0, arrColor.Length-1);
                color = arrColor[rndValue];
                return true;
            }
            else return false;
        }
        public void ShowCharacteristic() // метод выводит на экран все даные о фигуре
        {
            Console.WriteLine("Радиус круга равен : {0} мм", radius);
            Console.WriteLine("Периметр(длина) круга составляэт : {0:#.###} мм", perim);
            Console.WriteLine("Площадь круга равна : {0:#.###} кв.мм", area);
            Console.WriteLine("Цвет круга : {0}", color);
        }
    }

    public class Square
    {   
        private double side;
        private double perim;
        private double area;
        private string color;
        
        public bool SetChacteristicFigure(string sideString) // безопасно установить значение стороны и посчитать характеристики фигуры
        {
            bool userInputSideTry = Double.TryParse(sideString, out side);
            if (userInputSideTry & side > 0) 
            {
                perim = 4 * side;
                area = side * side;
                string[] arrColor = {"Yellow","Green","Blue","Brown","White","Red","Orange","Pink","Gray","Black"};
                Random rnd = new Random();
                int rndValue = rnd.Next(0, arrColor.Length-1);
                color = arrColor[rndValue];
                return true;
            }
            else return false;
        }
        public void ShowCharacteristic() // метод выводит на экран все даные о фигуре
        {
            Console.WriteLine("Сторона квадрата равна : {0} мм", side);
            Console.WriteLine("Периметр квадрата равен : {0:#.###} мм", perim);
            Console.WriteLine("Площадь квадрата равна : {0:#.###} кв.мм", area);
            Console.WriteLine("Цвет квадрата : {0}", color);
        }
    }
    
    public class Triangle
    {   
        private double side1;
        private double side2;
        private double side3;
        private double perim;
        private double area;
        private string color;

        public bool SetChacteristicFigure(string sideA, string sideB, string sideC) // безопасно установить значение стороны и посчитать характеристики фигуры
        {
            bool Side1Try = Double.TryParse(sideA, out side1);
            bool Side2Try = Double.TryParse(sideB, out side2);
            bool Side3Try = Double.TryParse(sideC, out side3);
            if (Side1Try & Side2Try & Side3Try & side1 > 0 & side2 > 0 & side3 > 0) 
            {
                perim = (side1 + side2 + side3)/2;
            if (perim < side1 || perim < side2 || perim < side3) return false; // прверка на правильность геометрических даных треугольника
                area = Math.Sqrt(perim * (perim - side1) * (perim - side2) * (perim - side3));
                string[] arrColor = {"Yellow","Green","Blue","Brown","White","Red","Orange","Pink","Gray","Black"};
                Random rnd = new Random();
                int rndValue = rnd.Next(0, arrColor.Length-1);
                color = arrColor[rndValue];
                return true;
            }
            else return false;
        }
        public void ShowCharacteristic() // метод выводит на экран все даные о фигуре
        {
            Console.WriteLine("Стороны треугольника равны : {0}, {1}, {2} мм", side1, side2, side3);
            Console.WriteLine("Периметр треугольнка равен : {0:#.###} мм", perim);
            Console.WriteLine("Площадь треугольника равна : {0:#.###} кв.мм", area);
            Console.WriteLine("Цвет треугольника : {0}", color);
        }
    }
    
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Даная програма считает характеристики фигур");
            Console.WriteLine("Введите цыфру фигуры для которой нужно определить характеристики периметра, площади и цвета.");
            Console.WriteLine("\"1\" - Круг;\n\"2\" - Квадрат;\n\"3\" - Треугольник;\n\"0\" - Выход из программы.");

            bool checkAll = false; // проверка первго ввода пользователя
            do
            {
                Console.WriteLine("\nВводи число фигуры:");
                string userInput = Console.ReadLine(); //выбор пользователя
                switch (userInput)
                {
                    case "1": // Круг
                        bool checkCircle = false; // проверка второго ввода пользователя
                        Console.WriteLine("Ты выбрал круг, введи радиус в миллиметрах :");
                        Circle newCircle = new Circle();
                        do
                        {
                            bool cheker = newCircle.SetChacteristicFigure(Console.ReadLine());
                            if (cheker == false)
                            {
                                Console.WriteLine("Ты ввел неправильное значение радиуса в мм, повтори...");
                            }
                            else
                            {
                                checkCircle = true;
                                newCircle.ShowCharacteristic();
                            }
                        } while (checkCircle == false);
                        break;

                    case "2": // Квадрат
                        bool checkSquare = false; // проверка второго ввода пользователя
                        Console.WriteLine("Ты выбрал квадрат, введи сторону квадрата в миллиметрах :");
                        Square newSquare = new Square();
                        do
                        {
                            bool cheker = newSquare.SetChacteristicFigure(Console.ReadLine());
                            if (cheker == false)
                            {
                                Console.WriteLine("Ты ввел неправильное значение стороны в мм, повтори...");
                            }
                            else
                            {
                                checkSquare = true;
                                newSquare.ShowCharacteristic();
                            }
                        } while (checkSquare == false);
                        break;

                    case "3": // Треугольник
                        bool checkTriangle = false; // проверка второго ввода пользователя
                        Console.WriteLine("Ты выбрал треугольник, введи три стороны");
                        Triangle newTriangle = new Triangle();
                        do
                        {
                            Console.WriteLine("Сторона А :");
                            string side1 = Console.ReadLine();
                            Console.WriteLine("Сторона B :");
                            string side2 = Console.ReadLine();
                            Console.WriteLine("Сторона C :");
                            string side3 = Console.ReadLine();
                            bool cheker = newTriangle.SetChacteristicFigure(side1, side2, side3);
                            if (cheker == false)
                            {
                                Console.WriteLine("Ты ввел неправильное значение стороны в мм, повтори...");
                            }
                            else
                            {
                                checkTriangle = true;
                                newTriangle.ShowCharacteristic();
                            }
                        } while (checkTriangle == false);
                        break;
                    case "0":
                        Console.WriteLine("пока, надеюсь ты получил ответ");
                        checkAll = true;
                        break;
                    default:
                        Console.WriteLine("Ты сделал неправильний выбор, повтори...");
                        break;
                }
            } while (checkAll == false);
            Console.ReadKey();
        }
    }
}
