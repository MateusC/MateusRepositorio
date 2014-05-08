using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_Febre_V
{
    class Program
    {
        static void Main7(string[] args)
        {
            // Programa 7

            Console.Write("Idade ...: ");
            int idade = int.Parse(Console.ReadLine());
            string identificacao = idade > 18 ? "Maior de idade" : "Menor de idade";
            Console.Write(identificacao);
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            // Programa 8
            int RegistroValido = 0;
            int RegistroInvalido = 0;
            int Horas = 0;
            int Minutos = 0;
            for (int i=0;i<10;i++){
                Console.Clear();
                Console.WriteLine("Horário de chegada no banco");
                Console.Write("\nHora:");
                Horas = int.Parse(Console.ReadLine());
                Console.Write("Minutos: ");
                Minutos = int.Parse(Console.ReadLine());
                RegistroValido = Horas >= 10 && Horas < 16 ? RegistroValido + 1 : RegistroValido + 0;
                RegistroInvalido = Horas < 10 || Horas >= 16 ? RegistroInvalido + 1 : RegistroInvalido + 0; 
            }
            Console.Clear();
            Console.WriteLine("Pessoas que acessaram o banco......: {0}", RegistroValido);
            Console.WriteLine("Registros Inválidos................: {0}", RegistroInvalido);
            Console.ReadKey();




        }


        static void Main9(string[] args)
        {
            // Programa 9
            string nome = null;
            int Quantidade = 0;
            double preco = 0;
            double desconto = 0;

            Console.Write("\t\t\tNome do produto...........: ");
            nome = Console.ReadLine();
            Console.Write("\t\t\tQuantidade adquirida .....: ");
            Quantidade = int.Parse(Console.ReadLine());
            Console.Write("\t\t\tPreço ....................: ");
            preco = double.Parse(Console.ReadLine());
            double total = Quantidade * preco;
            if (Quantidade <= 5)
            {
                desconto = (total / 100) * 2;
            }
            else if (Quantidade <= 10)
            {
                desconto = (total / 100) * 3;
            }
            else if (Quantidade > 10)
            {
                desconto = (total / 100) * 5;
            }
            Console.Write("\n\n\n\t\t\tTotal............: {0:F2}", total);
            Console.Write("\n\t\t\tDesconto.........: {0:F2}", desconto);
            Console.Write("\n\t\t\tTotal a pagar....: {0:F2}", total - desconto);
            Console.ReadKey();

        }

     
    }
}
