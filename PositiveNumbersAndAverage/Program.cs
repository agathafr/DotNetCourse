using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNumbersAndAverage
{
    class Program
    {
        static double[] numbers = new double[6];
        static int count = 0;
        static double total = 0;
        static void Main(string[] args)
        {
            ReceivesData();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter six integer or floating numbers and at least one positive: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.Clear();
        }

        static int CountsPositiveNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;
            }
            return count;
        }

        static double CalculatesAverageOfThePositiveNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    total += numbers[i];
            }

            return total / count;
        }

        static void DisplaysOutput()
        {
            Console.WriteLine(CountsPositiveNumbers() + " positive values.");
            Console.WriteLine(CalculatesAverageOfThePositiveNumbers());
        }
    }
}
