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
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLogin.BackColor = Color.Transparent;
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
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("vitor") && txtPswd.Text.Equals("12345"))
                {
                    this.Controls.Clear();
                    Telas tl = new Telas();

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
