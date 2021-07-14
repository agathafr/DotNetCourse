using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAccumulator
{
    class Program
    {
        static int[] numbers = { 45, 78, 56, 23, 41, 64, 57 };
        static void Main(string[] args)
        {
            Sum(numbers);
            Output(numbers);

            Console.ReadKey();
        }
        static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        static void Output(int[] numbers)
        {
            int result = Sum(numbers);
            Console.WriteLine(result);
        }
    }


}
