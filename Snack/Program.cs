using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{   
    class Program
    {
        // declaração de variáveis
        static int cod;
        static int qtde;
        static double precoTotal;
        static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        static void Main(string[] args)
        {
            RecebeDados();
            CalculaPrecoTotal(cod, qtde);
            ExibeSaida(cod, qtde);

            Console.ReadKey();
        }

        // entrada de dados
        static void RecebeDados()
        {
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("\tMenu");
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("Código\tEspecificação\tPreço");
            Console.WriteLine("1\tCachorro Quente\tR$4.00");
            Console.WriteLine("2\tX-Salada\tR$4.50");
            Console.WriteLine("3\tX-Bacon\t\tR$5.00");
            Console.WriteLine("4\tTorrada Simples\tR$2.00");
            Console.WriteLine("5\tRefrigerante\tR$1.50");
            Console.WriteLine();
            Console.WriteLine("Informe o código do item desejado conforme o menu acima:");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do item desejado: ");
            qtde = int.Parse(Console.ReadLine());
        }

        // processamento
        static double CalculaPrecoTotal(int cod, int qtde)
        {
            switch (cod)
            {
                case 1:
                    precoTotal = 4.00 * qtde;
                    break;

                case 2:
                    precoTotal = 4.50 * qtde;
                    break;

                case 3:
                    precoTotal = 5.00 * qtde;
                    break;

                case 4:
                    precoTotal = 2.00 * qtde;
                    break;

                case 5:
                    precoTotal = 1.50 * qtde;
                    break;

                default:
                    Console.WriteLine("Selecione um código existente no menu!");
                    break;
            }
            return precoTotal;
        }

        // saída de dados
        static void ExibeSaida(int cod, int qtde)
        {
            Console.WriteLine("Total R$" + CalculaPrecoTotal(cod, qtde).ToString("F2", culture));
        }
    }
}
