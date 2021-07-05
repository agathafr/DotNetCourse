using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest
{
    class Program
    {
        // declaração de variáveis

        private static int a, b, c, d;
        static string[] valores;
        static int[] arrayInt;
        static void Main(string[] args)
        {
            RecebeDados();
            SeparaDados(arrayInt);
            SomaValoresAEB(a, b);
            SomaValoresCED(c, d);
            TestaSeCEDSaoPositivos(c, d);
            TestaSeAEPar(a);
            ComparaValores(a, b, c, d);
            ExibeSaida(a, b, c, d);

            Console.ReadKey();
        }

        // entrada de dados
        static void RecebeDados()
        {
            Console.WriteLine("Informe quatro valores: ");
            valores = Console.ReadLine().Split(' ');
            arrayInt = Array.ConvertAll(valores, int.Parse);

            // a = int.Parse(valores[0]);
        }

        static void SeparaDados(int[] arrayInt)
        {
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (i == 0)
                {
                    a = arrayInt[i];
                }
                else if (i == 1)
                {
                    b = arrayInt[i];
                }
                else if (i == 2)
                {
                    c = arrayInt[i];
                }
                else
                {
                    d = arrayInt[i];
                }
            }
        }

        // processamento
        static int SomaValoresCED(int c, int d)
        {
            return c + d;
        }

        static int SomaValoresAEB(int a, int b)
        {
            return a + b;
        }

        static bool TestaSeCEDSaoPositivos(int c, int d)
        {
            if (c > 0 && d > 0)
            {
                return true;
            }
            return false;
        }

        static bool TestaSeAEPar(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ComparaValores(int a, int b, int c, int d)
        {
            if (b > c && d > a && SomaValoresCED(c, d) > SomaValoresAEB(a, b) && TestaSeCEDSaoPositivos(c, d) == true && TestaSeAEPar(a) == true)
            {
                return true;
            }
            return false;
        }

        // saída de dados
        static void ExibeSaida(int a, int b, int c, int d)
        {
            if (ComparaValores(a, b, c, d) == true)
            {
                Console.WriteLine("Valores aceitos!");
            }
            else
            {
                Console.WriteLine("Valores não aceitos!");
            }
        }
    }
}
