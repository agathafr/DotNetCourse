using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        // declaração de variáveis
        static int a;
        static int b;
        static void Main(string[] args)
        {
            RecebeDados();
            DeterminaSeSaoMultiplosOuNao(a, b);
            ExibeSaida();

            Console.ReadKey();
        }

        //entrada de dados
        static void RecebeDados()
        {
            Console.WriteLine("Esse programa determina se os dois números digitados são múltiplos entre si");
            Console.WriteLine("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro: ");
            b = int.Parse(Console.ReadLine());
        }

        // processamento
        static bool DeterminaSeSaoMultiplosOuNao(int a, int b)
        {
            if (a % b == 0)
                return true;

            return b % a == 0;
        }

        // saída
        static void ExibeSaida()
        {
            if (DeterminaSeSaoMultiplosOuNao(a, b) == false)
                Console.WriteLine("Não são múltiplos!");
            else
                Console.WriteLine("São múltiplos!");
        }
    }
}
