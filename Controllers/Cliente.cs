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
        //`id`, `nome`, `cpf`, `telefone`, `email`
        private int id;
        private String nome;
        private String cpf;
        private String telefone;
        private String email;
        private Banco banco;

        public Cliente() 
        {
            this.banco = new Banco();
        }

        public MySqlDataReader ListarClientes()
        {
            return this.banco.Query("SELECT * FROM clientes order by nome asc");
        }

        public MySqlDataReader ListarClientes(String campo, String filtro)
        {
            if (filtro == null)
            {
                return ListarClientes();
            }
            return this.banco.Query("SELECT * FROM clientes where '" + campo + "' = '" + filtro + "'  order by nome asc");
        }

        public void CadastrarClientes() 
        {
            this.banco.NonQuery("INSERT INTO clientes (`nome`, `cpf`, `telefone`, `email`) VALUES ('"+this.nome+"','"+this.cpf+"','"+this.telefone+"','"+this.email+"')");
        }

        public void EditarCliente() 
        {
            this.banco.NonQuery("UPDATE clientes SET ");
        }

        public void ExcluirCliente() 
        {
            this.banco.NonQuery("DELETE FROM ");
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public void Cadastrar(Usuario data)
        {
            //MySqlConnection Conexao;

            //string data_source = "datasource=localhost;username=root;password=;database=livraria";
            ////criar conexão com mysql
            //Conexao = new MySqlConnection(data_source);

            //string sql = "INSERT INTO clientes (nome,cpf,telefone,email)" +
            //    "VALUES ('" + data.Nome + "','" + data.CPF + "','" + data.Telefone + "', '" + data.Email + "')";

            //MySqlCommand comando = new MySqlCommand(sql, Conexao);

            //// Executar Comando Insert
            //Conexao.Open();

            //comando.ExecuteNonQuery();
            //Conexao.Close();
        }
    }
}
