﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_7
{
    class Program
    {

        static void MainEx(string[] args)
        {

        
        //static void Main1(string[] args)
        //{
        //    //Programa de Operadores
        //    int a = 0;
        //    a = a + 1;    //soma
        //    int b = 0;
        //    b = a - b;    //subtração
        //    int c = a * b;    //multiplicação
        //    int d = a / b;    // divisão
        //    d = a % b;      //modulo
        //    double Potencia = Math.Pow(5, 3);    //potência
        //    double Raiz = Math.Sqrt(9);          //radiciação
        //    System.Console.WriteLine(a / b);
        //    System.Console.WriteLine((double) c/d); // casting
        //    string oi = "oi";
        //    int dezessete = 17;
        //    string final = oi + dezessete;  // concatenação de string

        //                                             //OPERADORES DE ATRIBUIÇÃO

        //    a = 0;
        //    a += 1; //a = a+1
        //    a -= 1; //a = a-1
        //    a /= 1; //a = a/1
        //    a *= 1; //a = a * 1;
        //    a %= 1; //a= a % 1;
        //    a++;    //a+1  pós-incremento
        //    a--;    //a-1  pós-decremento
        //    ++a;    //a+1  pré-incremento
        //    --a;    //a-1  pré-decremento

        //                                              //OPERADORES RELACIONAIS

        //    if (a > b) { };     // maior que
        //    if (a < b) { };     // menor que
        //    if (a >= b) { };    // maior igual
        //    if (a <= b) { };    // menor igual
        //    if (a == b) { };    // igual a
        //    if (a != b) { };    // diferente de

        //                                              //OPERADORES LÓGICOS

        //    if (a > b & a > c) { };     // "E"   obs: verifica a segunda condição, mesmo a primeira sendo falsa;
        //    if (a < b && a < c) { };    // "E"   
        //    if (a == c | a == b) { };   // "OU"  obs: verifica a segunda condição, mesmo a primeira sendo verdadeira;
        //    if (a != b || a != c) { };  // "OU"
        //    if (a >= b ^ a <= c) { };   // "XOR"  somente a primeira ou somente a segunda, EXCLUSIVAMENTE uma opção apenas;

        //                                              // OPERADOR TERNÁRIO

        //    string resultado = a > 0.9 ? "aprovado" : "reprovado";
        //    Console.WriteLine(a > 0.9 ? "aprovado" : "reprovado");
        //    if (a == c) { };
        //}

        //static void Main(string[] args)
        //{
        //    // Programa com ternários e negação

        //    int a = 1;
        //    int b = 2;

        //    string resultado = a > b ? "A maior que B" : "B maior que A";
        //    Console.WriteLine(resultado);
        //    if (!(a > b))
        //    {
        //        Console.WriteLine("A não é maior que B.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("B não é maior que A.");
        //    }
        //    Console.ReadKey();
        //}
        }

        static void Main1(string[]args){

            //Programa 1

            double MaiorPreco = 0;
            string [] Produtos = new string[15];
            double [] Precos = new double[15];
            double media =0;

            for (int i=0;i<15;i++){
                Console.Write("\nDigite o nome do {0} produto: ",i+1);
                Produtos[i] = Console.ReadLine();
                Console.Write("Valor do produto {0}  : ",Produtos[i]);
                Precos[i]=double.Parse(Console.ReadLine());
                MaiorPreco = Precos[i]>MaiorPreco ? Precos[i]:MaiorPreco;
                media += Precos[i];
            }
            media /= 3;
            Console.WriteLine("\n\n\t\tMedia das Vendas : {0}",media);
            Console.WriteLine("\n\n\t\tPreço mais alto: {0}",MaiorPreco);
            Console.ReadKey();

        }

        static int Main2(string[] args)
        {
            //Programa 2

            int QuantidadeHabitantes = 0;
            int QuantidadeFilhos = 0;
            double MediaFilhos = 0;
            double MediaSalario = 0;
            double MaiorSalario = 0;
            double SalarioMenor = 0;
            double Salario =0;
            do
            {
                Console.Write("Salário ....: ");
                Salario = double.Parse(Console.ReadLine());
                if (Salario < 0 && QuantidadeHabitantes==0)
                {
                    return(0);
                }
                else if (Salario < 0)
                {
                    break;
                }
                MaiorSalario = MaiorSalario > Salario ? MaiorSalario : Salario;
                SalarioMenor = Salario < 150 ? SalarioMenor + 1 : SalarioMenor;
                MediaSalario += Salario;
                do
                {
                    Console.Write("Quantidade de Filhos ...: ");
                    QuantidadeFilhos = int.Parse(Console.ReadLine());
                } while (QuantidadeFilhos <= 0 && QuantidadeFilhos > 10);
                MediaFilhos += QuantidadeFilhos;
                QuantidadeHabitantes += 1;
            } while (Salario > 0);
            MediaFilhos /= QuantidadeHabitantes;
            MediaSalario /= QuantidadeHabitantes;
            SalarioMenor /= QuantidadeHabitantes;
            Console.Write("Media do Salário ....: {0:F2}", MediaSalario);
            Console.Write("\nMedia de Filhos ....: {0:F2}", MediaFilhos);
            Console.Write("\nMaior Salário ......: {0:F2}", MaiorSalario);
            Console.Write("\nPercentual de Salários menores que R$150,00 ...: {0:F2}%", SalarioMenor*100);
            Console.ReadKey();
            return (0);

        }

        static void Main3(string[] args)
        {
            //Programa 3
            int QuantidadeMercadorias = 0;
            double MediaDasMercadorias = 0;
            double ValorEmEstoque = 0;

            Console.Write("N° produtos em estoque ....: ");
            QuantidadeMercadorias = int.Parse(Console.ReadLine());
            for (int i = 0; i < QuantidadeMercadorias; i++)
            {
                Console.Write("Nome : ");
                string Nome = Console.ReadLine();
                Console.Write("Valor : ");
                double valor = double.Parse(Console.ReadLine());
                Console.Write("Quantidade : ");
                int Quantidade = int.Parse(Console.ReadLine());
                ValorEmEstoque += valor * Quantidade;
                MediaDasMercadorias += valor;
                 
            }
            MediaDasMercadorias /=  QuantidadeMercadorias;
            Console.Write    ("Temos {0} tipos de mercadoria em estoque.", QuantidadeMercadorias);
            Console.WriteLine("\nEssas mercadorias totalizam R$ {0:F2}. ", ValorEmEstoque);
            Console.WriteLine("A média dos preços das mercadorias fica em torno de R$ {0:F2}.", MediaDasMercadorias);
            Console.ReadKey();
          
        }
        static void Main4(string[] args)
        {
            // Programa 4

        }

        static void Main5(string[] args)
        {
            // Programa 5
            Random simulados = new Random();
            int[] Dado = new int[6];
            for (int i = 0; i < 100; i++)
            {
                int rolagem = simulados.Next(1, 7);
                Dado[0] = rolagem == 1 ? Dado[0] + 1 : Dado[0];
                Dado[1] = rolagem == 2 ? Dado[1] + 1 : Dado[1];
                Dado[2] = rolagem == 3 ? Dado[2] + 1 : Dado[2];
                Dado[3] = rolagem == 4 ? Dado[3] + 1 : Dado[3];
                Dado[4] = rolagem == 5 ? Dado[4] + 1 : Dado[4];
                Dado[5] = rolagem == 6 ? Dado[5] + 1 : Dado[5];
            }
            Console.WriteLine("Foi rolado 1 {0} vezes.", Dado[0]);
            Console.WriteLine("Foi rolado 2 {0} vezes.", Dado[1]);
            Console.WriteLine("Foi rolado 3 {0} vezes.", Dado[2]);
            Console.WriteLine("Foi rolado 4 {0} vezes.", Dado[3]);
            Console.WriteLine("Foi rolado 5 {0} vezes.", Dado[4]);
            Console.WriteLine("Foi rolado 6 {0} vezes.", Dado[5]);
            Console.ReadKey();
        }
    }


}

