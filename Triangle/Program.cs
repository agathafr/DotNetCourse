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
        static double perimeterTriangle;
        static double areaTrapezium;
        static void Main(string[] args)
        {
            ReceivesData();
            ChecksIfItIsPossibleToMakeATriangle();
            areaTrapezium = CalculatesAreaOfTrapezium();
            perimeterTriangle = CalculatesPerimeterOfTriangle();
            DisplaysOutput();

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

        static bool ChecksIfItIsPossibleToMakeATriangle()
        {   // um dos lados maior que o módulo da diferença dos outros 2 lados e tb menor que a soma desses lados
            if (a > Math.Abs(b - c) && a < (b + c) && b > Math.Abs(a - c) && b < a + c && c > Math.Abs(a - b) && c < a + b)
                return true;
            return false;
        }

        static double CalculatesPerimeterOfTriangle()
        {
            return a + b + c;
        }

        static double CalculatesAreaOfTrapezium()
        {
            return (a + b) * c / 2;
        }

        static void DisplaysOutput()
        {
            if (ChecksIfItIsPossibleToMakeATriangle() == false)
                Console.WriteLine("Area = " + areaTrapezium.ToString("F1"));
            else
                Console.WriteLine("Perimetro = " + perimeterTriangle.ToString("F1"));

        }
    }
}
