using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicios em ordem 

            //ConsumoDeCombustivel();
            //JurosComposto();
            //IRPF();
            //IMC();
            //ArrayAleatorio();
        }
        static void ConsumoDeCombustivel()
        {

            Console.WriteLine("Distancia percorrida : ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de Combustivel : ");
            double y = double.Parse(Console.ReadLine());
            double resp = x / y;
            Console.WriteLine("É gasto {0} litros de gasolina por km ",resp);
            Console.ReadKey();
        }
        static void JurosComposto()
        {
            Console.Write("Quantia pega : ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Taxa de juros : ");
            double taxa = double.Parse(Console.ReadLine());
            taxa = taxa/100;
            Console.Write("Tempo de pagamento : ");
            int tempo = int.Parse(Console.ReadLine());
            double potencia = Math.Pow(taxa+1,tempo);
            double juros = valor * potencia;
            Console.WriteLine("Voce pagara no total : {0:F2}", juros);
            Console.ReadKey();
        }
        static void IRPF()
        {
            //Base de cálculo anual em R$	Alíquota (%)
            //Até 1.637,11	                     -	                
            //De 1.637,12 até 2.453,50	        7,5	               
            //De 2.453,51 até 3.271,38	        15	               
            //De 3.271,39 até 4.087,65	        22,5	           
            //Acima de 4.087,65	                27,5	            
            double desconto;
            Console.Write("Digite o salário : ");
            double Salario = double.Parse(Console.ReadLine());
            if (Salario > 4087.85)
            {
                desconto = (Salario * 27.5) / 100;
            }
            else if (Salario > 3271.38)
            {
                desconto = (Salario * 22.5) / 100;
            }
            else if (Salario > 2453.50)
            {
                desconto = (Salario * 15) / 100;
            }
            else if (Salario > 1637.11)
            {
                desconto = (Salario * 7.5) / 100;
            }
            else
            {
                desconto = 0;
            }
            Console.Write("Seu imposto ficou em {0:f2} R$ por receber {1} R$", desconto, Salario);
            Console.ReadKey();
        }
        static void IMC()
        {
            //Abaixo de 17	Muito abaixo do peso
            //Entre 17 e 18,49	Abaixo do peso
            //Entre 18,5 e 24,99	Peso normal
            //Entre 25 e 29,99	Acima do peso
            //Entre 30 e 34,99	Obesidade I
            //Entre 35 e 39,99	Obesidade II (severa)
            //Acima de 40	Obesidade III (mórbida)
            string situacao =null;
            Console.Write("Peso :");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Altura :");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(altura, 2);
            if (imc > 40)
            {
                situacao = "Obesidade III (mórbida)";
            }
            else if (imc >= 35)
            {
                situacao = "Obesidade II (severa)";
            }
            else if (imc >= 30)
            {
                situacao = "Obesidade I";
            }
            else if (imc >= 25)
            {
                situacao = "Acima do peso";
            }
            else if (imc >= 18.5)
            {
                situacao = "Peso normal";
            }
            else if (imc >= 17)
            {
                situacao = "Abaixo do peso";
            }
            else if (imc < 17)
            {
                situacao = "Muito abaixo do peso";
            }
            Console.WriteLine("Situacao :{0}\nIMC : {1:f2}",situacao,imc);
            Console.ReadKey();
        }
        static void ArrayAleatorio()
        {
            Random gerador = new Random();
            int sorteio = 0;
            int[] array = new int[20];
            int[] posicao = new int[20];
            for (int i = 0; i < 20; i++)
            {
                sorteio = gerador.Next(0, 100);
                array[i] = sorteio;
                posicao[i] = i;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0} : {1}", posicao[i],array[i] );

            }
            Console.ReadKey();
        }
    }
}
