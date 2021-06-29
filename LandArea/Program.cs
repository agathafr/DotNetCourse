using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasTerreno
{
    class Program
    {
        static double largura, comprimento, area, preco, precoTotal;
        static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        static void Main(string[] args)
        {
            RecebeDados();
            CalculaAreaDoTerreno();
            CalculaPrecoDoTerreno();
            MostraResultado();

            Console.ReadKey();
        }

        static void RecebeDados()
        {
            Console.WriteLine("Informe a largura do terreno: ");
            largura = Math.Round(double.Parse(Console.ReadLine()), 1);

            Console.WriteLine("Informe o comprimento do terreno: ");
            comprimento = Math.Round(double.Parse(Console.ReadLine()), 1);

            Console.WriteLine("Informe o valor do metro quadrado: ");
            preco = Math.Round(double.Parse(Console.ReadLine()), 2);
        }

        static double CalculaAreaDoTerreno()
        {
            return area = comprimento * largura;
        }

        static double CalculaPrecoDoTerreno()
        {
            return precoTotal = area * preco;
        }

        static void MostraResultado()
        {
            Console.WriteLine("A área e o valor do terreno são, reespectivamente: {0} e {1}", area.ToString("F", culture), precoTotal.ToString("F", culture));
        }
    }
}