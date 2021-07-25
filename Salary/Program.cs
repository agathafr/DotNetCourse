using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static int number, workedHours;
        static double monthlySalary;
        static CultureInfo enUs = new CultureInfo("en-US");

        static void Main(string[] args)
        {
            ReceivesData();
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter your registration number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your number of monthly hours worked: ");
            workedHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount you receive for hours worked: ");
            monthlySalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();
        }

        static double CalculatesTheMonthlySalary()
        {
            return monthlySalary * workedHours;
        }
        
        static void DisplaysOutput()
        {
            Console.WriteLine("Number = " + number);
            Console.WriteLine("Salary = U$ " + CalculatesTheMonthlySalary().ToString("N2", enUs));
        }
    }
}
