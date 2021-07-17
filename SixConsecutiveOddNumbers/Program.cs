using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixConsecutiveOddNumbers
{
    class Program
    {
        static int number;
        static int[] numbers = new int[6];

        static void Main(string[] args)
        {
            ReceivesData();
            FindsSixConsecutiveOddNumbers();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter a positive integer value: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                number++;

            Console.Clear();
        }

        static void FindsSixConsecutiveOddNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = number;
                number += 2;
            }
        }

        static void DisplaysOutput()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
