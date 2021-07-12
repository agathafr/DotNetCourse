using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static string[] numbers;
        static double a, b, c;
        static double perimeter;
        static double area;
        static void Main(string[] args)
        {
            ReceivesData();
            ChecksIfItIsPossibleToMakeATriangle(a, b, c);
            perimeter = CalculatesPerimeterOfTriangle(a, b, c);
            area = CalculatesAreaOfTrapezium(a, b, c);
            DisplaysOutput(a, b, c);

            Console.ReadKey();
        }
        static void ReceivesData()
        {
            Console.WriteLine("Enter three point floating values: ");
            numbers = Console.ReadLine().Split(' ');

            a = Convert.ToDouble(numbers[0], CultureInfo.InvariantCulture);
            b = Convert.ToDouble(numbers[1], CultureInfo.InvariantCulture);
            c = Convert.ToDouble(numbers[2], CultureInfo.InvariantCulture);

            Console.Clear();
        }
        static bool ChecksIfItIsPossibleToMakeATriangle(double a, double b, double c)
        {
            if (a > Math.Abs(b - c) && a < (b + c) && b > Math.Abs(a - c) && b < a + c && c > Math.Abs(a - b) && c < a + b)
                return true;
            return false;
        }

        static double CalculatesPerimeterOfTriangle(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CalculatesAreaOfTrapezium(double a, double b, double c)
        {
            return (a + b) * c / 2;
        }

        static void DisplaysOutput(double a, double b, double c)
        {
            if (ChecksIfItIsPossibleToMakeATriangle(a, b, c) == true)
                Console.WriteLine("Area = " + perimeter.ToString("F1"));
            else
                Console.WriteLine("Perimetro = " + area.ToString("F1"));
        }
    }
}
