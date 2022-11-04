using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Livraria : Form
    {
        public Livraria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("vitorgaefke@gmail.com") && txtPswd.Text.Equals("12345"))
                {
                    //logar
                } else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                                    "DESCULPE",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }

            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
