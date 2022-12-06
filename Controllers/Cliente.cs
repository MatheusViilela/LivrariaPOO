using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Models;
using MySql.Data.MySqlClient;

namespace Livraria.Controllers
{
    class Cliente
    {
        public void Cadastrar(Usuario data)
        {
            MySqlConnection Conexao;

            string data_source = "datasource=localhost;username=root;password=;database=livraria";
            //criar conexão com mysql
            Conexao = new MySqlConnection(data_source);

            string sql = "INSERT INTO clientes (nome,cpf,telefone,email)" +
                "VALUES ('" + data.Nome + "','" + data.CPF + "','" + data.Telefone + "', '" + data.Email + "')";

            MySqlCommand comando = new MySqlCommand(sql, Conexao);

            // Executar Comando Insert
            Conexao.Open();

            comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
