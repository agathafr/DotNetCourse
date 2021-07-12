using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month
{
    class Program
    {
        static int number;
        static string month;

        static void Main(string[] args)
        {
            ReceivesData();
            month = IdentifiesMonth(number);
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter a integer number between 1 and 12 (including): ");
            number = int.Parse(Console.ReadLine());
        }

        static string IdentifiesMonth(int number)
        {
            switch (number)
            {
                case 1:
                    month = "january";
                    break;

                case 2:
                    month = "february";
                    break;

                case 3:
                    month = "march";
                    break;

                case 4:
                    month = "april";
                    break;

                case 5:
                    month = "may";
                    break;

                case 6:
                    month = "june";
                    break;

                case 7:
                    month = "july";
                    break;

                case 8:
                    month = "august";
                    break;

                case 9:
                    month = "september";
                    break;

                case 10:
                    month = "october";
                    break;

                case 11:
                    month = "november";
                    break;

                case 12:
                    month = "december";
                    break;

                default:
                    month = "Enter a number between 1 and 12 (including)!";
                    break;
            }

            return month;
        }

        static void DisplaysOutput()
        {
            Console.WriteLine(char.ToUpper(month[0]) + month.Substring(1));
        }
    }
}
