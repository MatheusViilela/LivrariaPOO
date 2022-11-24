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
            this.FUNCIONÁRIES = new System.Windows.Forms.TabPage();
            this.CLIENTES = new System.Windows.Forms.TabPage();
            this.VENDAS = new System.Windows.Forms.TabPage();
            this.FUNCIONÁRIOS = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ESTOQUE.SuspendLayout();
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
            this.ESTOQUE.Controls.Add(this.button3);
            this.ESTOQUE.Controls.Add(this.button2);
            this.ESTOQUE.Controls.Add(this.button1);
            this.ESTOQUE.Location = new System.Drawing.Point(4, 62);
            this.ESTOQUE.Name = "ESTOQUE";
            this.ESTOQUE.Padding = new System.Windows.Forms.Padding(3);
            this.ESTOQUE.Size = new System.Drawing.Size(1110, 660);
            this.ESTOQUE.TabIndex = 1;
            this.ESTOQUE.Text = "ESTOQUE";
            this.ESTOQUE.UseVisualStyleBackColor = true;
            // 
            // FUNCIONÁRIES
            // 
            this.FUNCIONÁRIES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FUNCIONÁRIES.BackgroundImage")));
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}