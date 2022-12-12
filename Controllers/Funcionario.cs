using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Models;
using MySql.Data.MySqlClient;

namespace Livraria.Controllers
{
    class Funcionario
    {
        //`idFunc`, `nome`, `cpf`, `email`, `senha`
        private int idFunc;
        private String nome;
        private String cpf;
        private String email;
        private String senha;
        private Banco banco;

        public Funcionario()
        {
            this.banco = new Banco();
        }

        public MySqlDataReader ListarFuncionarios()
        {
            return this.banco.Query("SELECT * FROM funcionarios order by nome asc");
        }

        public MySqlDataReader ListarFuncionarios(String campo, String filtro)
        {
            if (filtro == null)
            {
                return ListarFuncionarios();
            }
            return this.banco.Query("SELECT * FROM funcionarios where" + campo + " = '" + filtro + "'  order by nome asc");
        }

        public void CadastrarFuncionario()
        {
            this.banco.NonQuery("INSERT INTO `funcionarios`(`nome`, `cpf`, `email`, `senha`) VALUES ('" + this.nome + "','" + this.cpf + "','" + this.email + "','" + this.senha + "')");
        }

        public void EditarFuncionario()
        {
            this.banco.NonQuery("UPDATE funcionarios SET `nome`='" + this.nome + "',`cpf`='" + this.cpf + "',`email`='" + this.email + "',`senha`='" + this.senha + "' WHERE 'idFunc'='" + this.idFunc + "' ");
        }

        public void ExcluirFuncionario()
        {
            this.banco.NonQuery("DELETE FROM funcionarios WHERE idFunc = '" + this.idFunc + "'");
        }

        public int IdFunc { get => idFunc; set => idFunc = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }

        //public void Cadastrar(Usuario data)
        //{
        //    MySqlConnection Conexao;

        //    string data_source = "datasource=localhost;username=root;password=;database=livraria";
        //    //criar conexão com mysql
        //    Conexao = new MySqlConnection(data_source);

        //    string sql = "INSERT INTO funcionarios (nome,cpf,email,senha)" +
        //        "VALUES ('" + data.Nome + "','" + data.CPF + "','" + data.Email + "', '" + data.Senha + "')";

        //    MySqlCommand comando = new MySqlCommand(sql, Conexao);

        //    // Executar Comando Insert
        //    Conexao.Open();

        //    comando.ExecuteNonQuery();
        //    Conexao.Close();
        //}
    }
}
