using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_11_Complementar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mega Sena
            Random NumerosSorteados = new Random();
            int[] VetorAposta = new int[6];
            int[] VetorSorteio = new int[6];
            int[] VetorAcerto = new int[6];
            int acertos = 0;
            Console.WriteLine("\t\t\t MEGA SENA !!!!!");
            for (int i = 0; i < 6; i++)
            {
                int Sorteado = NumerosSorteados.Next(01, 61);
                VetorSorteio[i] = Sorteado;
            }
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    Console.WriteLine("Digite um numero para ser sorteado:  (01 até 60)");
                    VetorAposta[i] = int.Parse(Console.ReadLine());
                    if (VetorAposta[i] < 1 || VetorAposta[i] > 60)
                    {
                        Console.WriteLine("Numero fora dos limites, digite novamente (01 até 61)");
                    }
                } while (VetorAposta[i] < 1 || VetorAposta[i] > 60);
                
            }
            OrdemCrecente(VetorSorteio);
            Listagem(VetorSorteio);
            Comparando(VetorSorteio, VetorAposta, VetorAcerto, acertos);
        }
        static void OrdemCrecente(int[] VetorSorteio)
        {
            for (int i = 0; i < VetorSorteio.Length; i++)
            {
                int TrocaTroca = 0;
                for(int j=0;j<VetorSorteio.Length;j++){
                    if (VetorSorteio[i] < VetorSorteio[j])
                    {
                        TrocaTroca = VetorSorteio[i];
                        VetorSorteio[i] = VetorSorteio[j];
                        VetorSorteio[j] = TrocaTroca;
                    }
                }
                
            }
        }
        static void Listagem(int[] VetorSorteio)
        {
            for (int i = 0; i < VetorSorteio.Length; i++)
            {
                Console.Write("[{0}] ", VetorSorteio[i]);
            }
            Console.ReadKey();
        }
        static void Comparando(int[] VetorSorteio, int[] VetorAposta, int[] VetorAcerto,int acertos)
        {
            for (int i = 0; i < VetorSorteio.Length; i++)
            {
                if (VetorAposta[i] == VetorSorteio[i])
                {
                    VetorAcerto[i] = VetorAposta[i];
                    acertos += 1;
                }
            }
            if (acertos == VetorSorteio.Length)
            {
                Console.WriteLine("Voce é o ganhador ! Com {0} acertos !", acertos);
            }
            else if (acertos == VetorSorteio.Length - 1)
            {
                Console.WriteLine("Voce nao completou a carteira, mas ganhou a quina !!!!");
            }
            else
            {
                Console.WriteLine("Voce perdeu, com {0} acertos.", acertos);
            }
            Console.ReadKey();
        }
    }
}
