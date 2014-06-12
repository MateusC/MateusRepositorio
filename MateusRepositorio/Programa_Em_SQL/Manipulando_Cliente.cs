using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Programa_Em_SQL
{
    class Manipulando_Cliente
    {
        public static string SQL_ConnectionString = null;
        public static SqlConnection SQLConnection = new SqlConnection();
        static void Main2(string[] args)
        {
            Conexao();
            Incluir();
            Alterar();
            Deletar();
            Listagem();
            Fechamento();
  

        }
        static void Incluir()
        {
         
            // INSERE PRODUTO

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.Write("Cidade:");
            string cidade = Console.ReadLine();
            Console.Write("Estado:");
            string estado = Console.ReadLine();
            Console.Write("CEP:");
            string cep = Console.ReadLine();
            Console.Write("CPF:");
            string cpf = Console.ReadLine();
            Console.Write("Telefone:");
            string telefone = Console.ReadLine();


            string sqlinsert = string.Format("INSERT INTO Cliente (PrimeiroNome, Sobrenome, Cidade, Estado, CEP, CPF, Telefone) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nome, sobrenome, cidade, estado, cep, cpf, telefone);
            SqlCommand command = new SqlCommand(sqlinsert, SQLConnection);


            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Produto inserido com sucesso!");
                }

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadKey();

            }

        }
        static void Alterar()
        {
 
            // ATUALIZA PRODUTO

            Console.WriteLine("Digite o Id que voce deseja alterar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            string lista = string.Format("SELECT * FROM Cliente WHERE Id = {0}", id);
            SqlCommand listagem = new SqlCommand(lista, SQLConnection);
            SqlDataReader leitura = listagem.ExecuteReader();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            string sqlupdate = string.Format("UPDATE Cliente SET PrimeiroNome = '{0}' WHERE Id = {1}", nome, id);
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            sqlupdate = string.Format("UPDATE Cliente SET Sobrenome = '{0}' WHERE Id = {1}", sobrenome, id);
            Console.Write("Cidade:");
            string cidade = Console.ReadLine();
            sqlupdate = string.Format("UPDATE Cliente SET Cidade = '{0}' WHERE Id = {1}", cidade, id);
            Console.Write("Estado:");
            string estado = Console.ReadLine();
            sqlupdate = string.Format("UPDATE Cliente SET Estado = '{0}' WHERE Id = {1}", estado, id);
            Console.Write("CEP:");
            string cep = Console.ReadLine();
            sqlupdate = string.Format("UPDATE Cliente SET CEP = '{0}' WHERE Id = {1}", cep, id);
            Console.Write("CPF:");
            string cpf = Console.ReadLine();
            sqlupdate = string.Format("UPDATE Cliente SET CPF = '{0}' WHERE Id = {1}", cpf, id);
            Console.Write("Telefone:");
            string telefone = Console.ReadLine();
            sqlupdate = string.Format("UPDATE Cliente SET Telefone = '{0}' WHERE Id = {1}", telefone, id);
            SqlCommand command = new SqlCommand(sqlupdate, SQLConnection);

            try
            {
                int i = command.ExecuteNonQuery();
                Console.WriteLine("Cliente Atualizado com sucesso!");
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        static void Deletar()
        {
        
            // DELETA PRODUTO

            Console.WriteLine("Digite o Id que voce deseja deletar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            string sqldelete = string.Format("DELETE FROM Cliente WHERE Id = {0}", id);
            SqlCommand command = new SqlCommand(sqldelete, SQLConnection);

            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Produto Deletado com sucesso!");
                }

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
    
        }
        static void Listagem()
        {
    
            SqlCommand command = new SqlCommand("SELECT * FROM Cliente", SQLConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["PrimeiroNome"]);
                Console.WriteLine(reader["Sobrenome"]);
                Console.WriteLine(reader["Cidade"]);
                Console.WriteLine(reader["Estado"]);
                Console.WriteLine(reader["CEP"]);
                Console.WriteLine(reader["CPF"]);
                Console.WriteLine(reader["Telefone"]);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
    
        }
        static void Conexao()
        {
            SQL_ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\MateusRepositorio\MateusRepositorio\Unidade_12\DataBase\MateusDB.mdf;Integrated Security=True";

            SqlConnection SQLConnection = new SqlConnection(SQL_ConnectionString);
            //Abrindo a conexão;
            SQLConnection.Open();
        }
        static void Fechamento()
        {
            //Fechando a conexão;
            SQLConnection.Close();
            Console.WriteLine("O Banco de Dados está sendo fechado !");
            Console.ReadKey();
        }
    }
    
}
