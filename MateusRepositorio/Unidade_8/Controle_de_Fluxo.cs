﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Controle_de_Fluxo
    {
        static void Main1(string[] args)
        {
            //Programa 1
            Random gerador = new Random();
            double nota = gerador.NextDouble();

            string FinalDeAno = nota >= 0.7 ? "Aprovado" : "Reprovado";
            Console.WriteLine("{0}, {1:F2}",FinalDeAno,nota);
            Console.ReadKey();

        }

        static void Main2(string[] args)
        {
            // Programa 2

            Random gerador = new Random();
            int somaLancamentos = 0;
            int jogadas =0;

            for (int i = 1; i <= 5; i++)
            {
                int numero = gerador.Next(1, 7);
                somaLancamentos += numero;
                jogadas = i;
                if (somaLancamentos > 19)
                {
                    break;
                }
            }
            if (somaLancamentos > 19)
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
