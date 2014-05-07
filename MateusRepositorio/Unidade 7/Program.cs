using System;
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

        static void Main(string[]args){

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
    }


}

