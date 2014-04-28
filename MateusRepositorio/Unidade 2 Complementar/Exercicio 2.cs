using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_2
    {
        public static int h = 0;
        public static int b = 0;
        public static double a = 0;

        static void Main2(string[] args)
        { 
            Console.WriteLine("Digite a altura do triângulo: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do triângulo: ");
            b = int.Parse(Console.ReadLine());
            a = (b * h) / 2;
            Console.Write("A área do triângulo é de: "+a);
            Console.ReadKey();
        }
        }
    }

