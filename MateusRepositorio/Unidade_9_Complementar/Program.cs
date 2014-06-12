using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_9_Complementar
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Gabarito da Prova
            int[] Gabarito = new int[10];
            Random geradorGabarito = new Random();

            for (int i = 0; i < 10; i++)
            {
                    Gabarito[i] = geradorGabarito.Next(1, 4);   
            }
            Console.WriteLine("\t\t\tGabarito da Prova !!!\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Questão {0} : Resposta {1}.\n\n", i + 1, Gabarito[i]);
                
            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            // Estacionamento

            string[,] estacionamento = new string[4, 10];
            Random vagas = new Random();
            int vaga =0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    vaga = vagas.Next(0, 2);
                    if (vaga == 1)
                    {
                        estacionamento[i, j] = "Livre";
                    }
                    else
                    {
                        estacionamento[i, j] = "Ocupado";
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\nAndar {0} :\n", i + 1);
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("{0} vaga : {1} ",j+1,estacionamento[i,j]);
                    
                }
            }
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            // Menor numero e posição

            int[] vetor = new int[7];
            int posicao = 0;
            int menor = 2147483647;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite o {0} valor : ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }

            }
            Console.WriteLine("O menor número é {0} na {1}° posição do vetor.", menor, posicao);
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            // Vetor normal e Vetor nulo
            int [] vetor = new int[12];
            int[] vetorSemZero = new int[12];

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Digite o {0} valor : ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] == 0)
                {
                    vetorSemZero[i] = 1;

                }
                else
                {
                    vetorSemZero[i] = vetor[i];
                }
            }
            Console.Clear();
            Console.WriteLine("Vetor Normal || Vetor Sem Zero");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("   {0}                 {1}", vetor[i], vetorSemZero[i]);

            }
            Console.ReadKey();
        }

        static void Main5(string[] args)
        {
            // Gabaritos e alunos
            char[] resposta = new char[10];
            char[,] aluno = new char[20,10];
            int [] ponto = new int[20];
            string [] situacao = new string[20];
            string resposta1 = null;
            Console.WriteLine("Resposta do Gabarito : \n Opções A/B/C/D/E/F/G/H/I/J  ");
            for (int i = 0; i < 10; i++)
            {
                do
                {

                    Console.WriteLine("Questão {0}", i + 1);
                    resposta1 = Console.ReadLine();
                    resposta1 = resposta1.ToLower();



                } while (resposta1 != "a" && resposta1 != "b" && resposta1 != "c" && resposta1 != "d" && resposta1 != "e" && resposta1 != "f" && resposta1 != "g" && resposta1 != "h" && resposta1 != "i" && resposta1 != "j");
                resposta[i] = char.Parse(resposta1.ToUpper());
            }
            for (int i = 0; i < 20; i++)
            {
               
                Console.WriteLine("\nAluno {0}", i + 1);
                Console.WriteLine("Opções A B C D E F G H I J:\n ");
                
                for (int j = 0; j < 10; j++)
                {
                    do{
                        Console.Write("Questão {0} : ", j + 1);
                        resposta1 = Console.ReadLine();
                        resposta1 = resposta1.ToUpper();
                    } while (resposta1 != "A" && resposta1 != "B" && resposta1 != "C" && resposta1 != "D" && resposta1 != "E" && resposta1 != "F" && resposta1 != "G" && resposta1 != "H" && resposta1 != "I" && resposta1 != "J");
                    aluno[i,j] = char.Parse(resposta1);
                    if (aluno[i, j] == resposta[i])
                    {
                        ponto[i] += 1;
                    }
                    if (ponto[i] > 6 || ponto[i] == 6)
                    {
                        situacao[i] = "Aprovado.";

                    }
                    else
                    {
                        situacao[i] = "Reprovado.";
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\nAluno {0}", i + 1);
                Console.Write("Acertos {0} || Situação {1}\n", ponto[i], situacao[i]);
            }
            Console.ReadKey();
        }

        static void Main6(string[] args)
        {
            //Locadora
            int quantidadeClientes = 100000;
            int[] filmes = new int[quantidadeClientes];
            int[] filmesGratis = new int[5];

            Console.WriteLine("Quantidade de Clientes : ");
            quantidadeClientes = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeClientes; i++)
            {
                Console.WriteLine("Cliente {0}", i + 1);
                Console.WriteLine("Quantidade de filmes locados :  (max. 50 filmes)");
                do
                {
                    filmes[i] = int.Parse(Console.ReadLine());
                } while (filmes[i] < 0 || filmes[i] > 50);

                filmesGratis[i] = filmes[i] / 10;
            }

            for (int i = 0; i < quantidadeClientes; i++)
            {
                Console.WriteLine("O cliente {0} alugou {1} filmes e tem direito a {2} locações grátis", i + 1, filmes[i], filmesGratis[i]);

            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Opostos dos vetores
            int[] A = new int[50];
            int[] B = new int[50];
            //int total = 0;
            Random gerador = new Random();

            for (int i = 0; i < 50; i++)
            {

            }
            
        }
    }
}
