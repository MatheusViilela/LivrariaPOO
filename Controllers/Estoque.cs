using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Livraria.Models;

namespace Livraria.Controllers
{
    class Estoque
    {
        //`idItem`, `tipo`, `genero`, `titulo`, `autor`, `publicacao`, `editora`, `valor`
        private int idItem;
        private String tipo;
        private String genero;
        private String titulo;
        private String autor;
        private String publicacao;
        private String editora;
        private String valor;
        private Banco banco;

        public Estoque() 
        {
            this.banco = new Banco();
        }

        public MySqlDataReader ListarEstoque()
        {
            return this.banco.Query("SELECT * FROM estoque order by tipo asc");
        }

        public MySqlDataReader ListarEstoque(String campo, String filtro)
        {
            if (filtro == null)
            {
                return ListarEstoque();
            }
            return this.banco.Query("SELECT * FROM estoque where '" + campo + "' = '" + filtro + "'  order by tipo asc");
        }

        public void CadastrarEstoque()
        {
            this.banco.NonQuery("INSERT INTO estoque (`tipo`, `genero`, `titulo`, `autor`, `publicacao`, `editora`, `valor`) +" +
                "VALUES ('" + this.tipo + "','" + this.genero + "','" + this.titulo + "','" + this.autor + "', '"+this.publicacao+"', '"+this.editora+"', '" +this.valor+"')");
        }

        public void EditarEstoque()
        {
            this.banco.NonQuery("UPDATE estoque SET ");
        }

        public void ExcluirCliente()
        {
            this.banco.NonQuery("DELETE FROM ");
        }
        //public void Cadastrar(Estoque data)
        //{
            //MySqlConnection Conexao;

            //string data_source = "datasource=localhost;username=root;password=;database=livraria";
            ////criar conexão com mysql
            //Conexao = new MySqlConnection(data_source);

            //string sql = "INSERT INTO livros (tipo,genero,livron,autor,datap,editora)" +
            //    "VALUES ('" + data.Tipo + "','" + data.Genero + "','" + data.Livron + "', '" + data.Autor + "','" + data.Datap + "','" + data.Editora + "')";

            //MySqlCommand comando = new MySqlCommand(sql, Conexao);

            //// Executar Comando Insert
            //Conexao.Open();

            //comando.ExecuteNonQuery();
            //Conexao.Close();
        //}
        public int IdItem { get => idItem; set => idItem = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Publicacao { get => publicacao; set => publicacao = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Valor { get => valor; set => valor = value; }

        //public string Tipo { get; set; }
        //public string Genero { get; private set; }
        //public string Livron { get; private set; }
        //public string Autor { get; private set; }
        //public string Datap { get; private set; }
        //public string Editora { get; private set; }
      
    }
}
