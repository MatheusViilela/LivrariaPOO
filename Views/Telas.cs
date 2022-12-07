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
using Livraria.Models;
using Livraria.Controllers;

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
                Usuario cliente = new Usuario(nomeCli.Text, cpfCli.Text, telefoneCli.Text, emailCli.Text);

                Cliente clienteC = new Cliente();

                clienteC.Cadastrar(cliente);
                MessageBox.Show("Cadastrado Com Sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsFun_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario funcionario = new Usuario(nomeFunc.Text, cpfFunc.Text, emailFunc.Text, senhaFunc.Text);

                Funcionario funcionario1= new Funcionario();

                funcionario1.Cadastrar(funcionario);
                MessageBox.Show("Cadastrado Com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void senhaFunc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
