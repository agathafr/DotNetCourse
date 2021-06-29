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
    }
}
