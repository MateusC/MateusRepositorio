using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_8
    {

        static void Main(string[] args)
        {
            int qtdat, qtdmax, qtdmin = 0;
            float qtdmed = 0;
            Console.WriteLine("Quantidade Atual:");
            qtdat = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade Máxima:");
            qtdmax = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade Mínima:");
            qtdmin=int.Parse(Console.ReadLine());
            qtdmed = (qtdmax + qtdmin) / 2;
            if (qtdat >= qtdmed)
            {
                Console.WriteLine("Não efetuar Compra !");
            }
            else
            {
                Console.WriteLine("Efetuar Compra !");
            }
            Console.ReadKey();
        }


    }
}
