using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_8
{
    class A_Dividido_Por_B
    {
        //Programa 1

        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int a = gerador.Next(1, 5);
            int b = gerador.Next(1, 5);
            int div = a / b;
            string Divisao = div == 0 ? "É divisível" : "Não é divisível";
            Console.WriteLine("A {0} por B.", Divisao);
            Console.ReadKey();
        }
    }
}
