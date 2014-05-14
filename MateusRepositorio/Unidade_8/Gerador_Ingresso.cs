using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Gerador_Ingresso
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int setor, cadeira = 0;
            setor = gerador.Next(1,5);
            cadeira = gerador.Next(1,21);
            Console.WriteLine("Setor {0}, Cadeira {1}",setor,cadeira);
            Console.ReadKey();

        }

        static void Main2(string[] args)
        {
            //Ingressos de Loteria

            Random gerador = new Random();
            int ingresso = gerador.Next(1000, 10000);

            for (int i = 1000; i <= 9999; i++)
            {
                Console.Write(i+"  ");
            }
            Console.ReadKey();
        }
    }



}
