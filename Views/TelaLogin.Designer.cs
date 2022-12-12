namespace Livraria
{
    partial class Livraria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livraria));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btLogin = new System.Windows.Forms.Button();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(695, 550);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(145, 52);
            this.btLogin.TabIndex = 1;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtPswd
            // 
            this.txtPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPswd.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtPswd.Location = new System.Drawing.Point(568, 397);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.Size = new System.Drawing.Size(195, 31);
            this.txtPswd.TabIndex = 2;
            this.txtPswd.Text = "Senha";
            this.txtPswd.UseSystemPasswordChar = true;
            this.txtPswd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.AccessibleDescription = "";
            this.txtUser.AccessibleName = "";
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Tai Le", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtUser.Location = new System.Drawing.Point(565, 297);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(273, 29);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Email";
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 718);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtUser);
            this.Name = "Livraria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.TextBox txtUser;
    }
}

