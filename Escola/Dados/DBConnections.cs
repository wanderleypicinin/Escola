using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using Escola.Dados;

namespace Escola.Dados
{
    public class DBConnections
    {
        //configura o uso da string de conexão
        private static string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        //Criar
        public void Cadastrar(int idalunos, string nome, string email, string telefone)
        {
            try

            {
                MySqlConnection mySqlconnction = DBConnections.GetConnection();
                using MySqlConnection conn = mySqlconnction;

                conn.Open();
                string query = "INSERT INTO alunos (idalunos, nome, email,telefone) VALUES (@idalunos, @nome, @email, @telefone)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idalunos", idalunos);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                string erro = ex.Message.ToString();
            }

        }

    }

}
