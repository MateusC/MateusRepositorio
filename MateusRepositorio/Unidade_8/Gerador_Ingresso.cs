using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Gerador_Ingresso
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int i, j = 0;
            i = gerador.Next(1,5);
            j = gerador.Next(1,201);
            Console.WriteLine("Setor {0}, Cadeira {1}",i,j);
            Console.ReadKey();


        }
    }
}
