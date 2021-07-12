using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMatrixDiagonal
{
    class Program
    {
        static int[,] matrix = new int[6, 6];
        static int sum = 0;

        static void Main(string[] args)
        {
            AddElementsToMatrix();
            DisplayMatrixElements();
            DisplaySumOfMatrixDiagonalElements();

            Console.ReadKey();
        }

        static void AddElementsToMatrix()
        {
            Random rdn = new Random();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = rdn.Next(1, 5);
                }
            }
        }

        static void DisplayMatrixElements()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("[" + matrix[i, j] + "]");
                }
                Console.WriteLine();
            }
        }

        static int SumMatrixDiagonalElements()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }

        static void DisplaySumOfMatrixDiagonalElements()
        {
            Console.WriteLine("The sum of the elements of the diagonal of the matrix is " + SumMatrixDiagonalElements());
        }
    }
}
