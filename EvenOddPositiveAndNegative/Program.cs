using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPositiveAndNegative
{
    class Program
    {
        static int[] numbers = new int[5];
        
        static void Main(string[] args)
        {
            ReceivesData();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter five values: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
        }

        static int CountsEvenValues()
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    count++;
            }

            return count;
        }

        static int CountsOddValues()
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) % 2 == 1)
                    count++;
            }

            return count;
        }

        static int CountsPositiveValues()
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;
            }

            return count;
        }

        static int CountsNegativeValues()
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    count++;
            }

            return count;
        }

        static void DisplaysOutput()
        {
            Console.WriteLine(CountsEvenValues() + " valor(es) par(es)");
            Console.WriteLine(CountsOddValues() + " valor(es) ímpar(es)");
            Console.WriteLine(CountsPositiveValues() + " valor(es) positivo(s)");
            Console.WriteLine(CountsNegativeValues() +  " valor(es) negativo(s)");
        }
    }
}
