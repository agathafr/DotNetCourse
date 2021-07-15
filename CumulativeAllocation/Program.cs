using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumulativeAllocation
{
    class Program
    {
        // declaração de variáveis
        static int minutos;

        static void Main(string[] args)
        {
            RecebeDado();
            CalculaValorASerPago(minutos);
            ExibeSaida(minutos);

            Console.ReadKey();
        }
        static void RecebeDado()
        {
            Console.WriteLine("Digite a quantidade de minutos que você consumiu: ");
            minutos = int.Parse(Console.ReadLine());
        }
        static int RetornaMinutosExcedidos(int minutos)
        {
            return minutos - 100;
        }
        static double CalculaValorASerPago(int minutos)
        {
            if (minutos <= 100)
            {
                return 50.00;
            }
            return RetornaMinutosExcedidos(minutos) * 2.00 + 50.00;
        }
        static void ExibeSaida(int minutos)
        {
            Console.WriteLine("Valor a pagar: R$ " + CalculaValorASerPago(minutos).ToString("F2"));
        }
    }
}
