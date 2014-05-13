using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class Verifica_Valor_Produto
    {
        static void Main1(string[] args)
        {
            //Programa 1
            Random gerador = new Random();
            double preco = gerador.NextDouble();

            string situacao = preco > 0.5 ? "caro" : "em conta";
            Console.WriteLine("O preço está {0} : {1:F2}", situacao, preco);
            Console.ReadKey();

        }
    }
}
