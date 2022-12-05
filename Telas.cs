using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Livraria
{
    public partial class Telas : Form
    {
        MySqlConnection Conexao;
        public Telas()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsCli_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=livraria";
                //criar conexão com mysql
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO clientes (nome,cpf,telefone,email)" +
                    "VALUES ('" +nomeCli.Text+ "','" +cpfCli.Text+ "','" +telefoneCli.Text + "', '"+emailCli.Text+"')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
            
                // Executar Comando Insert
                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastrado Com Sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btInsFun_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=livraria";
                //criar conexão com mysql
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO funcionarios (nome,cpf,email)" +
                    "VALUES ('" + nomeFunc.Text + "','" + cpfFunc.Text + "','" + emailFunc.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                // Executar Comando Insert
                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastrado Com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
