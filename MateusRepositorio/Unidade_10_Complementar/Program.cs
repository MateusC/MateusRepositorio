using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_10_Complementar
{
    class Program
    {
        static int[] idade = new int[20];
        static int maiorIdade = 0;
        static int menorIdade = 200;
        static double mediaIdade = 0;
        static Random idades = new Random();
        static int op = 0;
        static void Main(string[] args)
        {
            
            //Chamar os metodos em ordem

            //AnoBissexto();
            //ValidarData();
            //Idades();
            //InicioTabuada();
        }
        static void AnoBissexto()
        {
            Console.Write("Ano : ");
            int ano = int.Parse(Console.ReadLine());
            if ( ano % 4 == 0 && ano % 100 !=0)
            {
                Console.WriteLine("Ano bissexto.");
            }
            else if (ano % 400 == 0 && ano % 4 == 0) 
            {
                Console.WriteLine("Ano bissexto.");
            }
            else
            {
                Console.WriteLine("Nao bissexto.");
            }
            Console.ReadKey();
        }
        static void ValidarData()
        {
            int ano,dia,mes=0;
            int maxDias=0;
            int bissex =0;
            string mes1 = null;
            do{
                Console.Write("Ano: ");
                ano = int.Parse(Console.ReadLine());
                if (ano < 0 || ano > 4000)
                {
                    Console.WriteLine("Digite o ano valido (0 - 4000)");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (ano < 0 || ano > 4000);
            if ( ano % 4 == 0 && ano % 100 !=0)
            {
                bissex= 1;
            }
            else if (ano % 400 == 0 && ano % 4 == 0) 
            {
                bissex= 1;
            }
            else
            {
                bissex= 0;
            }
            do{
                Console.Write("Mes :");
                mes = int.Parse(Console.ReadLine());
                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Digite um mes valido (1 - 12)");
                    Console.ReadKey();
                    Console.Clear();
                }
                switch(mes){
                       case 1:
                           maxDias =31;
                           mes1 = "janeiro";
                           break;
                       case 2:
                           maxDias =28+bissex;
                           mes1 = "fevereiro";
                           break;
                       case 3:
                           maxDias =31;
                           mes1 = "março";
                           break;
                       case 4:
                           maxDias =30;
                           mes1 = "abril";
                           break;
                       case 5:
                           maxDias =31;
                           mes1 = "maio";
                           break;
                       case 6:
                           maxDias =30;
                           mes1 = "junho";
                           break;
                       case 7:
                           maxDias =31;
                           mes1 = "julho";
                           break;
                       case 8:
                           maxDias =31;
                           mes1 = "agosto";
                           break;
                       case 9:
                           maxDias =30;
                           mes1 = "setembro";
                           break;
                       case 10:
                           maxDias =31;
                           mes1 = "outubro";
                           break;
                       case 11:
                           maxDias =30;
                           mes1 = "novembro";
                           break;
                       case 12:
                           maxDias =31;
                           mes1 = "dezembro";
                           break;
                }
            } while (mes < 1 || mes > 12);
            do
            {
                Console.Write("Dia: ");
                dia = int.Parse(Console.ReadLine());
                if (dia < 1 || dia > maxDias)
                {
                    Console.WriteLine("Dia incorreto, preencha novamente por favor.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (dia < 1 || dia > maxDias);
            Console.WriteLine("{0} de {1} de {2}.", dia, mes1, ano);
            Console.ReadKey();
        }
        static void Idades()
        {
            CadastrarIdades();
            MaiorIdade();
            MenorIdade();
            MediaIdade();
            ImprimirIdade();
        }
        static void CadastrarIdades()
        {
            for (int i = 0; i < 20; i++)
            {
                idade[i] = idades.Next(0, 100);
            }
        }
        static void MaiorIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                }
            }
        }
        static void MenorIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                if (idade[i] < menorIdade)
                {
                    menorIdade = idade[i];
                }
            }
        }
        static void MediaIdade()
        {
            for (int i = 0; i < 20; i++)
            {                
                mediaIdade += idade[i];
            }
            mediaIdade /= 20;
        }
        static void ImprimirIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Idade {0} = {1}", i, idade[i]);
            }
            Console.WriteLine("Maior idade : {0}", maiorIdade);
            Console.WriteLine("Menor idade : {0}", menorIdade);
            Console.WriteLine("Media idade : {0:F2}", mediaIdade);
            Console.ReadKey();

        }
        static void InicioTabuada()
        {
            Console.Write("Informe o numero da tabuada :");
            op = int.Parse(Console.ReadLine());
            Tabuada(op);
        }
        static void Tabuada(int x)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", x, i + 1, x * (i + 1));
            }
            Console.ReadKey();
        }
    }
}
