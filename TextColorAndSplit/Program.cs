using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextColorAndSplit
{
    class Program
    {
        static string nome;
        static int qtdeQuartos;
        static float preco;
        static string[] entradas;
        const ConsoleColor red = ConsoleColor.Red;
        static void Main(string[] args)
        {
            RecebeDados();
            MostraSaida(entradas);

            Console.ReadKey();
        }

        static void RecebeDados()
        {
            Console.WriteLine("Entre com seu nome completo: ");
            Console.ForegroundColor = red;
            nome = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            Console.ForegroundColor = red;
            qtdeQuartos = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine("Entre com o preço de um produto: ");
            Console.ForegroundColor = red;
            preco = float.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha)");
            Console.ForegroundColor = red;
            entradas = Console.ReadLine().Split(' ');
            Console.ResetColor();

            Console.Clear();
        }
        static void MostraSaida(string[] entradas)
        {
            Console.WriteLine($"O seu nome é {nome}.");
            Console.WriteLine();
            Console.WriteLine($"A sua casa possui {qtdeQuartos} quartos.");
            Console.WriteLine();
            Console.WriteLine($"O preço do produto que você digitou é {preco}.");
            Console.WriteLine();
            Console.Write("O seu último nome, idade e altura são, reespectivamente: ");

            foreach (var entrada in entradas)
            {
                Console.Write(entrada + " ");
            }
            Console.WriteLine();
        }
    }
}
