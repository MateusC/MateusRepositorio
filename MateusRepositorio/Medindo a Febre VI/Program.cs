using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_Febre_VI
{
    class Program
    {
        static void Main1(string[] args)
        {
            int QuantidadeAlunos = 2;
            int[] Matricula = new int[QuantidadeAlunos];
            double[,] Notas = new double[QuantidadeAlunos, 3];
            int[] Frequencia = new int[QuantidadeAlunos];
            double[] Media = new double[QuantidadeAlunos];
            string[] situacao = new string[QuantidadeAlunos];
            double MaiorNota = 0;
            double NotaMedia = 0;
            double MenorNota = 100;
            int QuantidadeReprovados = 0;
        //    Console.WriteLine("Quantidade de Alunos: ");
          //  QuantidadeAlunos = int.Parse(Console.ReadLine());        Caso queira inserir um controle de quantidade de alunos.
            for (int i = 0; i < QuantidadeAlunos; i++)
            {
                Console.Write("Matrícula n°: ");
                Matricula[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Notas válidas de 0 - 100.");
                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write("Nota {0} : ", j+1);
                    do
                    {
                        Notas[i, j] = double.Parse(Console.ReadLine());
                    } while (Notas[i, j] < 0 || Notas[i, j] > 100);

                    NotaMedia += Notas[i, j];                               
                    
                }
                Media[i] = (Notas [i,0] + Notas [i,1]+Notas [i,2] ) / 3;
                if (Media[i] < MenorNota)
                {
                    MenorNota = Media[i];
                }
                if (Media[i] > MaiorNota)
                {
                    MaiorNota = Media[i];
                }
                Console.Write("Numero de presenças: ");
                Frequencia[i] = int.Parse(Console.ReadLine());
                if (Frequencia[i] < 40 || Media[i] <60 )
                {
                    situacao[i] = "Reprovado";
                    QuantidadeReprovados += 1;
                }
                else
                {
                    situacao[i] = "Aprovado";

                }
                Console.Clear();
            }
            for (int k = 0; k < QuantidadeAlunos; k++)
            {
                Console.WriteLine("\nMatrícula.......:  {0}", Matricula[k]);
                Console.WriteLine("Nota Final......:  {0:F2}", Media[k]);
                Console.WriteLine("Frequência......:  {0}", Frequencia[k]);
                Console.WriteLine("Situação........:  {0}", situacao[k]);
            }
            
            NotaMedia = (NotaMedia / 3) / QuantidadeAlunos;
            Console.WriteLine("\nTotal alunos.........: {0}", QuantidadeAlunos);
            Console.WriteLine("Nota Média da turma..: {0:F2}", NotaMedia);
            Console.WriteLine("Maior Média...........: {0}", MaiorNota);
            Console.WriteLine("Menor Média...........: {0}", MenorNota);
            Console.WriteLine("Alunos reprovados....: {0}", QuantidadeReprovados);
            Console.ReadKey();
        }
    }
}
