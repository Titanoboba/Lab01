using System;
using System.IO.Pipes;

namespace Lab01 {

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
            string[]? input = Console.ReadLine().Split();
            sides[0] = Convert.ToDouble(input[0]);
            sides[1] = Convert.ToDouble(input[1]);
            Console.WriteLine($"SideA = {sides[0]}, SideB = {sides[1]}");
            Rectangle rect = new Rectangle(sides[0], sides[1]);
            Console.WriteLine($"Area = {rect.Area}, Perimeter = {rect.Perimeter}");
        }
    }
}