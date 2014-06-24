using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_13_ArrayList_List
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Sequencia Descrescente
            ArrayList Lista = new ArrayList();
            int[] VetorDescrescente = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine("Array de numeros pares iniciando em 0 \n");
            for (int i = 0; i < 10; i++)
            {
                Lista.Add(i * 2); 
                Console.WriteLine(Lista[i]);
            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            //Sequencia Impar
            ArrayList Lista = new ArrayList();
            int[] VetorImpar = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine("Array Impar: \n");
            for (int i = 0; i < 10; i++)
            {
                Lista.Add(VetorImpar[i]);
                Console.WriteLine(Lista[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Sequencia Aleatoria
            ArrayList Lista = new ArrayList();
            int[] VetorAleatorio = new int[10];
            Random gerador = new Random();
            Console.WriteLine("Array Aleatório: \n");
            for (int i = 0, j = 0; i < 10; i++)
            {
                VetorAleatorio[i] = gerador.Next(0, 10);
                Lista.Add(VetorAleatorio[i]);
                if (i == 9)
                {
                    for (; j < 10; j++)
                    {
                        Console.WriteLine(Lista[j]);
                    }
                }

            }
            Console.ReadKey();
        }

    }
}
