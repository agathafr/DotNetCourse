using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            float baseMenor, baseMaior, altura, area;

            // entrada de dados
            Console.WriteLine("Digite a base menor: ");
            baseMenor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base maior: ");
            baseMaior = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());

            // verificação 
            if (baseMenor > baseMaior)
            {
                Console.WriteLine("Não é possível calcular a área!");
            }
            else
            {
                //processamento
                area = (baseMenor + baseMaior) * altura / 2;

                // saída de dados
                Console.WriteLine("Área = " + area.ToString("F2"));
                Console.WriteLine("Área = {0}", area.ToString("F3"));

            }
            Console.ReadKey();
        }
    }
}