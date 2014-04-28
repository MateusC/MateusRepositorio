using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_3
{
    class Unidade_3
    {
        static void Main1(string[] args)
        {
            //Programa 1
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine("Numero maior que 10 !!!");

            }
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            //Programa 2
            Console.WriteLine(" Digite o 1 numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o 2 numero: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("O numero " + a + " é maior.");             
            }
            else
            {
                Console.WriteLine("O numero " + b + " é maior.");
            }
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            //Programa 3
            Console.WriteLine("Digite um valor: ");
            double x = double.Parse(Console.ReadLine());
            if (x > 100 && x < 200)
            {
                Console.WriteLine("O numero está no intervalo de 100 a 200.");
            }
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            //Programa 4
            Console.WriteLine("Nome: ");
            string nome =Console.ReadLine();
            string op = "null";
                Console.WriteLine("Digite a 1 nota: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 2 nota: ");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 3 nota: ");
                double n3 = double.Parse(Console.ReadLine());
                
            
            double media = (n1+n2+n3) / 3;
            if (media >= 7)
            {
                 op = "Aprovado";
            }
            else if (media > 5)
            {
                 op = "Recuperação";
            }
            else
            {
                 op = "Reprovado";
            }
            Console.WriteLine("Nome................: "+nome);
            Console.WriteLine("Média...............: "+media);
            Console.WriteLine("Situação............: "+op);
            Console.ReadKey();
        }

        static void Main5(string[] args)
        {
            //Programa 5
            int cont = 0;
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine("Numero: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 150)
                {
                    cont = cont + 1;
                }
                
            }
            Console.WriteLine("Temos " + cont + " numeros no intervalo de 10 até 150.");
            Console.ReadKey();
        }

        static void Main6(string[] args)
        {
            //Programa 6
            for (int i = 0; i < 75; i++)
            {
                Console.WriteLine("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade >=18) 
                {
                    Console.WriteLine("Maior de idade.");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Menor de idade.");
                    Console.WriteLine(" ");
                }

            }
            Console.ReadKey();
        }

        static void Main7(string[] args)
        {
            //Programa 7
            int contM = 0;
            int contF = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Sexo:    (F/M)");
                char op = char.Parse(Console.ReadLine());
                op = char.ToLower(op);
                if (op == 'f')
                {
                    contF = contF + 1;
                }
                else if (op == 'm')
                {
                    contM = contM + 1;
                }
            }
            Console.Clear();
            Console.WriteLine("Temos " + contM + " homen(s).");
            Console.WriteLine("Temos " + contF + " mulhere(s).");
            Console.ReadKey();

        }

        static void Main8(string[] args)
        {
            //Programa 8
            int ano, cont = 0;
            char opcao = ' ';
            double valor, valortotal, valorfinal, desconto = 0;
            double j = 0;
            do{
                do
                {
                    Console.WriteLine("Informe o valor do carro:");
                    valor=double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o ano do automóvel: ");
                    ano = int.Parse(Console.ReadLine());
                    if (ano<=2000)
                    {
                        desconto = valor*0.12;
                    }else
                    {
                        desconto = valor*0.07;
                    }
                    valorfinal = valor - desconto;
                    Console.WriteLine("Valor do automóvel.........: "+valor);
                    Console.WriteLine("Valor do desconto..........: "+desconto);
                    Console.WriteLine("Valor total do automóvel...: "+valorfinal);
                    Console.WriteLine("Deseja calcular outro carro ?   (S/N)");
                    opcao = char.Parse(Console.ReadLine());
                    opcao = char.ToLower(opcao);
                    cont=cont+1;
                    
                }while(opcao =='s');
                Console.Clear();
                valortotal = valorfinal+j;
                Console.WriteLine("Valor total de compras ......:  "+valortotal);
                Console.WriteLine("Total de carros..............:  "+cont);
                Console.WriteLine("Deseja comprar mais algum carro ? (N/S)  ");
                j = valortotal;
                opcao = char.Parse(Console.ReadLine());
                opcao = char.ToLower(opcao);
            }while(opcao =='s');
        }

        static void Main9(string[] args)
        {
            //Programa 9
            Console.WriteLine("Número de pessoas:");
            int n = int.Parse(Console.ReadLine());
            int napto = 0;
            int apto = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome.......:  ");
                string nome = Console.ReadLine();
                Console.WriteLine("Idade .....:  ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexo.......:      (M/F) ");
                char sexo = char.Parse(Console.ReadLine());
                sexo = char.ToUpper(sexo);
                Console.WriteLine("Saude......:   (B/R/I)  (Boa / Regular/ Insuficiente)  ");
                char saude = char.Parse(Console.ReadLine());
                saude = char.ToUpper(saude);
                if (idade < 18)
                {
                    napto = napto + 1;
                    Console.WriteLine("Não apto.");
                }
                else if (saude == 'i')
                {
                    napto = napto + 1;
                    Console.WriteLine("Não apto.");
                }
                else
                {
                    apto = apto + 1;
                }
            }
            Console.WriteLine("Obtivemos "+apto+" pessoas para servir !");
            Console.WriteLine("Obtivemos " + napto + " pessoas não aptas a servir !");
            Console.ReadKey();
        }

        static void Main10(string[]args)
        {
            //Programa 10
            int i = 0;
            double mediaC = 0;
            double mediaV = 0;
            for (i = 0; i < 40; i++)
            {
                Console.WriteLine("Preço de Compra....: ");
                double precoC = double.Parse(Console.ReadLine());
                Console.WriteLine("Preço de Venda.....: ");
                double precoV = double.Parse(Console.ReadLine());
                double dif = precoV - precoC;
                if (dif > 0)
                {
                    Console.WriteLine("Lucro.");
                }
                else if (dif == 0)
                {
                    Console.WriteLine("Empate.");
                }
                else
                {
                    Console.WriteLine("Prejuízo.");
                }
                mediaC = mediaC + precoC;
                mediaV = mediaV + precoV;
            }
            Console.WriteLine("Média de Preço de Compra....: "+mediaC/40);
            Console.WriteLine("Média de Preço de Venda.....: "+mediaV/40);
            Console.ReadKey();
        }

        static void Main12(string[] args)
        {
            //Programa 12

            Console.Write("Digite um numero:");
            int x = int.Parse(Console.ReadLine());
            if (x > 80 || x < 25 || x == 40)
            {
                Console.WriteLine("BINGOOOOOOOOOOOO!!!");

            }
            Console.ReadKey();
        }

        static void Main13(string[] args)
        {
            //Programa 13

            Console.WriteLine("Digite a quantidade de números:");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Numero:");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("Positivo.");
                }
                else if (num == 0)
                {
                    Console.WriteLine("Nulo.");
                }
                else
                {
                    Console.WriteLine("Negativo");
                }
                
            }
            Console.ReadKey();
        }

        static void Main14(string[] args)
        {
            //Programa 14
            double maior = 0;
            double menor = 0;
            double medio = 0;

            Console.WriteLine("Digite o 1 numero.....: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 1 numero.....: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 1 numero.....: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
            {
                maior = a;
                medio = b;
                menor = c;
            }
            else if (a > b && a > c && c > b)
            {
                medio = c;
                maior = a;
                menor = b;
            }
            else if (b > a && b > c && a > c)
            {
                maior = b;
                medio = a;
                menor = c;
            }
            else if (b > a && b > c && c > a)
            {
                maior = b;
                medio = c;
                menor = a;
            }
            else if (c > a && c > b && a > b)
            {
                maior = c;
                medio = a;
                menor = b;
            }
            else if(c>a && c>b && b>a)
            {
                maior = c;
                medio = b;
                menor = a;
            }
            Console.WriteLine("Qual a opção desejada ..: ");
            Console.WriteLine("1 - Crescente");
            Console.WriteLine("2 - Descrescente");
            Console.WriteLine("3 - Maior no meio");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine(+menor + " " + medio + " " + maior);
            }
            else if (op == 2)
            {
                Console.WriteLine(+maior + " " + medio + " " + menor);
            }
            else if (op == 3)
            {
                Console.WriteLine(+menor + " " + maior + " " + medio);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Programa 15
            int nota100 =0;
            int nota50 =0;
            int nota10 =0;
            int nota5 =0;
            int nota1 = 0;
            Console.WriteLine("Digite o valor:");
            int total = int.Parse(Console.ReadLine());
            do
            {
                if (total > 100)
                {
                  nota100 = total / 100; 
                 total = total - nota100*100;

                }
                else if (total > 50)
                {
                     nota50 = total / 50;
                    total = total - nota50 * 50;
                }
                else if (total > 10)
                {
                     nota10 = total / 10;
                    total = total - nota10 * 10;
                }
                else if (total > 5)
                {
                     nota5 = total / 5;
                    total = total - nota5 * 5;
                }
                else if (total > 1)
                {
                     nota1 = total / 1;
                    total = total - nota1 * 1;
                }

            } while (total != 0);

            Console.WriteLine(+nota100 +" notas de 100 ");
            Console.WriteLine(+nota50 +"  notas de  50");
            Console.WriteLine(+nota10 +"  notas de  10");
            Console.WriteLine(+nota5 +"   notas de  5");
            Console.WriteLine(+nota1 + "  notas de  1");
            Console.ReadKey();
        }




































































































    }

}
