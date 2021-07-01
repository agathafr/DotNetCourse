using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotas
{
    class Program
    {
        public static List<Aluno> alunos = new List<Aluno>();
        private static double media;
        static void Main(string[] args)
        {
            LeituraDeDados();

            CalculoMedia(alunos);

            SaidaDeDados(alunos);

            Console.ReadKey();
        }
        private static void LeituraDeDados()
        {
            char flag = 'S';

            Aluno aluno = new Aluno();
            do
            {
                Console.WriteLine("Digite o nome do Aluno");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Digite a nota do Aluno");
                aluno.Nota = double.Parse(Console.ReadLine());

                alunos.Add(new Aluno(aluno.Nome, aluno.Nota));

                Console.Clear();

            } while (alunos.Count < 2);

            while (flag == 'S')
            {
                Console.WriteLine("Deseja continuar cadastrando alunos? [S]/[N]");
                flag = char.ToUpper(char.Parse(Console.ReadLine()));

                if (flag == 'S')
                {
                    Console.WriteLine("Digite o nome do Aluno");
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Digite a nota do Aluno");
                    aluno.Nota = double.Parse(Console.ReadLine());

                    alunos.Add(new Aluno(aluno.Nome, aluno.Nota));
                }
                Console.Clear();
            }
        }
        private static double CalculoMedia(List<Aluno> alunos)
        {
            double soma = 0.0;
            foreach (var aluno in alunos)
            {
                soma += aluno.Nota;
            }
            media = soma / alunos.Count;
            return media;
        }
        private static void SaidaDeDados(List<Aluno> alunos)
        {
            Console.WriteLine("\nAlunos e Notas cadastradas");
            Console.WriteLine("------------------------------");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome} \tNota: {aluno.Nota}");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nMédia entre as notas: {media}");
            Console.ReadKey();
        }
    }
}