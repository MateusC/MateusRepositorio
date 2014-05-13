using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Camisas
    {
        // Programa 1

        static void Main(string[] args)
        {
            Random gerador = new Random();
            double camisa = gerador.NextDouble();
            string Cor = camisa > 0.5 ? "Vermelha" : "Azul";
            Console.WriteLine("A camisa é {0}.", Cor);
            Console.ReadKey();
        }
    }
}
