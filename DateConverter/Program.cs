using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConverter
{
    class Program
    {
        // declaração de variáveis
        static int dias;
        const int ano = 365;
        static void Main(string[] args)
        {
            RecebeDado();
            CalculaAnos(dias);
            CalculaMeses(dias);
            CalculaDias(dias);
            ExibeSaida(dias);

            Console.ReadKey();
        }

        // entrada 
        static void RecebeDado()
        {
            Console.WriteLine("Informe a sua idade em dias: ");
            dias = int.Parse(Console.ReadLine());
        }

        // processamento 
        static float Dec(float resultado)
        {
            return resultado - (int)resultado;
        }
        static float CalculaAnos(float dias)
        {
            return dias / ano;
        }
        static float CalculaMeses(int dias)
        {
            return Dec(CalculaAnos(dias)) * 12;
        }
        static float CalculaDias(int dias)
        {
            return Dec(CalculaMeses(dias)) * 30;
        }
        
        static float RetornaAnos(int dias)
        {
            return (float)Math.Truncate(CalculaAnos(dias));
        }
        static float RetornaMeses(int dias)
        {
            return (float)Math.Truncate(CalculaMeses(dias));
        }
        static float RetornaDias(int dias)
        {
            return (float)(Math.Round(CalculaDias(dias)));
        }

        // saída
        static void ExibeSaida(int dias)
        {
            Console.WriteLine("A sua idade equivale a {0} ano(s), {1} mês(es) e {2} dia(s)", RetornaAnos(dias), RetornaMeses(dias), RetornaDias(dias));
        }
    }
}
