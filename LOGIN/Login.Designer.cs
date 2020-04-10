namespace LOGIN
{
    partial class frmLogin
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lnlblCadastro = new System.Windows.Forms.LinkLabel();
            this.txtLogIn = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(65, 299);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 28);
            label1.TabIndex = 1;
            label1.Text = "Log In:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(26, 351);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 28);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(97, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.Location = new System.Drawing.Point(148, 404);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(159, 60);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lnlblCadastro
            // 
            this.lnlblCadastro.AutoSize = true;
            this.lnlblCadastro.Font = new System.Drawing.Font("HP Simplified", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlblCadastro.LinkColor = System.Drawing.Color.White;
            this.lnlblCadastro.Location = new System.Drawing.Point(28, 529);
            this.lnlblCadastro.Name = "lnlblCadastro";
            this.lnlblCadastro.Size = new System.Drawing.Size(218, 13);
            this.lnlblCadastro.TabIndex = 8;
            this.lnlblCadastro.TabStop = true;
            this.lnlblCadastro.Text = "Não possui um LogIn? Clique aqui para criar um!";
            this.lnlblCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlblCadastro_LinkClicked);
            // 
            // txtLogIn
            // 
            this.txtLogIn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLogIn.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogIn.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogIn.Location = new System.Drawing.Point(148, 299);
            this.txtLogIn.Multiline = true;
            this.txtLogIn.Name = "txtLogIn";
            this.txtLogIn.Size = new System.Drawing.Size(159, 28);
            this.txtLogIn.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(148, 351);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 28);
            this.txtPassword.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(405, 569);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogIn);
            this.Controls.Add(this.lnlblCadastro);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel lnlblCadastro;
        private System.Windows.Forms.TextBox txtLogIn;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

