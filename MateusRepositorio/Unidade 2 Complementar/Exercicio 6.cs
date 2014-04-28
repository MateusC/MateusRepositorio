using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_6
    {

        static void Main6(string[] args)
        {
            int horapormes = 0;
            float salhora = 0;
            double valorporhora = 0;
            Double salario = 0;

            
            Console.WriteLine("Digite a quantidade de horas trabalhadas no mês: ");
            horapormes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do salário por hora: ");
            salhora = float.Parse(Console.ReadLine());
            if (horapormes > 160)
            {
                valorporhora = (horapormes - 160) * (salhora * 1.5);
            }
            salario = (horapormes * salhora) + valorporhora;
            salario = Math.Round(salario, 2);
            Console.WriteLine("O funcionário recebe " + salario);
            Console.ReadKey();

        }
    }
}
