using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Livraria.Models;

namespace Livraria.Controllers
{
    class Livro
    {
 
        public void Cadastrar(LivroM data)
        {
            MySqlConnection Conexao;

            string data_source = "datasource=localhost;username=root;password=;database=livraria";
            //criar conexão com mysql
            Conexao = new MySqlConnection(data_source);

            string sql = "INSERT INTO livros (tipo,genero,livron,autor,datap,editora)" +
                "VALUES ('" + data.Tipo + "','" + data.Genero + "','" + data.Livron + "', '" + data.Autor + "','" + data.Datap + "','" + data.Editora + "')";

            MySqlCommand comando = new MySqlCommand(sql, Conexao);

            // Executar Comando Insert
            Conexao.Open();

            comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
