using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_6_Complementar
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Programa 1

            int quantidade = 0;
            double valor = 0.30;
            double total = 0;

            Console.Write("Número de maças compradas: ");
            quantidade = int.Parse(Console.ReadLine());
            if (quantidade > 12 || quantidade == 12)
            {
                valor = 0.25;
                total = quantidade * valor;
            }
            else
            {
                total = quantidade * valor;
            }
            Console.Write("Valor total da compra....: {0}", total);
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            //Programa 2

            string senha = null;
            string opcao = null;
            string usuario = null;
            string usuario_cadastrado = null;
            DateTime inscricao = new DateTime();

            Console.Write("Cadastro:");
            Console.Write("\n\nUsuário :");
            usuario_cadastrado = Console.ReadLine();
            Console.Write("\nData de Inscrição ");
            Console.Write("\nAno: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            inscricao.AddDays(dia);
            inscricao.AddYears(ano);
            inscricao.AddMonths(mes);
            DateTime Dia_Atual = DateTime.Now;
            int diferenca = Dia_Atual.Day - inscricao.Day;
            if (diferenca > 15 || diferenca == 15)
            {
                Console.Write("\nSua senha expirou, cadastre uma nova senha: ");
                senha = Console.ReadLine();
            }
            else
            {
                senha = usuario + "123";
            }
            Console.Clear();
            Console.Write("Usuário :");
            usuario = Console.ReadLine();
            Console.Write("Senha: ");
            opcao = Console.ReadLine();
            if (opcao == senha && usuario == usuario_cadastrado)
            {
                Console.Write("\t\tACESSO PERMITIDO");
            }
            else
            {
                Console.Write("\t\tACESSO NEGADO");
            }
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            //Programa 3

            int sexo = 0;
            double peso = 0;
            double altura = 0;
            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("\t\t\tEscolha a opção:\n1 - Homem:\n2 - Mulher: ");
            sexo = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                peso = (62.1 * altura) - 44.7;
            }
            else if (sexo == 2)
            {
                peso = (72.7 * altura) - 58;
            }
            Console.Write("\n\n Peso Ideal...: {0}", peso);
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            //Programa 4

            Random Gol = new Random();
            // Random Gol_Do_Inter = new Random();


            Console.Write("\t\t\t GRENAL...:");
            int Gol_Rodada = Gol.Next(0, 5);
            int Gol_Rodada2 = Gol.Next(0, 5);
            if (Gol_Rodada > Gol_Rodada2)
            {
                Console.Write("\n\n\n\nGrêmio venceu a partida !!!!");
            }
            else if (Gol_Rodada2 > Gol_Rodada)
            {
                Console.Write("\n\n\n\nInter venceu a partida !!!!");
            }
            else if (Gol_Rodada == Gol_Rodada2)
            {
                Console.Write("\n\n\nEmpate, iremos pros penaltis !!!!!!!");
            }
            Console.Write("\n\t\t\tPlacar do Jogo: ");
            Console.Write("\n\nGrêmio ....{0}", Gol_Rodada);
            Console.Write("\n\nInter  ....{0}", Gol_Rodada2);
            Console.ReadKey();


        }

        static void Main6(string[] args)
        {
            //Programa 6
            int[] Codigo = new int[100];
            int[] Idade = new int[100];
            int[] Caixas = new int[100];
            double[] Salario = new double[100];

            Console.Write("Quantos trabalhadores serão contratados: ");
            int total = int.Parse(Console.ReadLine());
            for (int i = 0; i < total; i++)
            {
                Console.Write("Idade: ");
                Idade[i] = int.Parse(Console.ReadLine());
                Codigo[i] = i + 1;
                Console.Write("N° caixas: ");
                Caixas[i] = int.Parse(Console.ReadLine());
                if (Caixas[i] < 6)
                {
                    Salario[i] = Caixas[i] * 2;
                }
                else if (Caixas[i] < 11)
                {
                    Salario[i] = Caixas[i] * 2.50;
                }
                else if (Caixas[i] < 21)
                {
                    Salario[i] = Caixas[i] * 3.50;
                }
                else if (Caixas[i] > 20)
                {
                    Salario[i] = Caixas[i] * 5;
                }
                if (Idade[i] > 18 && Idade[i] < 45)
                {
                    Salario[i] = Salario[i] + Salario[i] * 0.10;
                }
                else if (Idade[i] > 44 && Idade[i] < 66)
                {
                    Salario[i] = Salario[i] + Salario[i] * 0.20;
                }
            }
            Console.Clear();
            for (int i = 0; i < total; i++)
            {
                Console.Write("Codigo..: {0}", Codigo[i]);
                Console.Write("\nIdade..: {0} anos", Idade[i]);
                Console.Write("\nSalário: {0} R$\n\n", Salario[i]);
            }
            Console.ReadKey();


        }

        static void Main(string[] args)
        {
            //Programa 7
            double[] altura = new double[200];
            string[] nome = new string[200];
            double maior = 0;
            int indicador = 0;

            for (int i = 0; i < 200; i++)
            {
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                if (nome[i].ToLower() == "fim")
                {
                    break;
                }
                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maior = altura[i];
                    indicador = i;
                }
                else
                {
                    if (altura[i] > maior)
                    {
                        maior = altura[i];
                        indicador = i;
                    }
                }

            }
            Console.Write("\nNome..: {0}", nome[indicador]);
            Console.Write("\nAltura: {0:f2}", altura[indicador]);
            Console.ReadKey();



        }
    }
}
