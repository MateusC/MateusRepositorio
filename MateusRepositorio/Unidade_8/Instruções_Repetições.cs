using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Instruções_Repetições
    {
        static void Main1(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("Mensagem {0}", i);
            }
            Console.ReadKey();

        }
    }
}
