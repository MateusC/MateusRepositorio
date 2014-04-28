using System;

namespace MateusRepositorio
{
    internal class Unidade_3_Complementar
    {
        private static void Main1(string[] args)
        {
            //Programa 1
            double time = 0;
            double velocidade = 0;
            double Litros_Usados = 0;

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            time = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média durante a viagem: ");
            velocidade = double.Parse(Console.ReadLine());
            double distancia = time * velocidade;
            Litros_Usados = distancia / 12;
            Console.WriteLine("Velocidad Média: " + velocidade);
            Console.WriteLine("Tempo gasto: " + time);
            Console.WriteLine("Distância: " + distancia);
            Console.WriteLine("Litros usados:" + Litros_Usados);
            Console.ReadKey();
        }

        private static void Main2(string[] args)
        {
            //Programa 2
            int x = 0;
            int y = 0;

            Console.WriteLine("Digite o 1 numero: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a potencia que deseja elevar ele:");
            y = int.Parse(Console.ReadLine());
            double total = Math.Pow(x, y);
            double potencia = Potencia(x, y);
            Potencia2(x, y);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        private static void Potencia2(int x, int y)
        {
            double total = Math.Pow(x, y);
        }

        private static double Potencia(int x, int y)
        {
            return Math.Pow(x, y);
        }

        private static void Main3(string[] args)
        {
            // Programa 3
            double x = 0;
            double y = 0;
            double total = 0;
            Console.WriteLine("1 numero: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("2 numero: ");
            y = double.Parse(Console.ReadLine());
            total = (x + y) / 2;
            Console.WriteLine(total);
            Console.ReadKey();
        }

        private static void Main4(string[] args)
        {
            //Programa 4
            Console.WriteLine("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = int.Parse(Console.ReadLine());
            int x = Multi(a, b);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        private static int Multi(int a, int b)
        {
            return a * b;
        }

        private static void Main5(string[] args)
        {
            // Programa 5
            int x = 0;
            Console.WriteLine("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            if (x >= 0)
            {
                if (x == 0)
                {
                    Console.WriteLine(" É nulo.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" É positivo. ");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("É negativo.");
                Console.ReadKey();
            }
        }

        private static void Main6(string[] args)
        {
            //Programa 6
            int idade = 0;
            Console.WriteLine("Idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 4 && idade <= 7)
            {
                Console.WriteLine("Infantil A.");
                Console.ReadKey();
            }
            else if (idade < 10)
            {
                Console.WriteLine("Infantil B.");
                Console.ReadKey();
            }
            else if (idade < 14)
            {
                Console.WriteLine("Juvenil A.");
                Console.ReadKey();
            }
            else if (idade < 18)
            {
                Console.WriteLine("Juvenil B.");
                Console.ReadKey();
            }
            else if (idade < 26)
            {
                Console.WriteLine("Sênior.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Idade não classificada");
            }
        }

        private static void Main7(string[] args)
        {
            // Programa 7
            double total = 0;
            double n100 = 1.10;
            double n101 = 1.30;
            double n102 = 1.50;
            double n105 = 1.00;
            char resp = 'n';
            int resp2 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Faça seu pedido: ");
                Console.WriteLine("100 - Cachorro quente....(R$1,10):");
                Console.WriteLine("101 - Bauru Simples......(R$1,30):");
                Console.WriteLine("102 - Bauru c/ovo........(R$1,50):");
                Console.WriteLine("103 - Hamburguer.........(R$1,10):");
                Console.WriteLine("104 - Chesseburguer......(R$1,30):");
                Console.WriteLine("105 - Refrigerante.......(R$1,00):");
                Console.WriteLine(" ");
                Console.WriteLine("R$ " + total);
                resp2 = int.Parse(Console.ReadLine());
                if (resp2 == 100 || resp2 == 103)
                {
                    total = total + n100;
                }
                else if (resp2 == 101 || resp2 == 104)
                {
                    total = total + n101;
                }
                else if (resp2 == 102)
                {
                    total = total + n102;
                }
                else if (resp2 == 105)
                {
                    total = total + n105;
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                }
                Console.WriteLine("Deseja mais algo:   (s/n)");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 's');
            Console.WriteLine("Total: R$ " + total);
            Console.ReadKey();
        }

        private static void Main8(string[] args)
        {
            //programa 8
            double a = 0;
            double b = 0;
            double res = 0;
            int resp = 0;

            Console.WriteLine("Digite o 1 valor: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 valor: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                res = a + b;
            }
            else if (resp == 2)
            {
                res = a - b;
            }
            else if (resp == 3)
            {
                res = a / b;
            }
            else if (resp == 4)
            {
                res = a * b;
            }

            Console.WriteLine("Resultado: " + res);
            Console.ReadKey();
        }

        private static void Main9(string[] args)
        {
            // Programa 9

            Console.Write("Nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Categoria: ");
            char cat = char.Parse(Console.ReadLine());
            cat = char.ToLower(cat);
            Console.Write("Salário atual: ");
            double salario = double.Parse(Console.ReadLine());
            if (cat == 'a' || cat == 'c' || cat == 'f' || cat == 'h')
            {
                salario = salario + salario * 0.1;
            }
            else if (cat == 'b' || cat == 'd' || cat == 'e' || cat == 'i' || cat == 'j' || cat == 't')
            {
                salario = salario + salario * 0.15;
            }
            else if (cat == 'k' || cat == 'r')
            {
                salario = salario + salario * 0.25;
            }
            else if (cat == 'l' || cat == 'm' || cat == 'n' || cat == 'o' || cat == 'p' || cat == 'q' || cat == 's')
            {
                salario = salario + salario * 0.35;
            }
            else if (cat == 'u' || cat == 'v' || cat == 'x' || cat == 'y' || cat == 'w' || cat == 'z')
            {
                salario = salario * 0.50;
            }

            Console.WriteLine("Nome.................." + nome);
            Console.WriteLine("Categoria............." + cat);
            Console.WriteLine("Salário reajustado...." + salario);
            Console.ReadKey();
        }

        private static void Main10(string[] args)
        {
            //Programa 10
            Console.WriteLine("Digite o lado X do Triângulo: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado Y do Triângulo: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado Z do Triângulo: ");
            double z = double.Parse(Console.ReadLine());

            if (x > y + z || y > x + z || z > x + y)
            {
                Console.WriteLine("Não é um triângulo.");
                Console.ReadKey();
            }
            else if (x == y && y == z)
            {
                Console.WriteLine("Triângulo Equilátero.");
                Console.ReadKey();
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Triângulo Isóscele.");
                Console.ReadKey();
            }
            else if (x != y && y != z || y != x && y != z || z != x && z != y)
            {
                Console.WriteLine("Triângulo Escaleno.");
                Console.ReadKey();
            }
        }
    }
}