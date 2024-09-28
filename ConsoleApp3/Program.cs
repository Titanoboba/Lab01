using System;
using System.IO.Pipes;

namespace Lab01 {

    public class Point
    {
        private double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double getX
        { 
            get { return (this.x); } 
        }
        public double getY
        { 
            get { return (this.y); } 
        }
    }
    public class Figure
    {
        private Point[] points;
        private string? name;

        private double LengthSide(Point A, Point B)
        {
            double result = Convert.ToDouble(Math.Sqrt(Convert.ToDouble(Math.Pow(B.getX - A.getX, 2)) + Convert.ToDouble(Math.Pow(B.getY - A.getY, 2))));
            return (result);
        }

        public Figure(Point[] _points)
        {
            points = _points;
        }

        public string Name
        {
            get { return name!; }
            set { name = value; }
        }    

        public double PerimeterCalculator()
        {
            double result;
            if (points.Length == 3)
            {
                result = this.LengthSide(points[0], points[1]) + this.LengthSide(points[1], points[2]) + this.LengthSide(points[2], points[0]);
                return (result);
            }
            if (points.Length == 4)
            {
                result = this.LengthSide(points[0], points[1]) + this.LengthSide(points[1], points[2]) + this.LengthSide(points[2], points[3]) + this.LengthSide(points[3], points[0]);
                return (result);
            }
            result = this.LengthSide(points[0], points[1]) + this.LengthSide(points[1], points[2]) + this.LengthSide(points[2], points[3]) + this.LengthSide(points[3], points[4]) + this.LengthSide(points[4], points[0]);
            return (result);
        }
    }

    public class Rectangle
    {
        private double sideA, sideB;

        private double CalculateArea()
        {
            return sideA * sideB;
        }

        private double CalculatePerimeter()
        {
            return 2 * (sideA + sideB);
        }

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double Area
        {
            get { return (this.CalculateArea()); }   
        }

        public double Perimeter
        {
            get { return (this.CalculatePerimeter()); }
        }

    }
    internal class Program {
        static void Main(string[] args)
        {
            // Целочисленные типы данных
            Console.WriteLine($"byte: min = {byte.MinValue}, max = {byte.MaxValue}");
            Console.WriteLine($"sbyte: min = {sbyte.MinValue}, max = {sbyte.MaxValue}");
            Console.WriteLine($"short: min = {short.MinValue}, max = {short.MaxValue}");
            Console.WriteLine($"ushort: min = {ushort.MinValue}, max = {ushort.MaxValue}");
            Console.WriteLine($"int: min = {int.MinValue}, max = {int.MaxValue}");
            Console.WriteLine($"uint: min = {uint.MinValue}, max = {uint.MaxValue}");
            Console.WriteLine($"long: min = {long.MinValue}, max = {long.MaxValue}");
            Console.WriteLine($"ulong: min = {ulong.MinValue}, max = {ulong.MaxValue}");

            // Типы данных с плавающей точкой
            Console.WriteLine($"float: min = {float.MinValue}, max = {float.MaxValue}");
            Console.WriteLine($"double: min = {double.MinValue}, max = {double.MaxValue}");
            Console.WriteLine($"decimal: min = {decimal.MinValue}, max = {decimal.MaxValue}");

            // Логический тип данных
            Console.WriteLine($"bool: true / false");

            // Символьный тип данных
            Console.WriteLine($"char: min = {char.MinValue}, max = {char.MaxValue}");

            // Структуры
            Console.WriteLine($"DateTime: min = {DateTime.MinValue}, max = {DateTime.MaxValue}");
            Console.WriteLine($"TimeSpan: min = {TimeSpan.MinValue}, max = {TimeSpan.MaxValue}");

            // Тип значений null
            Console.WriteLine($"Nullable<T>: null");

            Console.WriteLine("Input rectangle sides:");
            double[] sides = new double[2];
            string[]? input = Console.ReadLine()!.Split();
            sides[0] = Convert.ToDouble(input[0]);
            sides[1] = Convert.ToDouble(input[1]);
            Console.WriteLine($"SideA = {sides[0]}, SideB = {sides[1]}");
            Rectangle rect = new Rectangle(sides[0], sides[1]);
            Console.WriteLine($"Area = {rect.Area}, Perimeter = {rect.Perimeter}");
            Console.WriteLine("Input figure name, amount of points (ex. \"Square 4\"):");
            string[] figure_input = Console.ReadLine()!.Split();
            Point[] points = new Point[Convert.ToInt32(figure_input[1])];
            for (int i = 0; i <  points.Length; i++)
            {
                Console.WriteLine($"Input coordinates of point number {i + 1} (ex. X Y \"6 5\"):");
                string[] cord = new string[2];
                cord = Console.ReadLine()!.Split();
                points[i] = new Point(Convert.ToDouble(cord[0]), Convert.ToDouble(cord[1]));
            }
            Figure figure = new Figure(points);
            figure.Name = figure_input[0];
            Console.WriteLine($"Figure Name = {figure.Name}, Figure Perimeter = {figure.PerimeterCalculator()}");
        }
    }
}