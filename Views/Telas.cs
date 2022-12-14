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
        //MySqlConnection Conexao;
        public Telas()
        {
            InitializeComponent();
            ///    Botões - Estoque 
            btConEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btConEst.FlatAppearance.BorderSize = 0;
            btConEst.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btConEst.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btConEst.BackColor = Color.Transparent;

            btIsnEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btIsnEst.FlatAppearance.BorderSize = 0;
            btIsnEst.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btIsnEst.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btIsnEst.BackColor = Color.Transparent;

            btEdiEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btEdiEst.FlatAppearance.BorderSize = 0;
            btEdiEst.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btEdiEst.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btEdiEst.BackColor = Color.Transparent;

            btExcEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btExcEst.FlatAppearance.BorderSize = 0;
            btExcEst.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btExcEst.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btExcEst.BackColor = Color.Transparent;

            btPesEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btPesEst.FlatAppearance.BorderSize = 0;
            btPesEst.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btPesEst.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btPesEst.BackColor = Color.Transparent;

            ///    Botões - Funcionários
            btConFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btConFun.FlatAppearance.BorderSize = 0;
            btConFun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btConFun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btConFun.BackColor = Color.Transparent;

            btInsFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btInsFun.FlatAppearance.BorderSize = 0;
            btInsFun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btInsFun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btInsFun.BackColor = Color.Transparent;

            btEdiFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btEdiFun.FlatAppearance.BorderSize = 0;
            btEdiFun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btEdiFun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btEdiFun.BackColor = Color.Transparent;

            btExcFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btExcFun.FlatAppearance.BorderSize = 0;
            btExcFun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btExcFun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btExcFun.BackColor = Color.Transparent;

            btPesFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btPesFun.FlatAppearance.BorderSize = 0;
            btPesFun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btPesFun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btPesFun.BackColor = Color.Transparent;

            ///    Botões - Clientes
            btConCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btConCli.FlatAppearance.BorderSize = 0;
            btConCli.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btConCli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btConCli.BackColor = Color.Transparent;

            btInsCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btInsCli.FlatAppearance.BorderSize = 0;
            btInsCli.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btInsCli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btInsCli.BackColor = Color.Transparent;

            btEdiCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btEdiCli.FlatAppearance.BorderSize = 0;
            btEdiCli.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btEdiCli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btEdiCli.BackColor = Color.Transparent;

            btExcCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btExcCli.FlatAppearance.BorderSize = 0;
            btExcCli.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btExcCli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btExcCli.BackColor = Color.Transparent;

            btPesCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btPesCli.FlatAppearance.BorderSize = 0;
            btPesCli.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btPesCli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btPesCli.BackColor = Color.Transparent;

            ///    Botões - Vendas
            btInsVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btInsVen.FlatAppearance.BorderSize = 0;
            btInsVen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btInsVen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btInsVen.BackColor = Color.Transparent;

            btEdiVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btEdiVen.FlatAppearance.BorderSize = 0;
            btEdiVen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btEdiVen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btEdiVen.BackColor = Color.Transparent;

            btExcVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btExcVen.FlatAppearance.BorderSize = 0;
            btExcVen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btExcVen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btExcVen.BackColor = Color.Transparent;

            btCanVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btCanVen.FlatAppearance.BorderSize = 0;
            btCanVen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btCanVen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btCanVen.BackColor = Color.Transparent;

            btFinVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btFinVen.FlatAppearance.BorderSize = 0;
            btFinVen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btFinVen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btFinVen.BackColor = Color.Transparent;
        }

        private Funcionario funcionario;
        private Cliente cliente;
        private Estoque estoque;
        
        private void HOME_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btIsnEst_Click(object sender, EventArgs e)
        {
            try
            {
                this.estoque.Tipo = tipoLivro.Text;
                this.estoque.Genero = generoLivro.Text;
                this.estoque.Titulo = tituloLivro.Text;
                this.estoque.Autor = autorLivro.Text;
                this.estoque.Publicacao = dataLivro.Text;
                this.estoque.Editora = editoraLivro.Text;
                this.estoque.Valor = valorLivro.Text;
                this.estoque.CadastrarEstoque();
                MessageBox.Show("Item cadastrado com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // CADASTRAR
        private void btInsFun_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionario.Nome = nomeFunc.Text;
                this.funcionario.Cpf = cpfFunc.Text;
                this.funcionario.Email = emailFunc.Text;
                this.funcionario.Senha = senhaFunc.Text;
                this.funcionario.CadastrarFuncionario();
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btInsCli_Click(object sender, EventArgs e)
        {
            try
            {
                this.cliente.Nome = nomeCli.Text;
                this.cliente.Cpf = cpfCli.Text;
                this.cliente.Telefone = telefoneCli.Text;
                this.cliente.Email = emailCli.Text;
                this.cliente.CadastrarClientes();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void senhaFunc_TextChanged(object sender, EventArgs e)
        {

        }

        // EDITAR
        private void btEdiEst_Click(object sender, EventArgs e)
        {

        }
        private void valorLivro1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nomeFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhaFuncConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpfFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPesEst_Click(object sender, EventArgs e)
        {

        }

        // CONSULTAR
        private void btConEst_Click(object sender, EventArgs e)
        {
            this.estoque = new Estoque();
            MySqlDataReader temp = this.estoque.ListarEstoque();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridEst.DataSource = dt;
        }
        private void btConFun_Click(object sender, EventArgs e)
        {
            this.funcionario = new Funcionario();
            MySqlDataReader temp = this.funcionario.ListarFuncionarios();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridFun.DataSource = dt;
        }
        private void btConCli_Click(object sender, EventArgs e)
        {
            this.cliente = new Cliente();
            MySqlDataReader temp = this.cliente.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridCli.DataSource = dt;
        }

        private void dtGridFun_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dtGridFun.Rows[e.RowIndex];
            nomeFunc.Text = linha.Cells[1].Value.ToString();
            cpfFunc.Text = linha.Cells[2].Value.ToString();
            emailFunc.Text = linha.Cells[3].Value.ToString();
            senhaFunc.Text = linha.Cells[4].Value.ToString();
            senhaFuncConf.Text = linha.Cells[4].Value.ToString();
        }

        private void dtGridEst_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dtGridEst.Rows[e.RowIndex];
            tipoLivro.Text = linha.Cells[1].Value.ToString();
            generoLivro.Text = linha.Cells[2].Value.ToString();
            tituloLivro.Text = linha.Cells[3].Value.ToString();
            autorLivro.Text = linha.Cells[4].Value.ToString();
            dataLivro.Text = linha.Cells[5].Value.ToString();
            editoraLivro.Text = linha.Cells[6].Value.ToString();
            valorLivro.Text = linha.Cells[7].Value.ToString();
        }

        private void dtGridCli_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dtGridCli.Rows[e.RowIndex];
            nomeCli.Text = linha.Cells[1].Value.ToString();
            cpfCli.Text = linha.Cells[2].Value.ToString();
            telefoneCli.Text = linha.Cells[3].Value.ToString();
            emailCli.Text = linha.Cells[4].Value.ToString();
        }

        private void dtGridNovaVenda_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dtGridFun.Rows[e.RowIndex];
            
        }

        private void btExcFun_Click(object sender, EventArgs e)
        {
            this.funcionario.Nome = nomeFunc.Text;
            this.funcionario.Cpf = cpfFunc.Text;
            this.funcionario.Email = emailFunc.Text;
            this.funcionario.Senha = senhaFunc.Text;
            this.funcionario.ExcluirFuncionario();
            MessageBox.Show("Funcionário exlcuído com sucesso!");
        }
    }
}
