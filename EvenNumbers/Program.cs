using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static int[] numbers = new int[5];
        static int count = 0;
        static void Main(string[] args)
        {
            ReceivesData();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter five even numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static int Counts()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    count++;
            }
            return count;
        }

        static void DisplaysOutput()
        {
            Console.WriteLine(Counts() + " even values.");
        }
    }
}
