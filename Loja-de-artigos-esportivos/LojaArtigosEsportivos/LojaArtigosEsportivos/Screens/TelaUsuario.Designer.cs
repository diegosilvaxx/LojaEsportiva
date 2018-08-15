namespace LojaArtigosEsportivos
{
    partial class TelaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.avisoLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usuarioLoginCadTbx = new System.Windows.Forms.TextBox();
            this.senhaCadUsuarioTbx = new System.Windows.Forms.TextBox();
            this.repSenhaCadUsuarioTbx = new System.Windows.Forms.TextBox();
            this.nomeCompletoCadTbx = new System.Windows.Forms.TextBox();
            this.cancelarTelaCadUsuarioBtn = new System.Windows.Forms.Button();
            this.salvarCadUsuarioBtn = new System.Windows.Forms.Button();
            this.repSenhaCadLbl = new System.Windows.Forms.Label();
            this.senhaCadLbl = new System.Windows.Forms.Label();
            this.usuarioLoginCadLbl = new System.Windows.Forms.Label();
            this.nomeCompletoCadLbl = new System.Windows.Forms.Label();
            this.pesquisarUsuarioBtn = new System.Windows.Forms.Button();
            this.nomePesquisaUsuarioTbx = new System.Windows.Forms.TextBox();
            this.nomeClientePesqLbl = new System.Windows.Forms.Label();
            this.novoUsuarioBtn = new System.Windows.Forms.Button();
            this.excluirUsuarioBtn = new System.Windows.Forms.Button();
            this.alterarUsuarioBtn = new System.Windows.Forms.Button();
            this.consultaUsuariosGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUsuariosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.avisoLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pesquisarUsuarioBtn);
            this.panel1.Controls.Add(this.nomePesquisaUsuarioTbx);
            this.panel1.Controls.Add(this.nomeClientePesqLbl);
            this.panel1.Controls.Add(this.novoUsuarioBtn);
            this.panel1.Controls.Add(this.excluirUsuarioBtn);
            this.panel1.Controls.Add(this.alterarUsuarioBtn);
            this.panel1.Controls.Add(this.consultaUsuariosGridView);
            this.panel1.Location = new System.Drawing.Point(9, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 476);
            this.panel1.TabIndex = 0;
            // 
            // avisoLbl
            // 
            this.avisoLbl.AutoSize = true;
            this.avisoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoLbl.Location = new System.Drawing.Point(89, 458);
            this.avisoLbl.Name = "avisoLbl";
            this.avisoLbl.Size = new System.Drawing.Size(305, 13);
            this.avisoLbl.TabIndex = 39;
            this.avisoLbl.Text = "[*]Todos os campos com asteriscos são obrigatórios.";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.usuarioLoginCadTbx);
            this.panel2.Controls.Add(this.senhaCadUsuarioTbx);
            this.panel2.Controls.Add(this.repSenhaCadUsuarioTbx);
            this.panel2.Controls.Add(this.nomeCompletoCadTbx);
            this.panel2.Controls.Add(this.cancelarTelaCadUsuarioBtn);
            this.panel2.Controls.Add(this.salvarCadUsuarioBtn);
            this.panel2.Controls.Add(this.repSenhaCadLbl);
            this.panel2.Controls.Add(this.senhaCadLbl);
            this.panel2.Controls.Add(this.usuarioLoginCadLbl);
            this.panel2.Controls.Add(this.nomeCompletoCadLbl);
            this.panel2.Location = new System.Drawing.Point(15, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 137);
            this.panel2.TabIndex = 36;
            // 
            // usuarioLoginCadTbx
            // 
            this.usuarioLoginCadTbx.Location = new System.Drawing.Point(358, 11);
            this.usuarioLoginCadTbx.Name = "usuarioLoginCadTbx";
            this.usuarioLoginCadTbx.Size = new System.Drawing.Size(124, 20);
            this.usuarioLoginCadTbx.TabIndex = 40;
            // 
            // senhaCadUsuarioTbx
            // 
            this.senhaCadUsuarioTbx.Location = new System.Drawing.Point(130, 53);
            this.senhaCadUsuarioTbx.Name = "senhaCadUsuarioTbx";
            this.senhaCadUsuarioTbx.PasswordChar = '*';
            this.senhaCadUsuarioTbx.Size = new System.Drawing.Size(124, 20);
            this.senhaCadUsuarioTbx.TabIndex = 41;
            // 
            // repSenhaCadUsuarioTbx
            // 
            this.repSenhaCadUsuarioTbx.Location = new System.Drawing.Point(358, 53);
            this.repSenhaCadUsuarioTbx.Name = "repSenhaCadUsuarioTbx";
            this.repSenhaCadUsuarioTbx.PasswordChar = '*';
            this.repSenhaCadUsuarioTbx.Size = new System.Drawing.Size(124, 20);
            this.repSenhaCadUsuarioTbx.TabIndex = 42;
            // 
            // nomeCompletoCadTbx
            // 
            this.nomeCompletoCadTbx.Location = new System.Drawing.Point(130, 11);
            this.nomeCompletoCadTbx.Name = "nomeCompletoCadTbx";
            this.nomeCompletoCadTbx.Size = new System.Drawing.Size(124, 20);
            this.nomeCompletoCadTbx.TabIndex = 39;
            // 
            // cancelarTelaCadUsuarioBtn
            // 
            this.cancelarTelaCadUsuarioBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaCadUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaCadUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaCadUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaCadUsuarioBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaCadUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaCadUsuarioBtn.Location = new System.Drawing.Point(323, 90);
            this.cancelarTelaCadUsuarioBtn.Name = "cancelarTelaCadUsuarioBtn";
            this.cancelarTelaCadUsuarioBtn.Size = new System.Drawing.Size(116, 32);
            this.cancelarTelaCadUsuarioBtn.TabIndex = 44;
            this.cancelarTelaCadUsuarioBtn.Text = "Cancelar";
            this.cancelarTelaCadUsuarioBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaCadUsuarioBtn.Click += new System.EventHandler(this.cancelarTelaCadUsuarioBtn_Click_1);
            // 
            // salvarCadUsuarioBtn
            // 
            this.salvarCadUsuarioBtn.BackColor = System.Drawing.Color.Teal;
            this.salvarCadUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarCadUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.salvarCadUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarCadUsuarioBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarCadUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.salvarCadUsuarioBtn.Location = new System.Drawing.Point(130, 90);
            this.salvarCadUsuarioBtn.Name = "salvarCadUsuarioBtn";
            this.salvarCadUsuarioBtn.Size = new System.Drawing.Size(116, 32);
            this.salvarCadUsuarioBtn.TabIndex = 43;
            this.salvarCadUsuarioBtn.Text = "Salvar";
            this.salvarCadUsuarioBtn.UseVisualStyleBackColor = false;
            this.salvarCadUsuarioBtn.Click += new System.EventHandler(this.cadastrarUsuarioBtn_Click_1);
            // 
            // repSenhaCadLbl
            // 
            this.repSenhaCadLbl.AutoSize = true;
            this.repSenhaCadLbl.BackColor = System.Drawing.Color.Transparent;
            this.repSenhaCadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repSenhaCadLbl.Location = new System.Drawing.Point(263, 55);
            this.repSenhaCadLbl.Name = "repSenhaCadLbl";
            this.repSenhaCadLbl.Size = new System.Drawing.Size(92, 13);
            this.repSenhaCadLbl.TabIndex = 32;
            this.repSenhaCadLbl.Text = "Repita a senha * :";
            // 
            // senhaCadLbl
            // 
            this.senhaCadLbl.AutoSize = true;
            this.senhaCadLbl.BackColor = System.Drawing.Color.Transparent;
            this.senhaCadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaCadLbl.Location = new System.Drawing.Point(77, 56);
            this.senhaCadLbl.Name = "senhaCadLbl";
            this.senhaCadLbl.Size = new System.Drawing.Size(51, 13);
            this.senhaCadLbl.TabIndex = 31;
            this.senhaCadLbl.Text = "Senha * :";
            // 
            // usuarioLoginCadLbl
            // 
            this.usuarioLoginCadLbl.AutoSize = true;
            this.usuarioLoginCadLbl.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLoginCadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLoginCadLbl.Location = new System.Drawing.Point(268, 14);
            this.usuarioLoginCadLbl.Name = "usuarioLoginCadLbl";
            this.usuarioLoginCadLbl.Size = new System.Drawing.Size(87, 13);
            this.usuarioLoginCadLbl.TabIndex = 30;
            this.usuarioLoginCadLbl.Text = "Usuário/Login * :";
            // 
            // nomeCompletoCadLbl
            // 
            this.nomeCompletoCadLbl.AutoSize = true;
            this.nomeCompletoCadLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeCompletoCadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCompletoCadLbl.Location = new System.Drawing.Point(80, 14);
            this.nomeCompletoCadLbl.Name = "nomeCompletoCadLbl";
            this.nomeCompletoCadLbl.Size = new System.Drawing.Size(48, 13);
            this.nomeCompletoCadLbl.TabIndex = 29;
            this.nomeCompletoCadLbl.Text = "Nome * :";
            // 
            // pesquisarUsuarioBtn
            // 
            this.pesquisarUsuarioBtn.AutoSize = true;
            this.pesquisarUsuarioBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisarUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.pesquisarUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarUsuarioBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisarUsuarioBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisarUsuarioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisarUsuarioBtn.Location = new System.Drawing.Point(395, 24);
            this.pesquisarUsuarioBtn.Name = "pesquisarUsuarioBtn";
            this.pesquisarUsuarioBtn.Size = new System.Drawing.Size(112, 36);
            this.pesquisarUsuarioBtn.TabIndex = 35;
            this.pesquisarUsuarioBtn.Text = "Pesquisar";
            this.pesquisarUsuarioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisarUsuarioBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarUsuarioBtn.UseVisualStyleBackColor = false;
            this.pesquisarUsuarioBtn.Click += new System.EventHandler(this.pesquisarUsuarioBtn_Click_1);
            // 
            // nomePesquisaUsuarioTbx
            // 
            this.nomePesquisaUsuarioTbx.Location = new System.Drawing.Point(130, 33);
            this.nomePesquisaUsuarioTbx.Name = "nomePesquisaUsuarioTbx";
            this.nomePesquisaUsuarioTbx.Size = new System.Drawing.Size(251, 20);
            this.nomePesquisaUsuarioTbx.TabIndex = 34;
            // 
            // nomeClientePesqLbl
            // 
            this.nomeClientePesqLbl.AutoSize = true;
            this.nomeClientePesqLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeClientePesqLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClientePesqLbl.Location = new System.Drawing.Point(89, 37);
            this.nomeClientePesqLbl.Name = "nomeClientePesqLbl";
            this.nomeClientePesqLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeClientePesqLbl.TabIndex = 33;
            this.nomeClientePesqLbl.Text = "Nome:";
            // 
            // novoUsuarioBtn
            // 
            this.novoUsuarioBtn.BackColor = System.Drawing.Color.Teal;
            this.novoUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.novoUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoUsuarioBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.novoUsuarioBtn.Location = new System.Drawing.Point(57, 259);
            this.novoUsuarioBtn.Name = "novoUsuarioBtn";
            this.novoUsuarioBtn.Size = new System.Drawing.Size(123, 37);
            this.novoUsuarioBtn.TabIndex = 38;
            this.novoUsuarioBtn.Text = "Novo Usuário";
            this.novoUsuarioBtn.UseVisualStyleBackColor = false;
            this.novoUsuarioBtn.Click += new System.EventHandler(this.novoUsuarioBtn_Click_1);
            // 
            // excluirUsuarioBtn
            // 
            this.excluirUsuarioBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.excluirUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirUsuarioBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.excluirUsuarioBtn.Location = new System.Drawing.Point(413, 259);
            this.excluirUsuarioBtn.Name = "excluirUsuarioBtn";
            this.excluirUsuarioBtn.Size = new System.Drawing.Size(123, 37);
            this.excluirUsuarioBtn.TabIndex = 37;
            this.excluirUsuarioBtn.Text = "Excluir";
            this.excluirUsuarioBtn.UseVisualStyleBackColor = false;
            this.excluirUsuarioBtn.Click += new System.EventHandler(this.excluirUsuarioBtn_Click_1);
            // 
            // alterarUsuarioBtn
            // 
            this.alterarUsuarioBtn.BackColor = System.Drawing.Color.Teal;
            this.alterarUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.alterarUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarUsuarioBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.alterarUsuarioBtn.Location = new System.Drawing.Point(239, 259);
            this.alterarUsuarioBtn.Name = "alterarUsuarioBtn";
            this.alterarUsuarioBtn.Size = new System.Drawing.Size(123, 37);
            this.alterarUsuarioBtn.TabIndex = 36;
            this.alterarUsuarioBtn.Text = "Alterar";
            this.alterarUsuarioBtn.UseVisualStyleBackColor = false;
            this.alterarUsuarioBtn.Click += new System.EventHandler(this.alterarUsuarioBtn_Click_1);
            // 
            // consultaUsuariosGridView
            // 
            this.consultaUsuariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaUsuariosGridView.Location = new System.Drawing.Point(15, 84);
            this.consultaUsuariosGridView.Name = "consultaUsuariosGridView";
            this.consultaUsuariosGridView.Size = new System.Drawing.Size(562, 169);
            this.consultaUsuariosGridView.TabIndex = 29;
            this.consultaUsuariosGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaUsuariosGridView_CellDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cadastro de Usuario";
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.TelaUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUsuariosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pesquisarUsuarioBtn;
        private System.Windows.Forms.TextBox nomePesquisaUsuarioTbx;
        private System.Windows.Forms.Label nomeClientePesqLbl;
        private System.Windows.Forms.Button novoUsuarioBtn;
        private System.Windows.Forms.Button excluirUsuarioBtn;
        private System.Windows.Forms.Button alterarUsuarioBtn;
        private System.Windows.Forms.DataGridView consultaUsuariosGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usuarioLoginCadTbx;
        private System.Windows.Forms.TextBox senhaCadUsuarioTbx;
        private System.Windows.Forms.TextBox repSenhaCadUsuarioTbx;
        private System.Windows.Forms.TextBox nomeCompletoCadTbx;
        private System.Windows.Forms.Button cancelarTelaCadUsuarioBtn;
        private System.Windows.Forms.Button salvarCadUsuarioBtn;
        private System.Windows.Forms.Label repSenhaCadLbl;
        private System.Windows.Forms.Label senhaCadLbl;
        private System.Windows.Forms.Label usuarioLoginCadLbl;
        private System.Windows.Forms.Label nomeCompletoCadLbl;
        private System.Windows.Forms.Label avisoLbl;
    }
}