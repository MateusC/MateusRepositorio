using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_Febre_Unidade_IX_e_X
{
    class Program
    {
        static double PorcentagemAdultos = 0;
        static double PorcentagemSexoMasculino = 0;
        static double PorcentagemSexoFeminino = 0;
        static double PorcentagemAltos = 0;
        static int PosicaoMaisBaixo = 0;
        static int PosicaoMaisAlto = 0;
        static int Const = 50;
        static void Main(string[] args)
        {
            Random gerador = new Random();
            string[] Nome = new string[Const];
            int[] Idade = new int[Const];
            int[] Sexo = new int[Const];
            double[] Altura = new double[Const];
            bool[] Adulto = new bool[Const];
            GerarNomes(Nome);
            GerarDados(Idade, Sexo, Altura, gerador, Adulto);
            Comparacao(Idade, Sexo, Altura, Adulto);
            Listagem(Nome, Idade, Sexo, Altura, Adulto);
            Comparacao2(Nome, Idade, Sexo, Altura, Adulto);
            Console.ReadKey();
        }
        static void GerarNomes(string[] Nome)
        {
            for (int i = 0; i < Nome.Length; i++)
            {
                Console.Write("Digite o {0} nome: ", i + 1);
                Nome[i] = Console.ReadLine();
            }
        }
        static void GerarDados(int[] Idade, int[] Sexo, double[] Altura,Random gerador,bool[]Adulto)
        {
            for (int i = 0; i < Sexo.Length; i++)
            {
                PosicaoMaisBaixo = i;
                int num = gerador.Next(1, 90);
                Idade[i] = num;
                num = gerador.Next(0, 2);
                Sexo[i] = num;
                do
                {
                    double num2 = gerador.NextDouble();
                    Altura[i] = num2 * 2;
                } while (Altura[i] < 1.4 || Altura[i] >2.4);
                if (Altura[i] > PosicaoMaisAlto)
                {
                    PosicaoMaisAlto = i;
                }
                if (Altura[i] < PosicaoMaisBaixo)
                {
                    PosicaoMaisBaixo = i;
                }
                if (Idade[i] >= 18)
                {
                    Adulto[i] = true;
                }
                else
                {
                    Adulto[i] = false;
                }
            }
        }
        static void Comparacao(int[] Idade, int[] Sexo, double[] Altura, bool[] Adulto)
        {
            for (int i = 0; i < Sexo.Length; i++)
            {
                if (Adulto[i] == true)
                {
                    PorcentagemAdultos += 1;
                }
                if (Sexo[i] == 0)
                {
                    PorcentagemSexoMasculino += 1;
                }
                else
                {
                    PorcentagemSexoFeminino += 1;
                }
                if (Altura[i] > 1.70)
                {
                    PorcentagemAltos += 1;
                }
                if (Altura[i] > Altura[PosicaoMaisAlto])
                {
                    PosicaoMaisAlto = i;
                }
                if (Altura[i] < Altura[PosicaoMaisBaixo])
                {
                    PosicaoMaisBaixo = i;
                }
            }
            PorcentagemAltos = (PorcentagemAltos * 100) / Altura.Length;
            PorcentagemAdultos = (PorcentagemAdultos * 100) / Adulto.Length;
            PorcentagemSexoFeminino = (PorcentagemSexoFeminino * 100) / Sexo.Length;
            PorcentagemSexoMasculino = (PorcentagemSexoMasculino * 100) / Sexo.Length;
        }
        static void Comparacao2(string[] Nome, int[] Idade, int[] Sexo, double[] Altura, bool[] Adulto)
        {
            string auxNome = null;
            int auxSexo =0;
            double auxAltura = 0;
            bool auxAdulto = true;
            for (int i = 0; i < Idade.Length; i++)
            {
                for (int j = 0; j < Idade.Length; j++)
                {
                    if (Idade[i] > Idade[j])
                    {
                        int aux = Idade[i];
                        Idade[i] = Idade[j];
                        Idade[j] = aux;

                        auxNome = Nome[i];
                        Nome[i] = Nome[j];
                        Nome[j] = auxNome;

                        auxSexo = Sexo[i];
                        Sexo[i] = Sexo[j];
                        Sexo[j] = auxSexo;

                        auxAdulto = Adulto[i];
                        Adulto[i] = Adulto[j];
                        Adulto[j] = auxAdulto;

                        auxAltura = Altura[i];
                        Altura[i] = Altura[j];
                        Altura[j] = auxAltura;

                    }
                }
            }
            Console.WriteLine("\nMais novos !!!");
            for (int i = Const-1; i > Const - 6; i--)
            {
                 char sexo2 = Sexo[i] == 0 ? 'M' : 'F';
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}", Nome[i], Idade[i], sexo2, Adulto[i]);
            }
            Console.WriteLine("\nMais velhos !!!");
            for (int i = 0; i < 10; i++)
            {
                char sexo2 = Sexo[i] == 0 ? 'M' : 'F';
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}", Nome[i], Idade[i], sexo2, Adulto[i]);
            }
        }
        static void Listagem(string[] Nome, int[] Idade, int[] Sexo, double[] Altura, bool[] Adulto)
        {
            char sexo2;
            for (int i = 0; i < Nome.Length; i++)
            {
                sexo2= Sexo[i] == 0 ? 'M' :'F';
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}",Nome[i],Idade[i],sexo2,Adulto[i]);
            }
            Console.WriteLine("\n{0:f2}% de adultos e {1:f2}% de não adultos",PorcentagemAdultos,100 - PorcentagemAdultos);
            Console.WriteLine("{0:f2}% Homens, {1:f2}% Mulheres",PorcentagemSexoMasculino,PorcentagemSexoFeminino);
            Console.WriteLine("{0:f2}% maiores de 1,70m",PorcentagemAltos);
            Console.WriteLine("\nPessoa mais baixa: ");
            sexo2 = Sexo[PosicaoMaisBaixo] == 0 ? 'M' : 'F';
            Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}, Altura {4:f2}", Nome[PosicaoMaisBaixo], Idade[PosicaoMaisBaixo], sexo2, Adulto[PosicaoMaisBaixo],Altura[PosicaoMaisBaixo]);
            Console.WriteLine("\nPessoa mais alta: ");
            sexo2 = Sexo[PosicaoMaisAlto] == 0 ? 'M' : 'F';
            Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}, Altura {4:f2}", Nome[PosicaoMaisAlto], Idade[PosicaoMaisAlto], sexo2, Adulto[PosicaoMaisAlto],Altura[PosicaoMaisAlto]);

            Console.ReadKey();    
            
        }
    }
}
