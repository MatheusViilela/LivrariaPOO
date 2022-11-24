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
            this.btExcEst = new System.Windows.Forms.Button();
            this.btEdiEst = new System.Windows.Forms.Button();
            this.btIsnEst = new System.Windows.Forms.Button();
            this.FUNCIONÁRIES = new System.Windows.Forms.TabPage();
            this.CLIENTES = new System.Windows.Forms.TabPage();
            this.VENDAS = new System.Windows.Forms.TabPage();
            this.FUNCIONÁRIOS = new System.Windows.Forms.TabPage();
            this.btPesEst = new System.Windows.Forms.Button();
            this.btPesFun = new System.Windows.Forms.Button();
            this.btInsFun = new System.Windows.Forms.Button();
            this.btEdiFun = new System.Windows.Forms.Button();
            this.btExcFun = new System.Windows.Forms.Button();
            this.btPesCli = new System.Windows.Forms.Button();
            this.btInsCli = new System.Windows.Forms.Button();
            this.btEdiCli = new System.Windows.Forms.Button();
            this.btExcCli = new System.Windows.Forms.Button();
            this.btCanVen = new System.Windows.Forms.Button();
            this.btFinVen = new System.Windows.Forms.Button();
            this.btInsVen = new System.Windows.Forms.Button();
            this.btEdiVen = new System.Windows.Forms.Button();
            this.btExcVen = new System.Windows.Forms.Button();
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
            // btExcEst
            // 
            this.btExcEst.Location = new System.Drawing.Point(764, 583);
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
            // CLIENTES
            // 
            this.CLIENTES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CLIENTES.BackgroundImage")));
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
            // VENDAS
            // 
            this.VENDAS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VENDAS.BackgroundImage")));
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
            // FUNCIONÁRIOS
            // 
            this.FUNCIONÁRIOS.Location = new System.Drawing.Point(4, 22);
            this.FUNCIONÁRIOS.Name = "FUNCIONÁRIOS";
            this.FUNCIONÁRIOS.Size = new System.Drawing.Size(1102, 692);
            this.FUNCIONÁRIOS.TabIndex = 2;
            this.FUNCIONÁRIOS.Text = "tabPage2";
            this.FUNCIONÁRIOS.UseVisualStyleBackColor = true;
            // 
            // btPesEst
            // 
            this.btPesEst.Location = new System.Drawing.Point(859, 239);
            this.btPesEst.Name = "btPesEst";
            this.btPesEst.Size = new System.Drawing.Size(151, 32);
            this.btPesEst.TabIndex = 3;
            this.btPesEst.UseVisualStyleBackColor = true;
            // 
            // btPesFun
            // 
            this.btPesFun.Location = new System.Drawing.Point(833, 233);
            this.btPesFun.Name = "btPesFun";
            this.btPesFun.Size = new System.Drawing.Size(151, 32);
            this.btPesFun.TabIndex = 0;
            this.btPesFun.UseVisualStyleBackColor = true;
            // 
            // btInsFun
            // 
            this.btInsFun.Location = new System.Drawing.Point(181, 579);
            this.btInsFun.Name = "btInsFun";
            this.btInsFun.Size = new System.Drawing.Size(164, 40);
            this.btInsFun.TabIndex = 1;
            this.btInsFun.UseVisualStyleBackColor = true;
            // 
            // btEdiFun
            // 
            this.btEdiFun.Location = new System.Drawing.Point(473, 579);
            this.btEdiFun.Name = "btEdiFun";
            this.btEdiFun.Size = new System.Drawing.Size(164, 40);
            this.btEdiFun.TabIndex = 2;
            this.btEdiFun.UseVisualStyleBackColor = true;
            // 
            // btExcFun
            // 
            this.btExcFun.Location = new System.Drawing.Point(766, 579);
            this.btExcFun.Name = "btExcFun";
            this.btExcFun.Size = new System.Drawing.Size(164, 40);
            this.btExcFun.TabIndex = 3;
            this.btExcFun.UseVisualStyleBackColor = true;
            // 
            // btPesCli
            // 
            this.btPesCli.Location = new System.Drawing.Point(832, 231);
            this.btPesCli.Name = "btPesCli";
            this.btPesCli.Size = new System.Drawing.Size(151, 32);
            this.btPesCli.TabIndex = 0;
            this.btPesCli.UseVisualStyleBackColor = true;
            // 
            // btInsCli
            // 
            this.btInsCli.Location = new System.Drawing.Point(179, 579);
            this.btInsCli.Name = "btInsCli";
            this.btInsCli.Size = new System.Drawing.Size(164, 40);
            this.btInsCli.TabIndex = 1;
            this.btInsCli.UseVisualStyleBackColor = true;
            // 
            // btEdiCli
            // 
            this.btEdiCli.Location = new System.Drawing.Point(473, 579);
            this.btEdiCli.Name = "btEdiCli";
            this.btEdiCli.Size = new System.Drawing.Size(164, 40);
            this.btEdiCli.TabIndex = 2;
            this.btEdiCli.UseVisualStyleBackColor = true;
            // 
            // btExcCli
            // 
            this.btExcCli.Location = new System.Drawing.Point(766, 579);
            this.btExcCli.Name = "btExcCli";
            this.btExcCli.Size = new System.Drawing.Size(164, 40);
            this.btExcCli.TabIndex = 3;
            this.btExcCli.UseVisualStyleBackColor = true;
            // 
            // btCanVen
            // 
            this.btCanVen.Location = new System.Drawing.Point(309, 585);
            this.btCanVen.Name = "btCanVen";
            this.btCanVen.Size = new System.Drawing.Size(125, 42);
            this.btCanVen.TabIndex = 0;
            this.btCanVen.UseVisualStyleBackColor = true;
            // 
            // btFinVen
            // 
            this.btFinVen.Location = new System.Drawing.Point(644, 585);
            this.btFinVen.Name = "btFinVen";
            this.btFinVen.Size = new System.Drawing.Size(125, 42);
            this.btFinVen.TabIndex = 1;
            this.btFinVen.UseVisualStyleBackColor = true;
            // 
            // btInsVen
            // 
            this.btInsVen.Location = new System.Drawing.Point(238, 490);
            this.btInsVen.Name = "btInsVen";
            this.btInsVen.Size = new System.Drawing.Size(118, 32);
            this.btInsVen.TabIndex = 2;
            this.btInsVen.UseVisualStyleBackColor = true;
            // 
            // btEdiVen
            // 
            this.btEdiVen.Location = new System.Drawing.Point(494, 490);
            this.btEdiVen.Name = "btEdiVen";
            this.btEdiVen.Size = new System.Drawing.Size(118, 32);
            this.btEdiVen.TabIndex = 3;
            this.btEdiVen.UseVisualStyleBackColor = true;
            // 
            // btExcVen
            // 
            this.btExcVen.Location = new System.Drawing.Point(749, 490);
            this.btExcVen.Name = "btExcVen";
            this.btExcVen.Size = new System.Drawing.Size(118, 32);
            this.btExcVen.TabIndex = 4;
            this.btExcVen.UseVisualStyleBackColor = true;
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
            this.FUNCIONÁRIES.ResumeLayout(false);
            this.CLIENTES.ResumeLayout(false);
            this.VENDAS.ResumeLayout(false);
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
    }
}