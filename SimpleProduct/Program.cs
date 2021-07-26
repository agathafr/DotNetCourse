using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProduct
{
    class Program
    {
        static int numberOne;
        static int numberTwo;
        static int prod;
        static void Main(string[] args)
        {
            ReceivesData();
            ReturnsTheProduct();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter an integer: ");
            numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another integer: ");
            numberTwo = int.Parse(Console.ReadLine());

            Console.Clear();
        }

        static int ReturnsTheProduct()
        {
            prod = numberOne * numberTwo;
            return prod;
        }

        static void DisplaysOutput()
        {
            Console.WriteLine("PROD = " + prod);
        }
    }
}
