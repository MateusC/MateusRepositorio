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
            int setor, cadeira = 0;
            setor = gerador.Next(1,5);
            cadeira = gerador.Next(1,21);
            Console.WriteLine("Setor {0}, Cadeira {1}",setor,cadeira);
            Console.ReadKey();


        }
    }
}
