using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Escolhe_Caminho
    {
        // Programa 1
        static void Main(string[] args)
        {
            Random gerador = new Random();
            double caminho = gerador.NextDouble();

            string CaminhoCerto = caminho > 0.5 ? "siga pra direita" : "siga pra esquerda";
            Console.WriteLine("Pare, {0} !", CaminhoCerto);
            Console.ReadKey();
        }
    }
}
