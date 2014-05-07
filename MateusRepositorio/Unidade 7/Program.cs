﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa de Operadores
            int a = 0;
            a = a + 1;    //soma
            int b = 0;
            b = a - b;    //subtração
            int c = a * b;    //multiplicação
            int d = a / b;    // divisão
            d = a % b;      //modulo
            double Potencia = Math.Pow(5, 3);    //potência
            double Raiz = Math.Sqrt(9);          //radiciação
            System.Console.WriteLine(a / b);
            System.Console.WriteLine((double) c/d); // casting
            string oi = "oi";
            int dezessete = 17;
            string final = oi + dezessete;  // concatenação de string

                                                     //OPERADORES DE ATRIBUIÇÃO

            a = 0;
            a += 1; //a = a+1
            a -= 1; //a = a-1
            a /= 1; //a = a/1
            a *= 1; //a = a * 1;
            a %= 1; //a= a % 1;
            a++;    //a+1  pós-incremento
            a--;    //a-1  pós-decremento
            ++a;    //a+1  pré-incremento
            --a;    //a-1  pré-decremento

                                                      //OPERADORES RELACIONAIS

            if (a > b) { };     // maior que
            if (a < b) { };     // menor que
            if (a >= b) { };    // maior igual
            if (a <= b) { };    // menor igual
            if (a == b) { };    // igual a
            if (a != b) { };    // diferente de

                                                      //OPERADORES LÓGICOS
            if (a > b & a > c) { };     // "E"   obs: verifica a segunda condição, mesmo a primeira sendo falsa;
            if (a < b && a < c) { };    // "E"   
            if (a == c | a == b) { };   // "OU"  obs: verifica a segunda condição, mesmo a primeira sendo verdadeira;
            if (a != b || a != c) { };  // "OU"
            if (a >= b ^ a <= c) { };   // "XOR"  somente a primeira ou somente a segunda, EXCLUSIVAMENTE uma opção apenas;
        }
    }
}