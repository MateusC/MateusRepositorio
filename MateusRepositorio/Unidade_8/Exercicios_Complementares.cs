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

        static void Main(string[] args)
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
    }
}
