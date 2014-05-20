using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_9
{
    class Program
    {
        static void Main1(string[] args)
        {
            // SequenciaQualquer.cs

            int[] VetorInteiro = new int[10];

            for (int i = 0, j=0; i < 10; i++)
            {
                Console.Write("Digite o {0} valor : ", i + 1);
                VetorInteiro[i] = int.Parse(Console.ReadLine());
                if (i == 9)
                {
                    Console.WriteLine(" ");
                    for (; j < 10; j++)
                    {
                        Console.WriteLine(VetorInteiro[j]);
                    }
                }
            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            //SequenciaCrescente.cs

            int[] VetorCrescente = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o {0} valor : ", i + 1);
                VetorCrescente[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (VetorCrescente[i] < VetorCrescente[j])
                    {
                        int aux = VetorCrescente[j];
                        VetorCrescente[j] = VetorCrescente[i];
                        VetorCrescente[i] = aux;

                    }
                    
                }

            }
            Console.WriteLine("Array Crescente !\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VetorCrescente[i]);

            }
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            // Sequencia Descrescente

            int [] VetorDescrescente = {9,8,7,6,5,4,3,2,1,0};
            Console.WriteLine("Array em Ordem Decrescente ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VetorDescrescente[i]);
            }
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            //Sequencia Impar

            int[] VetorImpar = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine("Array Impar: \n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(VetorImpar[i]);
            }
            Console.ReadKey();
        }

        static void Main5(string[] args)
        {
            // Sequencia Aleatoria

            int[] VetorAleatorio = new int[10];
            Random gerador = new Random();
            Console.WriteLine("Array Aleatório: \n");
            for (int i = 0, j = 0; i < 10; i++)
            {
                VetorAleatorio[i] = gerador.Next(0, 10);

                if (i == 9)
                {
                    for (; j < 10; j++)
                    {
                        Console.WriteLine(VetorAleatorio[j]);
                    }
                }

            }
            Console.ReadKey();
        }

        static void Main6(string[] args)
        {
            // Tabela Qualquer
            int[,] Matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix[i, j] = i + j;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("  "+Matrix[i, j]);
                }
            }
            Console.ReadKey();
        }

        static void Main7(string[] args)
        {
            // Tabela Aleatoria
            int[,] Matrix2 = new int[10, 10];
            Random sorte = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Matrix2[i, j] = sorte.Next(0, 10);
                }
            }
            Console.WriteLine("Tabela Aleatória : \n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < 10; j++)
                {
                    
                    Console.Write(" "+Matrix2[i, j]);
                    if (j == 4)
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
            Console.ReadKey();
        }

        static void Main8(string[] args)
        {
            //Tabuada
            int[,] Tabuada = new int [10,10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < 10; j++)
                {
                    Tabuada[i, j] = (i + 1) * (j + 1);
                    Console.WriteLine("{0} X {1} = {2}",i+1,j+1,Tabuada[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
