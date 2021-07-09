using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurationOfAGame
{
    class Program
    {
        // declaração de variáveis
        static int horaInicio;
        static int horaFim;

        static void Main(string[] args)
        {
            RecebeDados();
            CalculaDuracaoDoJogo(horaInicio, horaFim);
            MostraSaida(horaInicio, horaFim);

            Console.ReadKey();
        }

        // entrada de dados
        static void RecebeDados()
        {
            Console.WriteLine("Digite o horário que o jogo começou: ");
            horaInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o horário que o jogo terminou: ");
            horaFim = int.Parse(Console.ReadLine());
        }

        // processamento
        static int CalculaDuracaoDoJogo(int horaInicio, int horaFim)
        {
            if (horaInicio > horaFim || horaInicio == 0 && horaFim == 0)
                return 24 - horaInicio + horaFim;
            else 
                return horaFim - horaInicio;
        }

        // saída de dados
        static void MostraSaida(int horaInicio, int horaFim)
        {
            Console.WriteLine("O jogo durou " + CalculaDuracaoDoJogo(horaInicio, horaFim) + " hora(s).");
        }
    }
}
