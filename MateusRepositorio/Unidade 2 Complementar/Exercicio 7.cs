using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_7
    {

        static void Main7(string[] args)
        {    
            int num=0;
            double saldo,saldoatual,credito,debito=0;

            Console.WriteLine("Digite o número da conta: ");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo da conta: ");
            saldo=double.Parse(Console.ReadLine());
            Console.WriteLine("Débito: ");
            debito=double.Parse(Console.ReadLine());
            Console.WriteLine("Crédito: ");
            credito=double.Parse(Console.ReadLine());
            saldoatual= saldo-debito+credito;
            saldoatual= Math.Round(saldoatual, 2);
            if (saldoatual>=0){

                Console.WriteLine("Saldo Positivo !!!");
            }else{
                Console.WriteLine("Saldo Negativo !!!");
            }
            Console.ReadKey();

        }
    }
}
