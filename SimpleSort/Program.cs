using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort
{
    class Program
    {
        static string[] input = new string[3];
        static int[] numbers = new int[3];
        static int aux = 0;

        static void Main(string[] args)
        {
            ReceivesData();
            DisplaysOutput();
            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter three integers: ");
            input = Console.ReadLine().Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
            }

            Console.Clear();
        }

        static void SortsInAscendingOrder()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
            }
        }

        static void DisplaysOutput()
        {
            SortsInAscendingOrder();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

    }
}
