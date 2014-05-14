using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class JogoDeDado2
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int somaLancamentos = 0;
            int jogadas = 0;
            for (int i = 1; i <= 4; i++)
            {
                int numero = gerador.Next(1, 7);
               // jogadas = i;
                Console.WriteLine(numero);
                jogadas = i;
                if (numero%2 != 0)
                {
                    somaLancamentos += numero;
                    continue;
                }
                if (somaLancamentos > 9)
                {
                    break;
                }

            }
            if (somaLancamentos > 9)
            {
                Console.Write("Voce ganhou, com {0} lançamentos o valor de {1}", jogadas, somaLancamentos);
            }
            else
            {
                Console.Write("Voce perdeu, com {0} lançamentos e o valor de {1}", jogadas, somaLancamentos);
            }
           
            Console.ReadKey();
        }
    }
}
