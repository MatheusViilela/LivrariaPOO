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
            this.dtGridEst = new System.Windows.Forms.DataGridView();
            this.campoFiltroEst = new System.Windows.Forms.TextBox();
            this.valorLivro = new System.Windows.Forms.MaskedTextBox();
            this.btConEst = new System.Windows.Forms.Button();
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
            this.dtGridFun = new System.Windows.Forms.DataGridView();
            this.campoFiltroFun = new System.Windows.Forms.TextBox();
            this.filtroFun = new System.Windows.Forms.ComboBox();
            this.btConFun = new System.Windows.Forms.Button();
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
            this.dtGridCli = new System.Windows.Forms.DataGridView();
            this.filtroCli = new System.Windows.Forms.ComboBox();
            this.campoFiltroCli = new System.Windows.Forms.TextBox();
            this.btConCli = new System.Windows.Forms.Button();
            this.telefoneCli = new System.Windows.Forms.TextBox();
            this.cpfCli = new System.Windows.Forms.TextBox();
            this.emailCli = new System.Windows.Forms.TextBox();
            this.nomeCli = new System.Windows.Forms.TextBox();
            this.btExcCli = new System.Windows.Forms.Button();
            this.btEdiCli = new System.Windows.Forms.Button();
            this.btInsCli = new System.Windows.Forms.Button();
            this.btPesCli = new System.Windows.Forms.Button();
            this.VENDAS = new System.Windows.Forms.TabPage();
            this.dtGridNovaVenda = new System.Windows.Forms.DataGridView();
            this.dataVen = new System.Windows.Forms.MaskedTextBox();
            this.valUniVen = new System.Windows.Forms.TextBox();
            this.qntProVen = new System.Windows.Forms.TextBox();
            this.descProVen = new System.Windows.Forms.TextBox();
            this.codProVen = new System.Windows.Forms.TextBox();
            this.valTotVen = new System.Windows.Forms.TextBox();
            this.nomeVen = new System.Windows.Forms.TextBox();
            this.cliVen = new System.Windows.Forms.TextBox();
            this.btExcVen = new System.Windows.Forms.Button();
            this.btEdiVen = new System.Windows.Forms.Button();
            this.btInsVen = new System.Windows.Forms.Button();
            this.btFinVen = new System.Windows.Forms.Button();
            this.btCanVen = new System.Windows.Forms.Button();
            this.FUNCIONÁRIOS = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.ESTOQUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEst)).BeginInit();
            this.FUNCIONÁRIES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFun)).BeginInit();
            this.CLIENTES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCli)).BeginInit();
            this.VENDAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNovaVenda)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 726);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // HOME
            // 
            this.HOME.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HOME.BackgroundImage")));
            this.HOME.Location = new System.Drawing.Point(4, 62);
            this.HOME.Name = "HOME";
            this.HOME.Padding = new System.Windows.Forms.Padding(3);
            this.HOME.Size = new System.Drawing.Size(1110, 660);
            this.HOME.TabIndex = 0;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ESTOQUE.BackgroundImage")));
            this.ESTOQUE.Controls.Add(this.dtGridEst);
            this.ESTOQUE.Controls.Add(this.campoFiltroEst);
            this.ESTOQUE.Controls.Add(this.valorLivro);
            this.ESTOQUE.Controls.Add(this.btConEst);
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
            // dtGridEst
            // 
            this.dtGridEst.AllowUserToAddRows = false;
            this.dtGridEst.AllowUserToDeleteRows = false;
            this.dtGridEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEst.Location = new System.Drawing.Point(106, 289);
            this.dtGridEst.Name = "dtGridEst";
            this.dtGridEst.Size = new System.Drawing.Size(904, 236);
            this.dtGridEst.TabIndex = 15;
            this.dtGridEst.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridEst_CellMouseDoubleClick);
            // 
            // campoFiltroEst
            // 
            this.campoFiltroEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroEst.Location = new System.Drawing.Point(546, 243);
            this.campoFiltroEst.Multiline = true;
            this.campoFiltroEst.Name = "campoFiltroEst";
            this.campoFiltroEst.Size = new System.Drawing.Size(291, 24);
            this.campoFiltroEst.TabIndex = 14;
            // 
            // valorLivro
            // 
            this.valorLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.valorLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorLivro.Location = new System.Drawing.Point(921, 162);
            this.valorLivro.Mask = "00.00";
            this.valorLivro.Name = "valorLivro";
            this.valorLivro.Size = new System.Drawing.Size(78, 19);
            this.valorLivro.TabIndex = 13;
            // 
            // btConEst
            // 
            this.btConEst.Location = new System.Drawing.Point(111, 573);
            this.btConEst.Name = "btConEst";
            this.btConEst.Size = new System.Drawing.Size(164, 41);
            this.btConEst.TabIndex = 12;
            this.btConEst.UseVisualStyleBackColor = true;
            this.btConEst.Click += new System.EventHandler(this.btConEst_Click);
            // 
            // filtroLivro
            // 
            this.filtroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLivro.FormattingEnabled = true;
            this.filtroLivro.Items.AddRange(new object[] {
            "Tipo do item",
            "Gênero",
            "Título",
            "Autor",
            "Data publicação",
            "Editora",
            "Valor"});
            this.filtroLivro.Location = new System.Drawing.Point(106, 242);
            this.filtroLivro.Name = "filtroLivro";
            this.filtroLivro.Size = new System.Drawing.Size(255, 26);
            this.filtroLivro.TabIndex = 10;
            // 
            // autorLivro
            // 
            this.autorLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.autorLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorLivro.Location = new System.Drawing.Point(113, 165);
            this.autorLivro.Multiline = true;
            this.autorLivro.Name = "autorLivro";
            this.autorLivro.Size = new System.Drawing.Size(246, 20);
            this.autorLivro.TabIndex = 9;
            this.autorLivro.Text = "Autor...";
            // 
            // editoraLivro
            // 
            this.editoraLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.editoraLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editoraLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editoraLivro.Location = new System.Drawing.Point(644, 165);
            this.editoraLivro.Multiline = true;
            this.editoraLivro.Name = "editoraLivro";
            this.editoraLivro.Size = new System.Drawing.Size(225, 19);
            this.editoraLivro.TabIndex = 8;
            this.editoraLivro.Text = "Editora...";
            // 
            // dataLivro
            // 
            this.dataLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLivro.Location = new System.Drawing.Point(404, 165);
            this.dataLivro.Multiline = true;
            this.dataLivro.Name = "dataLivro";
            this.dataLivro.Size = new System.Drawing.Size(192, 20);
            this.dataLivro.TabIndex = 7;
            this.dataLivro.Text = "Data...";
            // 
            // tituloLivro
            // 
            this.tituloLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tituloLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLivro.Location = new System.Drawing.Point(676, 87);
            this.tituloLivro.Multiline = true;
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.Size = new System.Drawing.Size(332, 20);
            this.tituloLivro.TabIndex = 6;
            this.tituloLivro.Text = "Título...";
            // 
            // generoLivro
            // 
            this.generoLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.generoLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoLivro.Location = new System.Drawing.Point(346, 87);
            this.generoLivro.Multiline = true;
            this.generoLivro.Name = "generoLivro";
            this.generoLivro.Size = new System.Drawing.Size(278, 20);
            this.generoLivro.TabIndex = 5;
            this.generoLivro.Text = "Gênero...";
            // 
            // tipoLivro
            // 
            this.tipoLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tipoLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLivro.Location = new System.Drawing.Point(112, 87);
            this.tipoLivro.Multiline = true;
            this.tipoLivro.Name = "tipoLivro";
            this.tipoLivro.Size = new System.Drawing.Size(100, 25);
            this.tipoLivro.TabIndex = 16;
            this.tipoLivro.Text = "Tipo...";
            // 
            // btPesEst
            // 
            this.btPesEst.Location = new System.Drawing.Point(859, 239);
            this.btPesEst.Name = "btPesEst";
            this.btPesEst.Size = new System.Drawing.Size(151, 32);
            this.btPesEst.TabIndex = 3;
            this.btPesEst.UseVisualStyleBackColor = true;
            this.btPesEst.Click += new System.EventHandler(this.btPesEst_Click);
            // 
            // btExcEst
            // 
            this.btExcEst.Location = new System.Drawing.Point(845, 573);
            this.btExcEst.Name = "btExcEst";
            this.btExcEst.Size = new System.Drawing.Size(164, 41);
            this.btExcEst.TabIndex = 2;
            this.btExcEst.UseVisualStyleBackColor = true;
            // 
            // btEdiEst
            // 
            this.btEdiEst.Location = new System.Drawing.Point(601, 573);
            this.btEdiEst.Name = "btEdiEst";
            this.btEdiEst.Size = new System.Drawing.Size(164, 41);
            this.btEdiEst.TabIndex = 1;
            this.btEdiEst.UseVisualStyleBackColor = true;
            this.btEdiEst.Click += new System.EventHandler(this.btEdiEst_Click);
            // 
            // btIsnEst
            // 
            this.btIsnEst.Location = new System.Drawing.Point(356, 573);
            this.btIsnEst.Name = "btIsnEst";
            this.btIsnEst.Size = new System.Drawing.Size(164, 41);
            this.btIsnEst.TabIndex = 0;
            this.btIsnEst.UseVisualStyleBackColor = true;
            this.btIsnEst.Click += new System.EventHandler(this.btIsnEst_Click);
            // 
            // FUNCIONÁRIES
            // 
            this.FUNCIONÁRIES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FUNCIONÁRIES.BackgroundImage")));
            this.FUNCIONÁRIES.Controls.Add(this.dtGridFun);
            this.FUNCIONÁRIES.Controls.Add(this.campoFiltroFun);
            this.FUNCIONÁRIES.Controls.Add(this.filtroFun);
            this.FUNCIONÁRIES.Controls.Add(this.btConFun);
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
            // dtGridFun
            // 
            this.dtGridFun.AllowUserToAddRows = false;
            this.dtGridFun.AllowUserToDeleteRows = false;
            this.dtGridFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFun.Location = new System.Drawing.Point(128, 287);
            this.dtGridFun.Name = "dtGridFun";
            this.dtGridFun.RowHeadersWidth = 60;
            this.dtGridFun.Size = new System.Drawing.Size(856, 236);
            this.dtGridFun.TabIndex = 13;
            this.dtGridFun.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridFun_CellMouseDoubleClick);
            // 
            // campoFiltroFun
            // 
            this.campoFiltroFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroFun.Location = new System.Drawing.Point(519, 237);
            this.campoFiltroFun.Multiline = true;
            this.campoFiltroFun.Name = "campoFiltroFun";
            this.campoFiltroFun.Size = new System.Drawing.Size(284, 25);
            this.campoFiltroFun.TabIndex = 11;
            // 
            // filtroFun
            // 
            this.filtroFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroFun.FormattingEnabled = true;
            this.filtroFun.Items.AddRange(new object[] {
            "id",
            "Nome",
            "CPF",
            "Email"});
            this.filtroFun.Location = new System.Drawing.Point(128, 236);
            this.filtroFun.Name = "filtroFun";
            this.filtroFun.Size = new System.Drawing.Size(254, 26);
            this.filtroFun.TabIndex = 10;
            // 
            // btConFun
            // 
            this.btConFun.Location = new System.Drawing.Point(130, 572);
            this.btConFun.Name = "btConFun";
            this.btConFun.Size = new System.Drawing.Size(164, 40);
            this.btConFun.TabIndex = 9;
            this.btConFun.UseVisualStyleBackColor = true;
            this.btConFun.Click += new System.EventHandler(this.btConFun_Click);
            // 
            // senhaFunc
            // 
            this.senhaFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.senhaFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaFunc.Location = new System.Drawing.Point(570, 162);
            this.senhaFunc.Multiline = true;
            this.senhaFunc.Name = "senhaFunc";
            this.senhaFunc.Size = new System.Drawing.Size(171, 17);
            this.senhaFunc.TabIndex = 8;
            this.senhaFunc.UseSystemPasswordChar = true;
            this.senhaFunc.TextChanged += new System.EventHandler(this.senhaFunc_TextChanged);
            // 
            // cpfFunc
            // 
            this.cpfFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cpfFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpfFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfFunc.Location = new System.Drawing.Point(753, 83);
            this.cpfFunc.Multiline = true;
            this.cpfFunc.Name = "cpfFunc";
            this.cpfFunc.Size = new System.Drawing.Size(226, 20);
            this.cpfFunc.TabIndex = 7;
            this.cpfFunc.Text = "CPF...";
            this.cpfFunc.TextChanged += new System.EventHandler(this.cpfFunc_TextChanged);
            // 
            // senhaFuncConf
            // 
            this.senhaFuncConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.senhaFuncConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaFuncConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaFuncConf.Location = new System.Drawing.Point(787, 162);
            this.senhaFuncConf.Multiline = true;
            this.senhaFuncConf.Name = "senhaFuncConf";
            this.senhaFuncConf.Size = new System.Drawing.Size(192, 17);
            this.senhaFuncConf.TabIndex = 6;
            this.senhaFuncConf.UseSystemPasswordChar = true;
            this.senhaFuncConf.TextChanged += new System.EventHandler(this.senhaFuncConf_TextChanged);
            // 
            // emailFunc
            // 
            this.emailFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.emailFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailFunc.Location = new System.Drawing.Point(133, 162);
            this.emailFunc.Multiline = true;
            this.emailFunc.Name = "emailFunc";
            this.emailFunc.Size = new System.Drawing.Size(387, 26);
            this.emailFunc.TabIndex = 5;
            this.emailFunc.Text = "Email...";
            this.emailFunc.TextChanged += new System.EventHandler(this.emailFunc_TextChanged);
            // 
            // nomeFunc
            // 
            this.nomeFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.nomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFunc.Location = new System.Drawing.Point(133, 83);
            this.nomeFunc.Multiline = true;
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.Size = new System.Drawing.Size(569, 20);
            this.nomeFunc.TabIndex = 4;
            this.nomeFunc.Text = "Nome...";
            this.nomeFunc.TextChanged += new System.EventHandler(this.nomeFunc_TextChanged);
            // 
            // btExcFun
            // 
            this.btExcFun.Location = new System.Drawing.Point(818, 571);
            this.btExcFun.Name = "btExcFun";
            this.btExcFun.Size = new System.Drawing.Size(164, 40);
            this.btExcFun.TabIndex = 3;
            this.btExcFun.UseVisualStyleBackColor = true;
            this.btExcFun.Click += new System.EventHandler(this.btExcFun_Click);
            // 
            // btEdiFun
            // 
            this.btEdiFun.Location = new System.Drawing.Point(588, 571);
            this.btEdiFun.Name = "btEdiFun";
            this.btEdiFun.Size = new System.Drawing.Size(164, 40);
            this.btEdiFun.TabIndex = 2;
            this.btEdiFun.UseVisualStyleBackColor = true;
            // 
            // btInsFun
            // 
            this.btInsFun.Location = new System.Drawing.Point(359, 571);
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
            this.CLIENTES.Controls.Add(this.dtGridCli);
            this.CLIENTES.Controls.Add(this.filtroCli);
            this.CLIENTES.Controls.Add(this.campoFiltroCli);
            this.CLIENTES.Controls.Add(this.btConCli);
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
            // dtGridCli
            // 
            this.dtGridCli.AllowUserToAddRows = false;
            this.dtGridCli.AllowUserToDeleteRows = false;
            this.dtGridCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCli.Location = new System.Drawing.Point(126, 286);
            this.dtGridCli.Name = "dtGridCli";
            this.dtGridCli.RowHeadersWidth = 50;
            this.dtGridCli.Size = new System.Drawing.Size(857, 238);
            this.dtGridCli.TabIndex = 11;
            this.dtGridCli.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridCli_CellMouseDoubleClick);
            // 
            // filtroCli
            // 
            this.filtroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroCli.FormattingEnabled = true;
            this.filtroCli.Items.AddRange(new object[] {
            "id",
            "Nome",
            "CPF",
            "Email",
            "Telefone"});
            this.filtroCli.Location = new System.Drawing.Point(126, 233);
            this.filtroCli.Name = "filtroCli";
            this.filtroCli.Size = new System.Drawing.Size(256, 26);
            this.filtroCli.TabIndex = 10;
            // 
            // campoFiltroCli
            // 
            this.campoFiltroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFiltroCli.Location = new System.Drawing.Point(517, 236);
            this.campoFiltroCli.Multiline = true;
            this.campoFiltroCli.Name = "campoFiltroCli";
            this.campoFiltroCli.Size = new System.Drawing.Size(290, 24);
            this.campoFiltroCli.TabIndex = 9;
            // 
            // btConCli
            // 
            this.btConCli.Location = new System.Drawing.Point(126, 569);
            this.btConCli.Name = "btConCli";
            this.btConCli.Size = new System.Drawing.Size(164, 40);
            this.btConCli.TabIndex = 8;
            this.btConCli.UseVisualStyleBackColor = true;
            this.btConCli.Click += new System.EventHandler(this.btConCli_Click);
            // 
            // telefoneCli
            // 
            this.telefoneCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.telefoneCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefoneCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneCli.Location = new System.Drawing.Point(739, 161);
            this.telefoneCli.Multiline = true;
            this.telefoneCli.Name = "telefoneCli";
            this.telefoneCli.Size = new System.Drawing.Size(247, 20);
            this.telefoneCli.TabIndex = 7;
            this.telefoneCli.Text = "Telefone...";
            // 
            // cpfCli
            // 
            this.cpfCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cpfCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfCli.Location = new System.Drawing.Point(738, 84);
            this.cpfCli.Multiline = true;
            this.cpfCli.Name = "cpfCli";
            this.cpfCli.Size = new System.Drawing.Size(249, 20);
            this.cpfCli.TabIndex = 6;
            this.cpfCli.Text = "CPF...";
            // 
            // emailCli
            // 
            this.emailCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.emailCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCli.Location = new System.Drawing.Point(133, 161);
            this.emailCli.Multiline = true;
            this.emailCli.Name = "emailCli";
            this.emailCli.Size = new System.Drawing.Size(559, 20);
            this.emailCli.TabIndex = 5;
            this.emailCli.Text = "Email...";
            // 
            // nomeCli
            // 
            this.nomeCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.nomeCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCli.Location = new System.Drawing.Point(132, 83);
            this.nomeCli.Multiline = true;
            this.nomeCli.Name = "nomeCli";
            this.nomeCli.Size = new System.Drawing.Size(553, 20);
            this.nomeCli.TabIndex = 4;
            this.nomeCli.Text = "Nome...";
            // 
            // btExcCli
            // 
            this.btExcCli.Location = new System.Drawing.Point(817, 569);
            this.btExcCli.Name = "btExcCli";
            this.btExcCli.Size = new System.Drawing.Size(164, 40);
            this.btExcCli.TabIndex = 3;
            this.btExcCli.UseVisualStyleBackColor = true;
            // 
            // btEdiCli
            // 
            this.btEdiCli.Location = new System.Drawing.Point(585, 569);
            this.btEdiCli.Name = "btEdiCli";
            this.btEdiCli.Size = new System.Drawing.Size(164, 40);
            this.btEdiCli.TabIndex = 2;
            this.btEdiCli.UseVisualStyleBackColor = true;
            // 
            // btInsCli
            // 
            this.btInsCli.Location = new System.Drawing.Point(356, 569);
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
            this.VENDAS.Controls.Add(this.dtGridNovaVenda);
            this.VENDAS.Controls.Add(this.dataVen);
            this.VENDAS.Controls.Add(this.valUniVen);
            this.VENDAS.Controls.Add(this.qntProVen);
            this.VENDAS.Controls.Add(this.descProVen);
            this.VENDAS.Controls.Add(this.codProVen);
            this.VENDAS.Controls.Add(this.valTotVen);
            this.VENDAS.Controls.Add(this.nomeVen);
            this.VENDAS.Controls.Add(this.cliVen);
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
            // dtGridNovaVenda
            // 
            this.dtGridNovaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridNovaVenda.Location = new System.Drawing.Point(127, 352);
            this.dtGridNovaVenda.Name = "dtGridNovaVenda";
            this.dtGridNovaVenda.Size = new System.Drawing.Size(852, 112);
            this.dtGridNovaVenda.TabIndex = 14;
            this.dtGridNovaVenda.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridNovaVenda_CellMouseDoubleClick);
            // 
            // dataVen
            // 
            this.dataVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVen.Location = new System.Drawing.Point(699, 114);
            this.dataVen.Mask = "00/00/0000";
            this.dataVen.Name = "dataVen";
            this.dataVen.Size = new System.Drawing.Size(116, 20);
            this.dataVen.TabIndex = 13;
            this.dataVen.ValidatingType = typeof(System.DateTime);
            // 
            // valUniVen
            // 
            this.valUniVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.valUniVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valUniVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valUniVen.Location = new System.Drawing.Point(827, 280);
            this.valUniVen.Multiline = true;
            this.valUniVen.Name = "valUniVen";
            this.valUniVen.Size = new System.Drawing.Size(146, 20);
            this.valUniVen.TabIndex = 11;
            // 
            // qntProVen
            // 
            this.qntProVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.qntProVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qntProVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntProVen.Location = new System.Drawing.Point(653, 280);
            this.qntProVen.Multiline = true;
            this.qntProVen.Name = "qntProVen";
            this.qntProVen.Size = new System.Drawing.Size(113, 20);
            this.qntProVen.TabIndex = 10;
            // 
            // descProVen
            // 
            this.descProVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.descProVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descProVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descProVen.Location = new System.Drawing.Point(265, 280);
            this.descProVen.Multiline = true;
            this.descProVen.Name = "descProVen";
            this.descProVen.Size = new System.Drawing.Size(319, 20);
            this.descProVen.TabIndex = 9;
            // 
            // codProVen
            // 
            this.codProVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.codProVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codProVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProVen.Location = new System.Drawing.Point(142, 280);
            this.codProVen.Multiline = true;
            this.codProVen.Name = "codProVen";
            this.codProVen.Size = new System.Drawing.Size(68, 20);
            this.codProVen.TabIndex = 8;
            // 
            // valTotVen
            // 
            this.valTotVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.valTotVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valTotVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTotVen.Location = new System.Drawing.Point(862, 115);
            this.valTotVen.Multiline = true;
            this.valTotVen.Name = "valTotVen";
            this.valTotVen.Size = new System.Drawing.Size(102, 21);
            this.valTotVen.TabIndex = 7;
            // 
            // nomeVen
            // 
            this.nomeVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.nomeVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeVen.Location = new System.Drawing.Point(420, 114);
            this.nomeVen.Multiline = true;
            this.nomeVen.Name = "nomeVen";
            this.nomeVen.Size = new System.Drawing.Size(228, 22);
            this.nomeVen.TabIndex = 6;
            // 
            // cliVen
            // 
            this.cliVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cliVen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cliVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliVen.Location = new System.Drawing.Point(145, 114);
            this.cliVen.Multiline = true;
            this.cliVen.Name = "cliVen";
            this.cliVen.Size = new System.Drawing.Size(227, 22);
            this.cliVen.TabIndex = 5;
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
            this.Text = "TALES AND NOVELS";
            this.tabControl1.ResumeLayout(false);
            this.ESTOQUE.ResumeLayout(false);
            this.ESTOQUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEst)).EndInit();
            this.FUNCIONÁRIES.ResumeLayout(false);
            this.FUNCIONÁRIES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFun)).EndInit();
            this.CLIENTES.ResumeLayout(false);
            this.CLIENTES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCli)).EndInit();
            this.VENDAS.ResumeLayout(false);
            this.VENDAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNovaVenda)).EndInit();
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
        private System.Windows.Forms.TextBox valUniVen;
        private System.Windows.Forms.TextBox qntProVen;
        private System.Windows.Forms.TextBox descProVen;
        private System.Windows.Forms.TextBox codProVen;
        private System.Windows.Forms.TextBox valTotVen;
        private System.Windows.Forms.TextBox nomeVen;
        private System.Windows.Forms.TextBox cliVen;
        private System.Windows.Forms.Button btConEst;
        private System.Windows.Forms.Button btConFun;
        private System.Windows.Forms.Button btConCli;
        private System.Windows.Forms.MaskedTextBox dataVen;
        private System.Windows.Forms.MaskedTextBox valorLivro;
        private System.Windows.Forms.TextBox campoFiltroEst;
        private System.Windows.Forms.TextBox campoFiltroFun;
        private System.Windows.Forms.ComboBox filtroFun;
        private System.Windows.Forms.ComboBox filtroCli;
        private System.Windows.Forms.TextBox campoFiltroCli;
        private System.Windows.Forms.DataGridView dtGridEst;
        private System.Windows.Forms.DataGridView dtGridFun;
        private System.Windows.Forms.DataGridView dtGridCli;
        private System.Windows.Forms.DataGridView dtGridNovaVenda;
        private System.Windows.Forms.TextBox tipoLivro;
    }
}