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
            AddElementsToArray();
            DisplayMatrixElements();
            SumMatrixDiagonalElements();
            DisplaySumOfMatrixDiagonalElements(sum);

            Console.ReadKey();
        }

        static void AddElementsToArray()
        {
            Random rdn = new Random();
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = rdn.Next(1, 60);
                }
            }
        }

        static void DisplayMatrixElements()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("[" + matrix[i, j] + "]" + "\t");
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
                    if(i == j)
                    {
                        sum += matrix[i, j]; 
                    }
                }
            }
            return sum;
        }

        static void DisplaySumOfMatrixDiagonalElements(int sum)
        {
            Console.WriteLine("The sum of the elements of the diagonal of the matrix is " + sum);
        }
    }
}
