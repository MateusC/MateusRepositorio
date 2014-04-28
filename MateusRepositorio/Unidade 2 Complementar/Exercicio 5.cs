using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_5
    {

        static void Main5(string[] args)
        {
            int inicio=0;
            int fim=0;
            int diferenca=0;


            Console.WriteLine("Digite o horário de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o término da partida: ");
            fim = int.Parse(Console.ReadLine());
            if (fim>inicio) {
                diferenca = fim - inicio;
            }
            else {
                diferenca = (24 - inicio) + fim;
            }
            Console.WriteLine("A partida demorou " + diferenca + " horas.");
            Console.ReadKey();




        }
    }
}
