using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Unidade_Complementar
{
    class Coleções
    {
        static void Main1(string[] args)
        {
            var Numeros = new List<int>(100);

            for(int i=0;i<100;i++){
                Numeros.Add(i);
            }

            foreach (var lista in Numeros)
            {
                Console.Write(lista + " ");
            }
            Console.ReadKey();
            Console.WriteLine("\n\n\nLista invertida !\n\n\n");
            Console.ReadKey();
            Numeros.Reverse();
            foreach (var lista in Numeros)
            {
                Console.Write(lista + " ");
            }
            Console.ReadKey();

        }
        static void Main2(string[] args)
        {
            var Decimal = new List<double>(80);
            Random gerador = new Random();
            double soma = 0;

            for(int i=0;i<80;i++){
                Decimal.Add(gerador.NextDouble() * 10);
            }
            double menor = Decimal[0];
            double maior = Decimal[0];
            
            for(int i=0;i<80;i++){
                soma += Decimal[i];
                if (Decimal[i] > maior)
                {
                    maior = Decimal[i];
                }

                if (Decimal[i] < menor)
                {
                    menor = Decimal[i];
                }

            }
            foreach (var lista in Decimal)
            {
                Console.Write("{0:F2} ",lista);

            }
            Console.WriteLine("\nMaior : {0:F2}", maior);
            Console.WriteLine("\nMenor : {0:F2}", menor);
            Console.WriteLine("\nSoma : {0:F2}", soma);
            Console.ReadKey();

        }
        static void Main3(string[] args)
        {
            

            Console.WriteLine("Quantos nomes deseja ler ?");
            int Constante = int.Parse(Console.ReadLine());
            var Nomes = new List<string>(Constante);
            for(int i=0;i<Constante;i++){
                Console.WriteLine("Insira um nome: ");
                string nome = Console.ReadLine();
                Nomes.Add(nome);
            }
            Nomes.Sort();
            foreach (var lista in Nomes)
            {
                Console.WriteLine(lista);
            }
            Console.ReadKey();
        }
        static IList<string>IList = new List<string>(){"a","b","c","d"};
        static void Main(string[] args)
        {
            var UmAteDez = new List<int>{1,2,3,4,5,6,7,8,9,10};
            ArrayList UmAteVinte = new ArrayList(20);
            Dictionary<string, string> Dicionario = new Dictionary<string, string>(10);

            Console.WriteLine("\nImprimindo de 1 ate 10 com o List");
            foreach (var lista in UmAteDez)
            {
                Console.Write(lista + " ");
            }
            Console.ReadKey();
            Console.WriteLine("\n\nImprimindo de 1 ate 20 com ArrayList");
            for (int i = 0; i < UmAteVinte.Capacity; i++)
            {
                UmAteVinte.Add(i+1);
                Console.Write(UmAteVinte[i]+" ");
            }
            Console.ReadKey();
            Console.WriteLine("\n\nImprimindo nomes do dicionario");
            Dicionario.Add("Mateus", "Coutinho");
            Dicionario.Add("Greicy", "Matias");
            Dicionario.Add("Rodrigo", "Alves");
            Dicionario.Add("Jorge", "Voltaire");
            foreach (var palavra in Dicionario)
            {
                Console.WriteLine(palavra);
            }
            Console.ReadKey();
            Console.WriteLine("\nImprimindo com o IList");
            foreach (var leia in IList)
            {
                Console.Write(leia + " ");
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            var CopaMundo = new Dictionary<string, char>();
            var times = new List<string>();
            var grupo = new List<char>();

            grupo.Add('A');
            grupo.Add('B');
            grupo.Add('C');
            grupo.Add('D');
            grupo.Add('E');
            grupo.Add('F');
            grupo.Add('G');
            grupo.Add('H');

            times.Add("Croácia");
            times.Add("México");
            times.Add("Camarões");
            times.Add("Brasil");
            times.Add("Espanha");
            times.Add("Holanda");
            times.Add("Chile");
            times.Add("Austrália");
            times.Add("Colômbia");
            times.Add("Grécia");
            times.Add("Costa do Marfim");
            times.Add("Japão");
            times.Add("Uruguai");
            times.Add("Costa Rica");
            times.Add("Inglaterra");
            times.Add("Itália");
            times.Add("Suiça");
            times.Add("Equador");
            times.Add("França");
            times.Add("Honduras");
            times.Add("Argentina");
            times.Add("Nigéria");
            times.Add("Bósnia e Herzegovina");
            times.Add("Irã");
            times.Add("Alemanha");
            times.Add("Portugal");
            times.Add("Estados Unidos");
            times.Add("Gana");
            times.Add("Bélgica");
            times.Add("Argélia");
            times.Add("Rússia");
            times.Add("Coréia do Sul");
            var sorte = new Random();

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    int NumeroTime = sorte.Next(0,times.Count);
                    CopaMundo.Add(times[NumeroTime], grupo[i]);
                    times.Remove(times[NumeroTime]);

                }
            }
            int count = 0;
            foreach (var t in CopaMundo)
            {
                if (count % 4 == 0)
                {
                    Console.WriteLine("\n\n=============\n     GRUPO {0}\n=============", t.Value);
                }
                Console.WriteLine(t.Key);
                count++;
            }
            Console.ReadKey();

        }
    }
}
