using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Divide_Maior_Inteiro
    {
        static void Main (string[]args)
        {
            int inteiro = 2147483647;
            int resultado = inteiro;
            for (int i = 1; resultado > 100;i++ )
            {
                resultado = inteiro / 2;
                inteiro = resultado;
                Console.Write("\n{0}", resultado);

            }
            Console.ReadKey();



        }
    }
}
