using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        // declaração de variáveis
        static int escolha;
        static string dia;
        static void Main(string[] args)
        {
            RecebeDado();
            IdentificaDiaDaSemana(escolha);
            ExibeSaida(escolha);

            Console.ReadKey();
        }
        // entrada de dados
        static void RecebeDado()
        {
            Console.WriteLine("Digite um número de 1 a 7 para ver o dia da semana correspondente a ele: ");
            escolha = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        // processamento
        static string IdentificaDiaDaSemana(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    dia = "Segunda";
                    break;
                case 2:
                    dia = "Terça";
                    break;
                case 3:
                    dia = "Quarta";
                    break;
                case 4:
                    dia = "Quinta";
                    break;
                case 5:
                    dia = "Sexta";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Valor inválido!";
                    break;
            }
            return dia;
        }
        // saída de dados
        static void ExibeSaida(int escolha)
        {
            Console.WriteLine("Dia da semana: " + IdentificaDiaDaSemana(escolha));
        }
    }
}
