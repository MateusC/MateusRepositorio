using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
 {
    class Exercicio_1
    {
        public static int x = 0;
        static void Main1(string[] args) 
        {
            Console.WriteLine("Digite um valor: ");
            x=int.Parse(Console.ReadLine());
            x = x - 1;
            Console.WriteLine("O número antecessor é: ");
            Console.Write(x);
            Console.ReadKey();
        }
    }
    }

