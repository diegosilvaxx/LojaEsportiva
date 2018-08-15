namespace LojaArtigosEsportivos
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioLoginLbl = new System.Windows.Forms.Label();
            this.senhaLoginLbl = new System.Windows.Forms.Label();
            this.usuarioLoginTbx = new System.Windows.Forms.TextBox();
            this.senhaLoginTbx = new System.Windows.Forms.TextBox();
            this.logarSistemaBtn = new System.Windows.Forms.Button();
            this.cancelarTelaLoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Acesso";
            // 
            // usuarioLoginLbl
            // 
            this.usuarioLoginLbl.AutoSize = true;
            this.usuarioLoginLbl.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLoginLbl.Location = new System.Drawing.Point(236, 119);
            this.usuarioLoginLbl.Name = "usuarioLoginLbl";
            this.usuarioLoginLbl.Size = new System.Drawing.Size(46, 13);
            this.usuarioLoginLbl.TabIndex = 1;
            this.usuarioLoginLbl.Text = "Usuário:";
            // 
            // senhaLoginLbl
            // 
            this.senhaLoginLbl.AutoSize = true;
            this.senhaLoginLbl.BackColor = System.Drawing.Color.Transparent;
            this.senhaLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLoginLbl.Location = new System.Drawing.Point(244, 184);
            this.senhaLoginLbl.Name = "senhaLoginLbl";
            this.senhaLoginLbl.Size = new System.Drawing.Size(41, 13);
            this.senhaLoginLbl.TabIndex = 2;
            this.senhaLoginLbl.Text = "Senha:";
            // 
            // usuarioLoginTbx
            // 
            this.usuarioLoginTbx.Location = new System.Drawing.Point(288, 115);
            this.usuarioLoginTbx.Name = "usuarioLoginTbx";
            this.usuarioLoginTbx.Size = new System.Drawing.Size(100, 20);
            this.usuarioLoginTbx.TabIndex = 3;
            // 
            // senhaLoginTbx
            // 
            this.senhaLoginTbx.Location = new System.Drawing.Point(288, 181);
            this.senhaLoginTbx.Name = "senhaLoginTbx";
            this.senhaLoginTbx.PasswordChar = '*';
            this.senhaLoginTbx.Size = new System.Drawing.Size(100, 20);
            this.senhaLoginTbx.TabIndex = 4;
            // 
            // logarSistemaBtn
            // 
            this.logarSistemaBtn.BackColor = System.Drawing.Color.Teal;
            this.logarSistemaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logarSistemaBtn.FlatAppearance.BorderSize = 0;
            this.logarSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logarSistemaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logarSistemaBtn.ForeColor = System.Drawing.Color.White;
            this.logarSistemaBtn.Location = new System.Drawing.Point(205, 240);
            this.logarSistemaBtn.Name = "logarSistemaBtn";
            this.logarSistemaBtn.Size = new System.Drawing.Size(112, 32);
            this.logarSistemaBtn.TabIndex = 5;
            this.logarSistemaBtn.Text = "Entrar";
            this.logarSistemaBtn.UseVisualStyleBackColor = false;
            this.logarSistemaBtn.Click += new System.EventHandler(this.logarSistemaBtn_Click);
            // 
            // cancelarTelaLoginBtn
            // 
            this.cancelarTelaLoginBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaLoginBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaLoginBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaLoginBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaLoginBtn.Location = new System.Drawing.Point(349, 240);
            this.cancelarTelaLoginBtn.Name = "cancelarTelaLoginBtn";
            this.cancelarTelaLoginBtn.Size = new System.Drawing.Size(112, 32);
            this.cancelarTelaLoginBtn.TabIndex = 6;
            this.cancelarTelaLoginBtn.Text = "Cancelar";
            this.cancelarTelaLoginBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaLoginBtn.Click += new System.EventHandler(this.cancelarTelaLoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LojaArtigosEsportivos.Properties.Resources.cadeado_login;
            this.pictureBox1.Location = new System.Drawing.Point(38, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AcceptButton = this.logarSistemaBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(524, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelarTelaLoginBtn);
            this.Controls.Add(this.logarSistemaBtn);
            this.Controls.Add(this.senhaLoginTbx);
            this.Controls.Add(this.usuarioLoginTbx);
            this.Controls.Add(this.senhaLoginLbl);
            this.Controls.Add(this.usuarioLoginLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuarioLoginLbl;
        private System.Windows.Forms.Label senhaLoginLbl;
        private System.Windows.Forms.TextBox usuarioLoginTbx;
        private System.Windows.Forms.TextBox senhaLoginTbx;
        private System.Windows.Forms.Button logarSistemaBtn;
        private System.Windows.Forms.Button cancelarTelaLoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}