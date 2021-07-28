using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskarasFormula
{
    class Program
    {
        static double a, b, c;
        static void Main(string[] args)
        {
            ReceivesData();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter a value for a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for c: ");
            c = double.Parse(Console.ReadLine());

            Console.Clear();
        }

        static double CalculatesTheValueOfDelta()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static double CalculatesThePositiveRoot()
        {
            return (-((b)) + Math.Sqrt(CalculatesTheValueOfDelta())) / (2 * a);
        }

        static double CalculatesTheNegativeRoot()
        {
            return (-((b)) - Math.Sqrt(CalculatesTheValueOfDelta())) / (2 * a);
        }

        static void DisplaysOutput()
        {
            if (a != 0 && CalculatesTheValueOfDelta() > 0)
            {
                Console.WriteLine("R1 = " + CalculatesThePositiveRoot().ToString("N5"));
                Console.WriteLine("R2 = " + CalculatesTheNegativeRoot().ToString("N5"));
            }
            else
            {
                Console.WriteLine("Impossible to calculate!");
            }
        }
    }
}
