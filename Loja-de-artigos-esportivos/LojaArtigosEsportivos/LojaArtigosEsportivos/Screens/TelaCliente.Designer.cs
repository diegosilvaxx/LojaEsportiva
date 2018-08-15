namespace LojaArtigosEsportivos
{
    partial class TelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpfClientePesquisaMskBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelarClienteBtn = new System.Windows.Forms.Button();
            this.novoClienteBtn = new System.Windows.Forms.Button();
            this.consultaClienteGridView = new System.Windows.Forms.DataGridView();
            this.nomeClientePesquisaLbl = new System.Windows.Forms.Label();
            this.cpfClientePesquisaLbl = new System.Windows.Forms.Label();
            this.nomeClientePesquisaTbx = new System.Windows.Forms.TextBox();
            this.pesquisarClienteBtn = new System.Windows.Forms.Button();
            this.alterarClienteBtn = new System.Windows.Forms.Button();
            this.excluirClienteBtn = new System.Windows.Forms.Button();
            this.clienteLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaClienteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cpfClientePesquisaMskBox);
            this.panel1.Controls.Add(this.cancelarClienteBtn);
            this.panel1.Controls.Add(this.novoClienteBtn);
            this.panel1.Controls.Add(this.consultaClienteGridView);
            this.panel1.Controls.Add(this.nomeClientePesquisaLbl);
            this.panel1.Controls.Add(this.cpfClientePesquisaLbl);
            this.panel1.Controls.Add(this.nomeClientePesquisaTbx);
            this.panel1.Controls.Add(this.pesquisarClienteBtn);
            this.panel1.Controls.Add(this.alterarClienteBtn);
            this.panel1.Controls.Add(this.excluirClienteBtn);
            this.panel1.Location = new System.Drawing.Point(9, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 446);
            this.panel1.TabIndex = 0;
            // 
            // cpfClientePesquisaMskBox
            // 
            this.cpfClientePesquisaMskBox.Location = new System.Drawing.Point(106, 31);
            this.cpfClientePesquisaMskBox.Mask = "000.000.000-00";
            this.cpfClientePesquisaMskBox.Name = "cpfClientePesquisaMskBox";
            this.cpfClientePesquisaMskBox.Size = new System.Drawing.Size(91, 20);
            this.cpfClientePesquisaMskBox.TabIndex = 20;
            this.cpfClientePesquisaMskBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cancelarClienteBtn
            // 
            this.cancelarClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarClienteBtn.FlatAppearance.BorderSize = 0;
            this.cancelarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarClienteBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarClienteBtn.Location = new System.Drawing.Point(584, 359);
            this.cancelarClienteBtn.Name = "cancelarClienteBtn";
            this.cancelarClienteBtn.Size = new System.Drawing.Size(121, 55);
            this.cancelarClienteBtn.TabIndex = 26;
            this.cancelarClienteBtn.Text = "Cancelar";
            this.cancelarClienteBtn.UseVisualStyleBackColor = false;
            this.cancelarClienteBtn.Click += new System.EventHandler(this.cancelarClienteBtn_Click_1);
            // 
            // novoClienteBtn
            // 
            this.novoClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.novoClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoClienteBtn.FlatAppearance.BorderSize = 0;
            this.novoClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoClienteBtn.ForeColor = System.Drawing.Color.White;
            this.novoClienteBtn.Location = new System.Drawing.Point(39, 359);
            this.novoClienteBtn.Name = "novoClienteBtn";
            this.novoClienteBtn.Size = new System.Drawing.Size(121, 55);
            this.novoClienteBtn.TabIndex = 23;
            this.novoClienteBtn.Text = "Novo Cliente";
            this.novoClienteBtn.UseVisualStyleBackColor = false;
            this.novoClienteBtn.Click += new System.EventHandler(this.novoClienteBtn_Click_1);
            // 
            // consultaClienteGridView
            // 
            this.consultaClienteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaClienteGridView.Location = new System.Drawing.Point(39, 107);
            this.consultaClienteGridView.Name = "consultaClienteGridView";
            this.consultaClienteGridView.ReadOnly = true;
            this.consultaClienteGridView.Size = new System.Drawing.Size(657, 238);
            this.consultaClienteGridView.TabIndex = 17;
            this.consultaClienteGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaClienteGridView_CellContentClick);
            this.consultaClienteGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaClienteGridView_CellDoubleClick_1);
            // 
            // nomeClientePesquisaLbl
            // 
            this.nomeClientePesquisaLbl.AutoSize = true;
            this.nomeClientePesquisaLbl.Location = new System.Drawing.Point(62, 71);
            this.nomeClientePesquisaLbl.Name = "nomeClientePesquisaLbl";
            this.nomeClientePesquisaLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeClientePesquisaLbl.TabIndex = 16;
            this.nomeClientePesquisaLbl.Text = "Nome:";
            // 
            // cpfClientePesquisaLbl
            // 
            this.cpfClientePesquisaLbl.AutoSize = true;
            this.cpfClientePesquisaLbl.Location = new System.Drawing.Point(70, 33);
            this.cpfClientePesquisaLbl.Name = "cpfClientePesquisaLbl";
            this.cpfClientePesquisaLbl.Size = new System.Drawing.Size(30, 13);
            this.cpfClientePesquisaLbl.TabIndex = 15;
            this.cpfClientePesquisaLbl.Text = "CPF:";
            // 
            // nomeClientePesquisaTbx
            // 
            this.nomeClientePesquisaTbx.Location = new System.Drawing.Point(106, 67);
            this.nomeClientePesquisaTbx.Name = "nomeClientePesquisaTbx";
            this.nomeClientePesquisaTbx.Size = new System.Drawing.Size(269, 20);
            this.nomeClientePesquisaTbx.TabIndex = 21;
            // 
            // pesquisarClienteBtn
            // 
            this.pesquisarClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarClienteBtn.FlatAppearance.BorderSize = 0;
            this.pesquisarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarClienteBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisarClienteBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisarClienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisarClienteBtn.Location = new System.Drawing.Point(418, 31);
            this.pesquisarClienteBtn.Name = "pesquisarClienteBtn";
            this.pesquisarClienteBtn.Size = new System.Drawing.Size(135, 56);
            this.pesquisarClienteBtn.TabIndex = 22;
            this.pesquisarClienteBtn.Text = "Pesquisar";
            this.pesquisarClienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarClienteBtn.UseVisualStyleBackColor = false;
            this.pesquisarClienteBtn.Click += new System.EventHandler(this.pesquisarClienteBtn_Click_1);
            // 
            // alterarClienteBtn
            // 
            this.alterarClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.alterarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarClienteBtn.FlatAppearance.BorderSize = 0;
            this.alterarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarClienteBtn.ForeColor = System.Drawing.Color.White;
            this.alterarClienteBtn.Location = new System.Drawing.Point(166, 359);
            this.alterarClienteBtn.Name = "alterarClienteBtn";
            this.alterarClienteBtn.Size = new System.Drawing.Size(121, 55);
            this.alterarClienteBtn.TabIndex = 24;
            this.alterarClienteBtn.Text = "Alterar";
            this.alterarClienteBtn.UseVisualStyleBackColor = false;
            this.alterarClienteBtn.Click += new System.EventHandler(this.alterarClienteBtn_Click_1);
            // 
            // excluirClienteBtn
            // 
            this.excluirClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirClienteBtn.FlatAppearance.BorderSize = 0;
            this.excluirClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirClienteBtn.ForeColor = System.Drawing.Color.White;
            this.excluirClienteBtn.Location = new System.Drawing.Point(293, 359);
            this.excluirClienteBtn.Name = "excluirClienteBtn";
            this.excluirClienteBtn.Size = new System.Drawing.Size(124, 55);
            this.excluirClienteBtn.TabIndex = 25;
            this.excluirClienteBtn.Text = "Excluir";
            this.excluirClienteBtn.UseVisualStyleBackColor = false;
            this.excluirClienteBtn.Click += new System.EventHandler(this.excluirClienteBtn_Click_1);
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.BackColor = System.Drawing.Color.Transparent;
            this.clienteLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLbl.Location = new System.Drawing.Point(325, 9);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(120, 37);
            this.clienteLbl.TabIndex = 21;
            this.clienteLbl.Text = "Cliente";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 527);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaClienteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cpfClientePesquisaMskBox;
        private System.Windows.Forms.Button cancelarClienteBtn;
        private System.Windows.Forms.Button novoClienteBtn;
        private System.Windows.Forms.DataGridView consultaClienteGridView;
        private System.Windows.Forms.Label nomeClientePesquisaLbl;
        private System.Windows.Forms.Label cpfClientePesquisaLbl;
        private System.Windows.Forms.TextBox nomeClientePesquisaTbx;
        private System.Windows.Forms.Button pesquisarClienteBtn;
        private System.Windows.Forms.Button alterarClienteBtn;
        private System.Windows.Forms.Button excluirClienteBtn;
        private System.Windows.Forms.Label clienteLbl;
    }
}