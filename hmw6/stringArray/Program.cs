using System;

namespace TaskFigure
{
    
	public class Circle
	{   
		public double Area(double radius)
		{
            double area = 3.14159265358979 * radius * radius;
            return area;
		}
		public double Perim(double radius)
		{
			double perimeter = 2 * 3.14159265358979 * radius;
            return perimeter;
		}
        public string Color()
        {
            string[] color = {"Yellow","Green","Blue","Brown","White","Red","Orange","Pink","Gray","Black"};
            Random rnd = new Random();
            int rndValue = rnd.Next(0, color.Length-1);
            string rndColor = color[rndValue];
            return rndColor;
        }
	}

    public class Square
	{   
		public double Area(double side)
		{
            double area = side * side;
            return area;
		}
		public double Perim(double side)
		{
			double perimeter = 4 * side;
            return perimeter;
		}
        public string Color()
        {
            string[] color = {"Yellow","Green","Blue","Brown","White","Red","Orange","Pink","Gray","Black"};
            Random rnd = new Random();
            int rndValue = rnd.Next(0, color.Length-1);
            string rndColor = color[rndValue];
            return rndColor;
        }
	}
    
    public class Triangle
    {   
	    public double AreaThreeSide(double side)
	    {
            double perimeter = (side + side + side)/2;
            double area = Math.Sqrt(perimeter * (perimeter - side) * (perimeter - side) * (perimeter - side));
            return area;
	    }
	    public double PerimThreeSide(double side)
	    {
		    double perimeter = side + side + side;
            return perimeter;
	    }
        public string Color()
        {
            string[] color = {"Yellow","Green","Blue","Brown","White","Red","Orange","Pink","Gray","Black"};
            Random rnd = new Random();
            int rndValue = rnd.Next(0, color.Length-1);
            string rndColor = color[rndValue];
            return rndColor;
        }
    }
    
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Даная програма считает характеристики фигур");
            Console.WriteLine("Введите цыфру фигуры для которой нужно определить характеристики периметра, площади и цвета.");
            Console.WriteLine("\"1\" - Круг;\n\"2\" - Квадрат;\n\"3\" - Треугольник\nВводи число :");

            bool checkAll = false; // проверка первго ввода пользователя

            do
            {
                string userInput = Console.ReadLine(); //выбор пользователя

                switch (userInput)
                {
                    case "1": // Круг
                        bool checkCircle = false; // проверка второго ввода пользователя
                        Console.WriteLine("Ты выбрал круг, введи радиус в миллиметрах :");
                        do
                        {
                            double userInputRadius = 0;
                            bool userInputRadiusTry = Double.TryParse(Console.ReadLine(), out userInputRadius);
                            if (userInputRadiusTry == false || userInputRadius <= 0)
                            {
                                Console.WriteLine("Ты ввел неправильное значение радиуса в мм, повтори...");
                            }
                            else
                            {
                                checkCircle = true;
                                checkAll = true;
                                Console.WriteLine("Радиус круга равен : {0} мм", userInputRadius);
                                Circle newCircle = new Circle();
                                Console.WriteLine("Периметр(длина) круга составляэт : {0:#.###} мм", newCircle.Perim(userInputRadius));
                                Console.WriteLine("Площадь круга равна : {0:#.###} кв.мм", newCircle.Area(userInputRadius));
                                Console.WriteLine("Цвет круга : {0}", newCircle.Color());
                            }

                        } while (checkCircle == false);
                        break;

                    case "2": // Квадрат
                        bool checkSquare = false; // проверка второго ввода пользователя
                        Console.WriteLine("Ты выбрал квадрат, введи сторону квадрата в миллиметрах :");
                        do
                        {
                            double userInputSide = 0;
                            bool userInputSideTry = Double.TryParse(Console.ReadLine(), out userInputSide);
                            if (userInputSideTry == false || userInputSide <= 0)
                            {
                                Console.WriteLine("Ты ввел неправильное значение стороны в мм, повтори...");
                            }
                            else
                            {
                                checkSquare = true;
                                checkAll = true;
                                Console.WriteLine("Сторона квадрата равна : {0} мм", userInputSide);
                                Square newSquare = new Square();
                                Console.WriteLine("Периметр квадрата равен : {0:#.###} мм", newSquare.Perim(userInputSide));
                                Console.WriteLine("Площадь квадрата равна : {0:#.###} кв.мм", newSquare.Area(userInputSide));
                                Console.WriteLine("Цвет квадрата : {0}", newSquare.Color());
                            }

                        } while (checkSquare == false);

                        break;

                    case "3": // Треугольник
                        bool checkTriangle = false; // проверка второго ввода пользователя
                        Console.WriteLine("Ты выбрал треугольник, введи сторону треугольника в миллиметрах :");
                        do
                        {
                            double userInputSide = 0;
                            bool userInputSideTry = Double.TryParse(Console.ReadLine(), out userInputSide);
                            if (userInputSideTry == false || userInputSide <= 0)
                            {
                                Console.WriteLine("Ты ввел неправильное значение стороны в мм, повтори...");
                            }
                            else
                            {
                                checkSquare = true;
                                checkAll = true;
                                Console.WriteLine("Сторона треугольника равна : {0} мм", userInputSide);
                                Triangle newTriangle = new Triangle();
                                Console.WriteLine("Периметр треугольнка равен : {0:#.###} мм", newTriangle.PerimThreeSide(userInputSide));
                                Console.WriteLine("Площадь треугольника равна : {0:#.###} кв.мм", newTriangle.AreaThreeSide(userInputSide));
                                Console.WriteLine("Цвет треугольника : {0}", newTriangle.Color());
                            }
                        } while (checkTriangle == false);
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
