using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Programa_Em_SQL
{
    class Manipulando_Pedido
    {
        public static string SQL_ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\MateusRepositorio\MateusRepositorio\Unidade_12\DataBase\MateusDB.mdf;Integrated Security=True";

        static SqlConnection SQLConnection = new SqlConnection(SQL_ConnectionString);
        static void Main(string[] args)
        {
            
            //Abrindo a conexão;
            SQLConnection.Open();
            Listagem();


             

           
        }
        static void Listagem()
        {

        }
        static void Incluir()
        {
            var dataPedido = DateTime.Now;
            Console.WriteLine("Digite a quantidade de produtos: ");
            var quantidade = int.Parse(Console.ReadLine());
            int produtoId = 3;
            int clienteId = 1;
            string sql = String.Format(@"INSERT INTO Pedido (DataPedido, Quantidade, Produto_Id, Cliente_Id) VALUES ('{0}',{1},{2},{3}", dataPedido, quantidade, produtoId, clienteId);
            SqlCommand insert = new SqlCommand(sql, SQLConnection);

            try
            {
                int i = insert.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Pedido realizado com sucesso");
                }
            }

            catch (SqlException a)
            {
                // Console.WriteLine(a.ToString);
            }
        }
    }
}
