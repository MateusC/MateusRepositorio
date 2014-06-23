using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Programa_Em_SQL
{
    class Program
    {
    //    static void Main1(string[] args)
    //    {
    //        string SQL_ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\MateusRepositorio\MateusRepositorio\Unidade_12\DataBase\MateusDB.mdf;Integrated Security=True";

    //        SqlConnection SQLConnection = new SqlConnection(SQL_ConnectionString);
    //        //Abrindo a conexão;
    //        SQLConnection.Open();
    //        //Realizar comandos;
    //        //SqlCommand command = new SqlCommand("SELECT * FROM Produto",SQLConnection);

    //        //SqlDataReader reader = command.ExecuteReader();

    //        //while (reader.Read())
    //        //{
    //        //    Console.WriteLine(reader["Nome"]);
    //        //}

    //        // ATUALIZA PRODUTO


    //        //Console.WriteLine("Digite o Id que voce deseja alterar: ");
    //        //int id = Convert.ToInt32(Console.ReadLine());
    //        //Console.WriteLine("Digite o nome do produto: ");
    //        //string nome = Console.ReadLine();
    //        //string sqlupdate =string.Format("UPDATE Produto SET Nome = '{0}' WHERE Id = {1}",nome,id);
    //        //SqlCommand command = new SqlCommand(sqlupdate, SQLConnection);

    //        //try
    //        //{
    //        //    int i = command.ExecuteNonQuery();
    //        //    Console.WriteLine("Produto Atualizado com sucesso!");
    //        //}

    //        //catch (SqlException e)
    //        //{
    //        //    Console.WriteLine(e.ToString());
    //        //}

    //        // DELETA PRODUTO

    //        //Console.WriteLine("Digite o Id que voce deseja deletar: ");
    //        //int id = Convert.ToInt32(Console.ReadLine());

    //        //string sqldelete = string.Format("DELETE FROM Produto WHERE Id = {0}", id);
    //        //SqlCommand command = new SqlCommand(sqldelete, SQLConnection);

    //        //try
    //        //{
    //        //    int i = command.ExecuteNonQuery();
    //        //    if (i > 0)
    //        //    {
    //        //        Console.WriteLine("Produto Deletado com sucesso!");
    //        //    }
                
    //        //}

    //        //catch (SqlException e)
    //        //{
    //        //    Console.WriteLine(e.ToString());
    //        //}

    //        // INSERE PRODUTO

    //        Console.WriteLine("Digite o nome do produto: ");
    //        string nome = Console.ReadLine();
    //        Console.WriteLine("Digite a unidade: ");
    //        string unidade = Console.ReadLine();
    //        Console.WriteLine("Valor:");
    //        float valor = float.Parse(Console.ReadLine());


    //        string sqlinsert = string.Format("INSERT INTO Produto (Nome, Unidade, Valor) values ('{0}','{1}','{2}')",nome,unidade,valor);
    //        SqlCommand command = new SqlCommand(sqlinsert, SQLConnection);


    //        try
    //        {
    //            int i = command.ExecuteNonQuery();
    //            if (i > 0)
    //            {
    //                Console.WriteLine("Produto inserido com sucesso!");
    //            }

    //        }

    //        catch (SqlException e)
    //        {
    //            Console.WriteLine(e.ToString());
    //            Console.ReadKey();

    //        }
           
    //    }
    }
}
