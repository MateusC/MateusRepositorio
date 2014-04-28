using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_3
    {
         public static int ano=0;      
         public static int dias=0;
         public static int meses=0;
         public static int total=0;

        static void Main3(string[] args)
        {
            Console.WriteLine("Informe idade em anos: ");
            ano=int.Parse(Console.ReadLine());
            Console.WriteLine("Informe os meses: ");
            meses=int.Parse(Console.ReadLine());
            Console.WriteLine("Informe os dias: ");
            dias=int.Parse(Console.ReadLine());
            total= meses*30 +ano*365 + dias;
            Console.WriteLine("Sua idade total em dias é: " + total);
            Console.ReadKey();

        }
    }
}
