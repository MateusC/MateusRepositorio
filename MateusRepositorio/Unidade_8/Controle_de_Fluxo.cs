using System;
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
    }
}
