﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Livraria.Models;

namespace Livraria.Controllers
{
    class UserLogin
    {
        public void Logar(Usuario data)
        {
            MySqlConnection Conexao;

            string data_source = "datasource=localhost;username=root;password=;database=livraria";
            //criar conexão com mysql
            Conexao = new MySqlConnection(data_source);

            string sql = "SELECT FROM funcionarios (email,senha)" +
                "VALUES ('" + data.Email + "', '" + data.Senha + "')";

            MySqlCommand comando = new MySqlCommand(sql, Conexao);

            // Executar Comando Insert
            Conexao.Open();

            comando.ExecuteNonQuery();
            Conexao.Close();
        }

    }
}
