using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_6
{
    class Program
    {
        static void Main1(string[] args)
        {
           // Programa 1

            int[] vetor = new int[20];
            int contN = 0;
            int contP = 0;
            int cont0 = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Informe um numero: ");
                int x = int.Parse(Console.ReadLine());
                vetor[i] = x;
                if (vetor[i] > 0)
                {
                    contP = contP + 1;
                }
                else if (vetor[i] < 0)
                {
                    contN = contN + 1;
                }
                else
                {
                    cont0 = cont0 + 1;
                }
                

            }
            Console.WriteLine(contP + " numeros positivos.");
            Console.WriteLine(contN + " numeros negativos.");
            Console.WriteLine(cont0 + " numeros nulos(0).");
            Console.ReadKey();

        }

        static void Main2(string[] args)
        {
            //Programa 2
            int [] A = new int[15];
            int [] B = new int[15];
            int[] C = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe um numero: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <15; i++)
            {
                Console.WriteLine("Informe um numero: ");
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int j = 0; j < 15; j++)
            {
                C[j] = A[j] + B[j];
                Console.WriteLine(C[j]);
            }
            
            Console.ReadKey();

        }
        static void Main3(string[] args)
        {
            //Programa 3

            int dia, mes, ano = 0;
            Console.WriteLine("Dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano: ");
            ano = int.Parse(Console.ReadLine());
            data(ano, mes, dia);
        }
        static void data(int d, int m, int a)
        {
            DateTime date = new DateTime(d, m, a);
            Console.WriteLine(date.ToLongDateString());
            Console.ReadKey();
        }
   
        static void Main4(string[] args)
        {
            //Programa 4
            double[] temp = new double[30];
            int contM = 0;

            for (int i = 0; i < 30;i++ )
            {
                Console.WriteLine("Informe a temperatura média do dia " + i);
                temp[i] = double.Parse(Console.ReadLine());
                if (temp[i] > 35)
                {
                    contM = contM + 1;
                }
            }
            Console.WriteLine("Tivemos " + contM + " dias acima dos 35 graus.");
            Console.ReadKey();

        }

        static void Main5(string[] args)
        {
            //Programa 5
            int ano = 0;
            Console.WriteLine("Informe o ano: ");
            ano = int.Parse(Console.ReadLine());
            bissex(ano);

        }
        public static void bissex(int a)
        {
            if (DateTime.IsLeapYear(a))
            {
                   Console.WriteLine("Ano bissexto.");
            }
            else
            {
                Console.WriteLine("Ano não bissexto.");
            }
            Console.ReadKey();
        }

        static void Main6(string[] args)
        {
            //Programa 6
            double[] talao = new double[200];

            Console.Write("Informe o número de parcelas: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor das parcelas: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Já foram paga(s) quantas: ");
            int dec = int.Parse(Console.ReadLine());
            i = i - dec;
            double total = i * valor;
            double total2 = dec * valor;
            Console.WriteLine("Ainda falta ser pago "+total+" R$.");
            Console.WriteLine("Foram pagas " + total2+" parcelas.");
            Console.ReadKey();
        }

        static void Main7(string[] args)
        {
            //Programa 7
            double sal = 675.00;
            double com = 150.00;
            double valor = 0;
            double valort = 0;

            Console.Write("Nome : ");
            string nome = Console.ReadLine();
            Console.Write("Numero de carros vendidos: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Valor do automóvel: ");
                valor = double.Parse(Console.ReadLine());
                valort = valort + valor;
            }
            valort = valort * 0.05;
            sal = sal * 2 + com * qtd + valort;
            Console.WriteLine("Nome : "+nome+"\nSalário: "+sal);
            Console.ReadKey();

        }

        static void Main8(string[] args)
        {
            //Programa 8
            string[] nome = new string[3];
            double[] comissao = new double[3];
            double total = 0;
            double []venda = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nome do " + i + " vendedor: ");
                nome[i] = Console.ReadLine();
                Console.Write("Valor do Imóvel vendido: ");
                venda[i] = double.Parse(Console.ReadLine());
                if (venda[i] > 50000)
                {
                    comissao[i] = venda[i] * 0.12;
                }else if(venda[i]>29999){
                    comissao[i] =venda[i]*0.095;
                }else{
                    comissao[i]=venda[i]*0.07;
                }
                total = total + venda[i];
            }
            Console.Clear();
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("\nNome: " + nome[j] + "\nVenda: " + venda[j] + "\nComissão: " + comissao[j]);


            }
            Console.WriteLine("\nTotal de Vendas da Empresa: "+total);
            Console.ReadKey();
        }

        static void Main9(string[] args)
        {
            //Programa 9

            Console.Write("Digite o valor para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor para C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("A soma de A+B é ....");
            if (a + b > c)
            {
                Console.Write("maior que C.");
            }
            else if (a + b < c)
            {
                Console.Write("menor que C.");
            }
            else
            {
                Console.Write("igual a C.");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Programa 10

            string[] nome = new string[4];
            double[] preco = new double[4];
            double[] precoD = new double[4];
            double total = 0;


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Preço: ");
                preco[i] = double.Parse(Console.ReadLine());
                Console.Write("Desconto:     (em %)");
                double desc = double.Parse(Console.ReadLine());
                precoD[i] = preco[i] - ((preco[i] * desc) / 100);
                total = precoD[i] + total;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n\nProduto..........: " + nome[i]);
                Console.Write("\nPreço............: " + preco[i]);
                Console.Write("\nPreço c/ desconto: "+precoD[i]);
            }
            Console.Write("\n\nTotal ...........: " + total);
            Console.ReadKey();




        }
    }
}
