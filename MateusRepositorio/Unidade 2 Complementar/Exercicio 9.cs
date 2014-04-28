using System;

namespace Unidade_2
{
    internal class Exercicio_9
    {
        private static void Main9(string[] args)
        {
            char Op;
            double qtdA = 0;
            double qtdG = 0;
            double valorA = 2.90;
            double valorG = 3.30;
            double total = 0;
            double desconto = 0;

            Console.WriteLine("Qual o combustível a ser adquirido ?      A - Alcool /G - Gasolina ");
            Op = char.Parse(Console.ReadLine());

            if (Op == 'A' || Op == 'a')
            {
                Console.WriteLine("Quantos litros deseja comprar ?");
                qtdA = double.Parse(Console.ReadLine());
                if (qtdA > 20)
                {
                    desconto = ((qtdA * valorA) * 5) / 100;
                }
                else
                {
                    desconto = ((qtdA * valorA) * 3) / 100;
                }
                total = qtdA * valorA - desconto;
                Console.WriteLine("     Alcool    ");
                Console.WriteLine("Valor: " + total);
                Console.WriteLine("Litros: " + qtdA);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Quantos litros deseja comprar ?");
                qtdG = double.Parse(Console.ReadLine());
                if (qtdG > 20)
                {
                    desconto = ((qtdG * valorG) * 6) / 100;
                }
                else
                {
                    desconto = ((qtdG * valorG) * 4) / 100;
                }
                total = qtdA * valorA - desconto;
                Console.WriteLine("     Gasolina    ");
                Console.WriteLine("Valor: " + total);
                Console.WriteLine("Litros: " + qtdA);
                Console.ReadKey();
            }
        }
    }
}