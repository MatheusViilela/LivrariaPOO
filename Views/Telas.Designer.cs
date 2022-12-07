namespace Livraria
{
    partial class Telas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HOME = new System.Windows.Forms.TabPage();
            this.ESTOQUE = new System.Windows.Forms.TabPage();
            this.filtroLivro = new System.Windows.Forms.ComboBox();
            this.autorLivro = new System.Windows.Forms.TextBox();
            this.editoraLivro = new System.Windows.Forms.TextBox();
            this.dataLivro = new System.Windows.Forms.TextBox();
            this.tituloLivro = new System.Windows.Forms.TextBox();
            this.generoLivro = new System.Windows.Forms.TextBox();
            this.tipoLivro = new System.Windows.Forms.TextBox();
            this.btPesEst = new System.Windows.Forms.Button();
            this.btExcEst = new System.Windows.Forms.Button();
            this.btEdiEst = new System.Windows.Forms.Button();
            this.btIsnEst = new System.Windows.Forms.Button();
            this.FUNCIONÁRIES = new System.Windows.Forms.TabPage();
            this.senhaFunc = new System.Windows.Forms.TextBox();
            this.cpfFunc = new System.Windows.Forms.TextBox();
            this.senhaFuncConf = new System.Windows.Forms.TextBox();
            this.emailFunc = new System.Windows.Forms.TextBox();
            this.nomeFunc = new System.Windows.Forms.TextBox();
            this.btExcFun = new System.Windows.Forms.Button();
            this.btEdiFun = new System.Windows.Forms.Button();
            this.btInsFun = new System.Windows.Forms.Button();
            this.btPesFun = new System.Windows.Forms.Button();
            this.CLIENTES = new System.Windows.Forms.TabPage();
            this.telefoneCli = new System.Windows.Forms.TextBox();
            this.cpfCli = new System.Windows.Forms.TextBox();
            this.emailCli = new System.Windows.Forms.TextBox();
            this.nomeCli = new System.Windows.Forms.TextBox();
            this.btExcCli = new System.Windows.Forms.Button();
            this.btEdiCli = new System.Windows.Forms.Button();
            this.btInsCli = new System.Windows.Forms.Button();
            this.btPesCli = new System.Windows.Forms.Button();
            this.VENDAS = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btExcVen = new System.Windows.Forms.Button();
            this.btEdiVen = new System.Windows.Forms.Button();
            this.btInsVen = new System.Windows.Forms.Button();
            this.btFinVen = new System.Windows.Forms.Button();
            this.btCanVen = new System.Windows.Forms.Button();
            this.FUNCIONÁRIOS = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.ESTOQUE.SuspendLayout();
            this.FUNCIONÁRIES.SuspendLayout();
            this.CLIENTES.SuspendLayout();
            this.VENDAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HOME);
            this.tabControl1.Controls.Add(this.ESTOQUE);
            this.tabControl1.Controls.Add(this.FUNCIONÁRIES);
            this.tabControl1.Controls.Add(this.CLIENTES);
            this.tabControl1.Controls.Add(this.VENDAS);
            this.tabControl1.ItemSize = new System.Drawing.Size(143, 58);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 726);
            this.tabControl1.TabIndex = 0;
            // 
            // HOME
            // 
            this.HOME.Location = new System.Drawing.Point(4, 62);
            this.HOME.Name = "HOME";
            this.HOME.Padding = new System.Windows.Forms.Padding(3);
            this.HOME.Size = new System.Drawing.Size(1110, 660);
            this.HOME.TabIndex = 0;
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ESTOQUE.BackgroundImage")));
            this.ESTOQUE.Controls.Add(this.filtroLivro);
            this.ESTOQUE.Controls.Add(this.autorLivro);
            this.ESTOQUE.Controls.Add(this.editoraLivro);
            this.ESTOQUE.Controls.Add(this.dataLivro);
            this.ESTOQUE.Controls.Add(this.tituloLivro);
            this.ESTOQUE.Controls.Add(this.generoLivro);
            this.ESTOQUE.Controls.Add(this.tipoLivro);
            this.ESTOQUE.Controls.Add(this.btPesEst);
            this.ESTOQUE.Controls.Add(this.btExcEst);
            this.ESTOQUE.Controls.Add(this.btEdiEst);
            this.ESTOQUE.Controls.Add(this.btIsnEst);
            this.ESTOQUE.Location = new System.Drawing.Point(4, 62);
            this.ESTOQUE.Name = "ESTOQUE";
            this.ESTOQUE.Padding = new System.Windows.Forms.Padding(3);
            this.ESTOQUE.Size = new System.Drawing.Size(1110, 660);
            this.ESTOQUE.TabIndex = 1;
            this.ESTOQUE.Text = "ESTOQUE";
            this.ESTOQUE.UseVisualStyleBackColor = true;
            // 
            // filtroLivro
            // 
            this.filtroLivro.FormattingEnabled = true;
            this.filtroLivro.Location = new System.Drawing.Point(106, 239);
            this.filtroLivro.Name = "filtroLivro";
            this.filtroLivro.Size = new System.Drawing.Size(257, 21);
            this.filtroLivro.TabIndex = 10;
            // 
            // autorLivro
            // 
            this.autorLivro.Location = new System.Drawing.Point(106, 158);
            this.autorLivro.Multiline = true;
            this.autorLivro.Name = "autorLivro";
            this.autorLivro.Size = new System.Drawing.Size(310, 27);
            this.autorLivro.TabIndex = 9;
            this.autorLivro.Text = "Autor...";
            // 
            // editoraLivro
            // 
            this.editoraLivro.Location = new System.Drawing.Point(755, 158);
            this.editoraLivro.Multiline = true;
            this.editoraLivro.Name = "editoraLivro";
            this.editoraLivro.Size = new System.Drawing.Size(246, 27);
            this.editoraLivro.TabIndex = 8;
            this.editoraLivro.Text = "Editora...";
            // 
            // dataLivro
            // 
            this.dataLivro.Location = new System.Drawing.Point(457, 158);
            this.dataLivro.Multiline = true;
            this.dataLivro.Name = "dataLivro";
            this.dataLivro.Size = new System.Drawing.Size(262, 27);
            this.dataLivro.TabIndex = 7;
            this.dataLivro.Text = "Data...";
            // 
            // tituloLivro
            // 
            this.tituloLivro.Location = new System.Drawing.Point(669, 79);
            this.tituloLivro.Multiline = true;
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.Size = new System.Drawing.Size(341, 25);
            this.tituloLivro.TabIndex = 6;
            this.tituloLivro.Text = "Título...";
            // 
            // generoLivro
            // 
            this.generoLivro.Location = new System.Drawing.Point(339, 79);
            this.generoLivro.Multiline = true;
            this.generoLivro.Name = "generoLivro";
            this.generoLivro.Size = new System.Drawing.Size(286, 25);
            this.generoLivro.TabIndex = 5;
            this.generoLivro.Text = "Gênero...";
            // 
            // tipoLivro
            // 
            this.tipoLivro.BackColor = System.Drawing.SystemColors.Window;
            this.tipoLivro.Location = new System.Drawing.Point(106, 79);
            this.tipoLivro.Multiline = true;
            this.tipoLivro.Name = "tipoLivro";
            this.tipoLivro.Size = new System.Drawing.Size(195, 25);
            this.tipoLivro.TabIndex = 4;
            this.tipoLivro.Text = "Tipo...";
            this.tipoLivro.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btPesEst
            // 
            this.btPesEst.Location = new System.Drawing.Point(859, 239);
            this.btPesEst.Name = "btPesEst";
            this.btPesEst.Size = new System.Drawing.Size(151, 32);
            this.btPesEst.TabIndex = 3;
            this.btPesEst.UseVisualStyleBackColor = true;
            // 
            // btExcEst
            // 
            this.btExcEst.Location = new System.Drawing.Point(765, 583);
            this.btExcEst.Name = "btExcEst";
            this.btExcEst.Size = new System.Drawing.Size(164, 41);
            this.btExcEst.TabIndex = 2;
            this.btExcEst.UseVisualStyleBackColor = true;
            // 
            // btEdiEst
            // 
            this.btEdiEst.Location = new System.Drawing.Point(471, 583);
            this.btEdiEst.Name = "btEdiEst";
            this.btEdiEst.Size = new System.Drawing.Size(164, 41);
            this.btEdiEst.TabIndex = 1;
            this.btEdiEst.UseVisualStyleBackColor = true;
            // 
            // btIsnEst
            // 
            this.btIsnEst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btIsnEst.Location = new System.Drawing.Point(177, 583);
            this.btIsnEst.Name = "btIsnEst";
            this.btIsnEst.Size = new System.Drawing.Size(164, 41);
            this.btIsnEst.TabIndex = 0;
            this.btIsnEst.UseVisualStyleBackColor = true;
            this.btIsnEst.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FUNCIONÁRIES
            // 
            this.FUNCIONÁRIES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FUNCIONÁRIES.BackgroundImage")));
            this.FUNCIONÁRIES.Controls.Add(this.senhaFunc);
            this.FUNCIONÁRIES.Controls.Add(this.cpfFunc);
            this.FUNCIONÁRIES.Controls.Add(this.senhaFuncConf);
            this.FUNCIONÁRIES.Controls.Add(this.emailFunc);
            this.FUNCIONÁRIES.Controls.Add(this.nomeFunc);
            this.FUNCIONÁRIES.Controls.Add(this.btExcFun);
            this.FUNCIONÁRIES.Controls.Add(this.btEdiFun);
            this.FUNCIONÁRIES.Controls.Add(this.btInsFun);
            this.FUNCIONÁRIES.Controls.Add(this.btPesFun);
            this.FUNCIONÁRIES.Location = new System.Drawing.Point(4, 62);
            this.FUNCIONÁRIES.Name = "FUNCIONÁRIES";
            this.FUNCIONÁRIES.Size = new System.Drawing.Size(1110, 660);
            this.FUNCIONÁRIES.TabIndex = 2;
            this.FUNCIONÁRIES.Text = "FUNCIONÁRIOS";
            this.FUNCIONÁRIES.UseVisualStyleBackColor = true;
            // 
            // senhaFunc
            // 
            this.senhaFunc.Location = new System.Drawing.Point(563, 161);
            this.senhaFunc.Name = "senhaFunc";
            this.senhaFunc.Size = new System.Drawing.Size(183, 20);
            this.senhaFunc.TabIndex = 8;
            this.senhaFunc.UseSystemPasswordChar = true;
            this.senhaFunc.TextChanged += new System.EventHandler(this.senhaFunc_TextChanged);
            // 
            // cpfFunc
            // 
            this.cpfFunc.Location = new System.Drawing.Point(746, 78);
            this.cpfFunc.Multiline = true;
            this.cpfFunc.Name = "cpfFunc";
            this.cpfFunc.Size = new System.Drawing.Size(238, 31);
            this.cpfFunc.TabIndex = 7;
            this.cpfFunc.Text = "CPF...";
            // 
            // senhaFuncConf
            // 
            this.senhaFuncConf.Location = new System.Drawing.Point(780, 161);
            this.senhaFuncConf.Name = "senhaFuncConf";
            this.senhaFuncConf.Size = new System.Drawing.Size(204, 20);
            this.senhaFuncConf.TabIndex = 6;
            this.senhaFuncConf.UseSystemPasswordChar = true;
            // 
            // emailFunc
            // 
            this.emailFunc.Location = new System.Drawing.Point(126, 157);
            this.emailFunc.Multiline = true;
            this.emailFunc.Name = "emailFunc";
            this.emailFunc.Size = new System.Drawing.Size(399, 28);
            this.emailFunc.TabIndex = 5;
            this.emailFunc.Text = "Email...";
            // 
            // nomeFunc
            // 
            this.nomeFunc.Location = new System.Drawing.Point(126, 78);
            this.nomeFunc.Multiline = true;
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.Size = new System.Drawing.Size(581, 31);
            this.nomeFunc.TabIndex = 4;
            this.nomeFunc.Text = "Nome...";
            // 
            // btExcFun
            // 
            this.btExcFun.Location = new System.Drawing.Point(766, 579);
            this.btExcFun.Name = "btExcFun";
            this.btExcFun.Size = new System.Drawing.Size(164, 40);
            this.btExcFun.TabIndex = 3;
            this.btExcFun.UseVisualStyleBackColor = true;
            // 
            // btEdiFun
            // 
            this.btEdiFun.Location = new System.Drawing.Point(473, 579);
            this.btEdiFun.Name = "btEdiFun";
            this.btEdiFun.Size = new System.Drawing.Size(164, 40);
            this.btEdiFun.TabIndex = 2;
            this.btEdiFun.UseVisualStyleBackColor = true;
            // 
            // btInsFun
            // 
            this.btInsFun.Location = new System.Drawing.Point(181, 579);
            this.btInsFun.Name = "btInsFun";
            this.btInsFun.Size = new System.Drawing.Size(164, 40);
            this.btInsFun.TabIndex = 1;
            this.btInsFun.UseVisualStyleBackColor = true;
            this.btInsFun.Click += new System.EventHandler(this.btInsFun_Click);
            // 
            // btPesFun
            // 
            this.btPesFun.Location = new System.Drawing.Point(833, 233);
            this.btPesFun.Name = "btPesFun";
            this.btPesFun.Size = new System.Drawing.Size(151, 32);
            this.btPesFun.TabIndex = 0;
            this.btPesFun.UseVisualStyleBackColor = true;
            // 
            // CLIENTES
            // 
            this.CLIENTES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CLIENTES.BackgroundImage")));
            this.CLIENTES.Controls.Add(this.telefoneCli);
            this.CLIENTES.Controls.Add(this.cpfCli);
            this.CLIENTES.Controls.Add(this.emailCli);
            this.CLIENTES.Controls.Add(this.nomeCli);
            this.CLIENTES.Controls.Add(this.btExcCli);
            this.CLIENTES.Controls.Add(this.btEdiCli);
            this.CLIENTES.Controls.Add(this.btInsCli);
            this.CLIENTES.Controls.Add(this.btPesCli);
            this.CLIENTES.Location = new System.Drawing.Point(4, 62);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(1110, 660);
            this.CLIENTES.TabIndex = 3;
            this.CLIENTES.Text = "CLIENTES";
            this.CLIENTES.UseVisualStyleBackColor = true;
            // 
            // telefoneCli
            // 
            this.telefoneCli.Location = new System.Drawing.Point(732, 159);
            this.telefoneCli.Multiline = true;
            this.telefoneCli.Name = "telefoneCli";
            this.telefoneCli.Size = new System.Drawing.Size(100, 20);
            this.telefoneCli.TabIndex = 7;
            this.telefoneCli.Text = "Telefone...";
            // 
            // cpfCli
            // 
            this.cpfCli.Location = new System.Drawing.Point(732, 79);
            this.cpfCli.Multiline = true;
            this.cpfCli.Name = "cpfCli";
            this.cpfCli.Size = new System.Drawing.Size(100, 20);
            this.cpfCli.TabIndex = 6;
            this.cpfCli.Text = "CPF...";
            // 
            // emailCli
            // 
            this.emailCli.Location = new System.Drawing.Point(126, 159);
            this.emailCli.Multiline = true;
            this.emailCli.Name = "emailCli";
            this.emailCli.Size = new System.Drawing.Size(217, 20);
            this.emailCli.TabIndex = 5;
            this.emailCli.Text = "Email...";
            // 
            // nomeCli
            // 
            this.nomeCli.Location = new System.Drawing.Point(126, 79);
            this.nomeCli.Multiline = true;
            this.nomeCli.Name = "nomeCli";
            this.nomeCli.Size = new System.Drawing.Size(273, 31);
            this.nomeCli.TabIndex = 4;
            this.nomeCli.Text = "Nome...";
            // 
            // btExcCli
            // 
            this.btExcCli.Location = new System.Drawing.Point(766, 579);
            this.btExcCli.Name = "btExcCli";
            this.btExcCli.Size = new System.Drawing.Size(164, 40);
            this.btExcCli.TabIndex = 3;
            this.btExcCli.UseVisualStyleBackColor = true;
            // 
            // btEdiCli
            // 
            this.btEdiCli.Location = new System.Drawing.Point(473, 579);
            this.btEdiCli.Name = "btEdiCli";
            this.btEdiCli.Size = new System.Drawing.Size(164, 40);
            this.btEdiCli.TabIndex = 2;
            this.btEdiCli.UseVisualStyleBackColor = true;
            // 
            // btInsCli
            // 
            this.btInsCli.Location = new System.Drawing.Point(179, 579);
            this.btInsCli.Name = "btInsCli";
            this.btInsCli.Size = new System.Drawing.Size(164, 40);
            this.btInsCli.TabIndex = 1;
            this.btInsCli.UseVisualStyleBackColor = true;
            this.btInsCli.Click += new System.EventHandler(this.btInsCli_Click);
            // 
            // btPesCli
            // 
            this.btPesCli.Location = new System.Drawing.Point(832, 231);
            this.btPesCli.Name = "btPesCli";
            this.btPesCli.Size = new System.Drawing.Size(151, 32);
            this.btPesCli.TabIndex = 0;
            this.btPesCli.UseVisualStyleBackColor = true;
            // 
            // VENDAS
            // 
            this.VENDAS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VENDAS.BackgroundImage")));
            this.VENDAS.Controls.Add(this.textBox7);
            this.VENDAS.Controls.Add(this.textBox6);
            this.VENDAS.Controls.Add(this.textBox5);
            this.VENDAS.Controls.Add(this.textBox4);
            this.VENDAS.Controls.Add(this.textBox3);
            this.VENDAS.Controls.Add(this.textBox2);
            this.VENDAS.Controls.Add(this.textBox1);
            this.VENDAS.Controls.Add(this.btExcVen);
            this.VENDAS.Controls.Add(this.btEdiVen);
            this.VENDAS.Controls.Add(this.btInsVen);
            this.VENDAS.Controls.Add(this.btFinVen);
            this.VENDAS.Controls.Add(this.btCanVen);
            this.VENDAS.Location = new System.Drawing.Point(4, 62);
            this.VENDAS.Name = "VENDAS";
            this.VENDAS.Size = new System.Drawing.Size(1110, 660);
            this.VENDAS.TabIndex = 4;
            this.VENDAS.Text = "VENDAS";
            this.VENDAS.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(820, 280);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(644, 280);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(334, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btExcVen
            // 
            this.btExcVen.Location = new System.Drawing.Point(749, 490);
            this.btExcVen.Name = "btExcVen";
            this.btExcVen.Size = new System.Drawing.Size(118, 32);
            this.btExcVen.TabIndex = 4;
            this.btExcVen.UseVisualStyleBackColor = true;
            // 
            // btEdiVen
            // 
            this.btEdiVen.Location = new System.Drawing.Point(494, 490);
            this.btEdiVen.Name = "btEdiVen";
            this.btEdiVen.Size = new System.Drawing.Size(118, 32);
            this.btEdiVen.TabIndex = 3;
            this.btEdiVen.UseVisualStyleBackColor = true;
            // 
            // btInsVen
            // 
            this.btInsVen.Location = new System.Drawing.Point(238, 490);
            this.btInsVen.Name = "btInsVen";
            this.btInsVen.Size = new System.Drawing.Size(118, 32);
            this.btInsVen.TabIndex = 2;
            this.btInsVen.UseVisualStyleBackColor = true;
            // 
            // btFinVen
            // 
            this.btFinVen.Location = new System.Drawing.Point(644, 585);
            this.btFinVen.Name = "btFinVen";
            this.btFinVen.Size = new System.Drawing.Size(125, 42);
            this.btFinVen.TabIndex = 1;
            this.btFinVen.UseVisualStyleBackColor = true;
            // 
            // btCanVen
            // 
            this.btCanVen.Location = new System.Drawing.Point(309, 585);
            this.btCanVen.Name = "btCanVen";
            this.btCanVen.Size = new System.Drawing.Size(125, 42);
            this.btCanVen.TabIndex = 0;
            this.btCanVen.UseVisualStyleBackColor = true;
            // 
            // FUNCIONÁRIOS
            // 
            this.FUNCIONÁRIOS.Location = new System.Drawing.Point(4, 22);
            this.FUNCIONÁRIOS.Name = "FUNCIONÁRIOS";
            this.FUNCIONÁRIOS.Size = new System.Drawing.Size(1102, 692);
            this.FUNCIONÁRIOS.TabIndex = 2;
            this.FUNCIONÁRIOS.Text = "tabPage2";
            this.FUNCIONÁRIOS.UseVisualStyleBackColor = true;
            // 
            // Telas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "Telas";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.ESTOQUE.ResumeLayout(false);
            this.ESTOQUE.PerformLayout();
            this.FUNCIONÁRIES.ResumeLayout(false);
            this.FUNCIONÁRIES.PerformLayout();
            this.CLIENTES.ResumeLayout(false);
            this.CLIENTES.PerformLayout();
            this.VENDAS.ResumeLayout(false);
            this.VENDAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HOME;
        private System.Windows.Forms.TabPage ESTOQUE;
        private System.Windows.Forms.TabPage FUNCIONÁRIES;
        private System.Windows.Forms.TabPage CLIENTES;
        private System.Windows.Forms.TabPage VENDAS;
        private System.Windows.Forms.TabPage FUNCIONÁRIOS;
        private System.Windows.Forms.Button btExcEst;
        private System.Windows.Forms.Button btEdiEst;
        private System.Windows.Forms.Button btIsnEst;
        private System.Windows.Forms.Button btPesEst;
        private System.Windows.Forms.Button btExcFun;
        private System.Windows.Forms.Button btEdiFun;
        private System.Windows.Forms.Button btInsFun;
        private System.Windows.Forms.Button btPesFun;
        private System.Windows.Forms.Button btExcCli;
        private System.Windows.Forms.Button btEdiCli;
        private System.Windows.Forms.Button btInsCli;
        private System.Windows.Forms.Button btPesCli;
        private System.Windows.Forms.Button btExcVen;
        private System.Windows.Forms.Button btEdiVen;
        private System.Windows.Forms.Button btInsVen;
        private System.Windows.Forms.Button btFinVen;
        private System.Windows.Forms.Button btCanVen;
        private System.Windows.Forms.TextBox tipoLivro;
        private System.Windows.Forms.ComboBox filtroLivro;
        private System.Windows.Forms.TextBox autorLivro;
        private System.Windows.Forms.TextBox editoraLivro;
        private System.Windows.Forms.TextBox dataLivro;
        private System.Windows.Forms.TextBox tituloLivro;
        private System.Windows.Forms.TextBox generoLivro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox senhaFunc;
        private System.Windows.Forms.TextBox cpfFunc;
        private System.Windows.Forms.TextBox senhaFuncConf;
        private System.Windows.Forms.TextBox emailFunc;
        private System.Windows.Forms.TextBox nomeFunc;
        private System.Windows.Forms.TextBox telefoneCli;
        private System.Windows.Forms.TextBox cpfCli;
        private System.Windows.Forms.TextBox emailCli;
        private System.Windows.Forms.TextBox nomeCli;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}