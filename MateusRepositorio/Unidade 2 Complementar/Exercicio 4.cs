using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio_4
    {
        public static int votos=0;
        public static int votosbranco=0;
        public static int votosnulos=0;
        public static int votostotal=0;
        public static float pvotosnulos=0;
        public static float pvotosbrancos=0;
        public static float pvotos=0;


        static void Main4(string[] args)
        {
            Console.WriteLine("Digite o número de votos: ");
            votos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos em branco: ");
            votosbranco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos nulos: ");
            votosnulos = int.Parse(Console.ReadLine());
            votostotal = votosbranco + votosnulos + votos;
            pvotos= (votos*100)/votostotal;
            pvotosnulos=(votosnulos*100)/votostotal;
            pvotosbrancos = (votosbranco * 100) / votostotal;
            Console.WriteLine("Obtivemos "+pvotos+" dos votos .");
            Console.WriteLine("Obtivemos "+pvotosbrancos+" dos votos em branco .");
            Console.WriteLine("Obtivemos "+ pvotosnulos+" dos votos nulos .");
            Console.ReadKey();

        }


        public static int votosbrancos { get; set; }
    }
}
