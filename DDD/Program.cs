using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD
{
    class Program
    {
        static int ddd;
        static string destination;
        static void Main(string[] args)
        {
            ReceivesData();
            destination = IdentifiesCity(ddd);
            DisplaysOutput();

            Console.ReadKey();
        }

        static void ReceivesData()
        {
            Console.WriteLine("Enter a area code to see the name of the corresponding city: ");
            ddd = int.Parse(Console.ReadLine());

            Console.Clear();
        }

        static string IdentifiesCity(int ddd)
        {
            switch (ddd)
            {
                case 61:
                    destination = "Brasilia";
                    break;

                case 71:
                    destination = "Salvador";
                    break;
                case 11:
                    destination = "São Paulo";
                    break;

                case 21:
                    destination = "Rio de Janeiro";
                    break;

                case 32:
                    destination = "Juiz de Fora";
                    break;

                case 19:
                    destination = "Campinas";
                    break;

                case 27:
                    destination = "Vitoria";
                    break;

                case 31:
                    destination = "Belo Horizonte";
                    break;

                default:
                    destination = "DDD não cadastrado";
                    break;
            }
            return destination;
        }

        static void DisplaysOutput()
        {
            Console.WriteLine(destination);
        }
    }
}
