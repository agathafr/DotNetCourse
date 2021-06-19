using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sum two numbers

             int result = Sum(1, 2);

             Console.WriteLine(result);*/

            int[] numbers = { 5, 12, 7, 18, 20, 68 };

            int total = Sum(numbers);

            Console.ReadLine();
        }
        private static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        /*private static int Sum(int valueOne, int valueTwo)
        {
            return valueOne + valueTwo;
        }*/
    }
}
