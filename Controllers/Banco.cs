using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Models;
using MySql.Data.MySqlClient;

namespace Livraria.Controllers
{
    internal class Banco
    {
        private String host = "localhost";
        private String nomeBanco = "livraria";
        private String usuario = "root";
        private String senha = "";
        private MySqlConnection con;
        private MySqlCommand command;

        public Banco()
        {
            Conectar();
        }

        public void Conectar()
        {
            String stringCon = "SERVER=" + this.host + ";DATABASE=" + this.nomeBanco + ";UID=" + this.usuario + ";PASSWORD=" + this.senha + ";";
            this.con = new MySqlConnection(stringCon);
            this.command = this.con.CreateCommand();
            this.con.Open();
        }

        // Query - para fazer INSERT, UPDATE (pois não retorna nada)
        public void NonQuery(String sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery();
        }

        // Query - para fazer SELECT
        public MySqlDataReader Query(String sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();
        }
    }
}
