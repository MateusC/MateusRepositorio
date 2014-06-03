using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_11
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int[] vetor = new int[] { 0, 1, 6, 5, 7, 98, 12, 13, 10, 54 };
            //Programa 1
            AcharMaiorMenorElemento(vetor);
            //Programa 2
            int ResultadoSoma = SomaElementos(vetor);
            Console.WriteLine("Soma: {0}", ResultadoSoma);
            Console.ReadKey();
            //Programa 3
            double ResultadoMedia = MediaElementos(vetor);
            Console.WriteLine("Media: {0}", ResultadoMedia);
            Console.ReadKey();
            //Programa 4
            //Troca foi feita mas eh chamada no Programa 5, OrdenarElementos
            //Programa 5
            OrdenarElementos(vetor);
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
                Console.ReadKey();
        }
        static void AcharMaiorMenorElemento(int [] vetor)
        {
            int PosicaoMaior = 0;
            int PosicaoMenor = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[PosicaoMaior] < vetor[i])
                {
                    PosicaoMaior = i;
                }
                if (vetor[PosicaoMenor] > vetor[i])
                {
                    PosicaoMenor = i;
                }
            }
            Console.WriteLine("Maior numero : {0}", vetor[PosicaoMaior]);
            Console.WriteLine("Menor numero : {0}", vetor[PosicaoMenor]);
            Console.ReadKey();
        }
        static int SomaElementos(int [] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

                return soma;
        }
        static double MediaElementos(int[] vetor)
        {
            double media = SomaElementos(vetor);
            media /= vetor.Length;
            return media;
        }
        static void TrocaElementos(int [] vetor, int i, int j)
        {
            int aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }
        static void OrdenarElementos(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        TrocaElementos(vetor, i, j);
                    }  
                }
            }
        }
    }
    
}
