using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Imprime_100_Exceto_Multiplos_de_3
    {
        static void Main1(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (!(i % 3 == 0))
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();


        }
    }
}
