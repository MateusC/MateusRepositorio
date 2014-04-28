using System;

namespace Unidade_2
{
    internal class Exercicio_10
    {
        private static void Main(string[] args)
        {
            int soma = 0;
            int soma2 = 0;

            Console.WriteLine("Idade do 1 Homem: ");
            int h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Idade do 2 homem: ");
            int h2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Idade da 1 mulher: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Idade da 2 mulher: ");
            int m2 = int.Parse(Console.ReadLine());
            if (h1 > h2)
            {
                if (m1 > m2)
                {
                    soma = h1 + m2;
                    soma2 = h2 + m1;
                }
                else
                {
                    soma = h1 + m1;
                    soma2 = h2 + m2;
                }
            }
            else
            {
                if (m1 > m2)
                {
                    soma = h2 + m2;
                    soma2 = h1 + m1;
                }
                else
                {
                    soma = h2 + m1;
                    soma2 = h1 + m2;
                }
                Console.WriteLine("A soma do homem mais velho e mulher mais nova ficou: " + soma);
                Console.WriteLine("A soma do homem mais novo e mulher mais velha ficou: " + soma2);
                Console.ReadKey();
            }
        }
    }
}