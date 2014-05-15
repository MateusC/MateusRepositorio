using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Exercicios_Complementares
    {
        static void Main1(string[] args)
        {
            // Programa 1

            Random gerador = new Random();
            int a = gerador.Next(1, 10);
            int b = gerador.Next(1, 10);

            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine(" {0} = {1}", a, b);
            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            // Programa 2
            string espaco = " ";
            int i = 0;
            string asterisco = "**********";

            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                    {
                        espaco = "";
                    }
                    else if (j == 1)
                    {
                        espaco = " ";
                    }
                    else if (j == 2)
                    {
                        espaco = "  ";
                    }
                    else if (j == 3)
                    {
                        espaco = "   ";
                    }
                    else if (j == 4)
                    {
                        espaco = "    ";
                    }
                    Console.WriteLine("{0}{1}", espaco, asterisco);
                    
                }
            }
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            // Programa 3

           // int Bloco, Andar, Apartamento = 0;   Se quiser totalizar o numero de apartamentos e andares.
            int i, i2, i3 = 0;

            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("\n\t\t\tCartões do Bloco {0}:\n", i);
                for (i2 = 1; i2 <= 9; i2++)
                {
                    Console.WriteLine("\nAndar {0}\n", i2);
                    for (i3 = 1; i3 <= 4; i3++)
                    {
                        Console.Write("Apartamento {0}\n",i2*10 + i3);
                    }
                }
            }
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            // Programa 4

            int i, j = 0;

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(" ");
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                }
            }
            Console.ReadKey();
        }

        static void Main5(string[] args)
        {
            // Programa 5

            Random gerador = new Random();
            int erro = 0;
            int total = 0;

            for (int i = 1; i <= 10; i++)
            {
                int numero = gerador.Next(1, 7);
                if (numero == 6)
                {
                    erro += 1;
                }
                else if (numero == 1)
                {
                    continue;
                }
                if (erro == 2)
                {
                    break;
                }
                total+=numero;
            }
            Console.WriteLine("Erros (6): {0}", erro);
            if (total%2 != 0 && erro != 2){
                Console.WriteLine("Voce ganhou, com {0} pontos !", total);
            }
            else
            {
                Console.WriteLine("Voce perdeu, com {0} pontos !",total);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Programa 6
            Random gerador = new Random();
            int Numero = gerador.Next(1, 20000000);
            Console.WriteLine(Numero);
            string Numeros = Numero.ToString();
            int contador =0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == '1')
                {
                    contador += 1;
                }
            }
                Console.WriteLine(Numeros);
                Console.WriteLine("Tem {0} numeros 1.", contador);


            Console.ReadKey();



           

        }
    }
}
