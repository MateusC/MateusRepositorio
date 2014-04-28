using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_4
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Programa 1
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());


            }
            Console.Clear();
            for (int j = 9; j > -1; j--)
            {
                Console.WriteLine(+vetor[j]);

            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            // Programa 2
            int[] vetor = new int[10];
            int[] vetor2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
                vetor2[i] = 1;
            }
            Console.Clear();
            for (int j = 0; j < 10; j++)
            {
                if (vetor[j] < 0)
                {
                    vetor[j] = vetor2[j];
                }
                Console.WriteLine(vetor[j]);
            }
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            //Programa 3
            int[,] vetor = new int[3,4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    vetor[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Matriz Original: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(vetor[i, j] + " ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Matriz Modificada: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < 4; j++)
                {
                    if (vetor[i, j] < 0)
                    {
                        Console.Write(0+" ");
                    }
                    else
                    {
                        Console.Write(vetor[i, j] + " ");
                    }
                    
                }
            }
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            //Programa 4
            int[] vetor = new int[20];
            int cont = 0;
            for (int i = 0; i < 20; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < 20; j++)
            {
                if (vetor[j] % 2 == 0)
                {
                    cont = cont + 1;
                }

            }
            Console.WriteLine("Existem " + cont + " elementos pares no vetor.");
            Console.ReadKey();
        }

        static void Main5(string[] args)
        {
            //Programa 5
            double[] vetor = new double[50];
            int cod = 0;
            for (int i = 0; i < 50; i++)
            {
                vetor[i] = i;

            }
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Listar Inverso");
            cod = int.Parse(Console.ReadLine());
            if (cod == 1)
            {
                for (int j=0;j<50;j++)
                {
                   Console.WriteLine(vetor[j]);
                }
            }
            else if (cod == 2)
            {
                for (int k = 49; k > 0; k--)
                {
                    Console.WriteLine(vetor[k]);

                }
            }
            else if (cod == 0)
            {
                Console.WriteLine(" ");
            }
            Console.ReadKey();

        }

       static void Main6(string[] args)
        {
            //Programa 6
            string[,] sala = new string[4,6];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sala[i,j] = Console.ReadLine();
                }
            }
            Console.WriteLine(" Nosso espelho:");
             for (int i = 0; i < 3; i++)
            {
                 Console.WriteLine(" ");
                 Console.WriteLine(" ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(sala[i,j]+"  ");
                    
                }
            }
            Console.ReadKey();
        }
    }
}
