namespace LojaArtigosEsportivos
{
    partial class TelaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarTelaFornBtn = new System.Windows.Forms.Button();
            this.excluirFornecedorBtn = new System.Windows.Forms.Button();
            this.alterarFornecedorBtn = new System.Windows.Forms.Button();
            this.novoFornecedorBtn = new System.Windows.Forms.Button();
            this.consultaFonecedorGridView = new System.Windows.Forms.DataGridView();
            this.pesquisaCnpjFornMskBox = new System.Windows.Forms.MaskedTextBox();
            this.pesquisaNomeFornTbx = new System.Windows.Forms.TextBox();
            this.pesquisarFornecedorBtn = new System.Windows.Forms.Button();
            this.pesquisaNomeFornLbl = new System.Windows.Forms.Label();
            this.pesquisaCnpjFornLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaFonecedorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancelarTelaFornBtn);
            this.panel1.Controls.Add(this.excluirFornecedorBtn);
            this.panel1.Controls.Add(this.alterarFornecedorBtn);
            this.panel1.Controls.Add(this.novoFornecedorBtn);
            this.panel1.Controls.Add(this.consultaFonecedorGridView);
            this.panel1.Controls.Add(this.pesquisaCnpjFornMskBox);
            this.panel1.Controls.Add(this.pesquisaNomeFornTbx);
            this.panel1.Controls.Add(this.pesquisarFornecedorBtn);
            this.panel1.Controls.Add(this.pesquisaNomeFornLbl);
            this.panel1.Controls.Add(this.pesquisaCnpjFornLbl);
            this.panel1.Location = new System.Drawing.Point(9, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 418);
            this.panel1.TabIndex = 0;
            // 
            // cancelarTelaFornBtn
            // 
            this.cancelarTelaFornBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaFornBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaFornBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaFornBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaFornBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaFornBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaFornBtn.Location = new System.Drawing.Point(490, 352);
            this.cancelarTelaFornBtn.Name = "cancelarTelaFornBtn";
            this.cancelarTelaFornBtn.Size = new System.Drawing.Size(106, 51);
            this.cancelarTelaFornBtn.TabIndex = 20;
            this.cancelarTelaFornBtn.Text = "Cancelar";
            this.cancelarTelaFornBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaFornBtn.Click += new System.EventHandler(this.cancelarTelaFornBtn_Click);
            // 
            // excluirFornecedorBtn
            // 
            this.excluirFornecedorBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirFornecedorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirFornecedorBtn.FlatAppearance.BorderSize = 0;
            this.excluirFornecedorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirFornecedorBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirFornecedorBtn.ForeColor = System.Drawing.Color.White;
            this.excluirFornecedorBtn.Location = new System.Drawing.Point(279, 352);
            this.excluirFornecedorBtn.Name = "excluirFornecedorBtn";
            this.excluirFornecedorBtn.Size = new System.Drawing.Size(106, 51);
            this.excluirFornecedorBtn.TabIndex = 19;
            this.excluirFornecedorBtn.Text = "Excluir";
            this.excluirFornecedorBtn.UseVisualStyleBackColor = false;
            this.excluirFornecedorBtn.Click += new System.EventHandler(this.excluirFornecedorBtn_Click_1);
            // 
            // alterarFornecedorBtn
            // 
            this.alterarFornecedorBtn.BackColor = System.Drawing.Color.Teal;
            this.alterarFornecedorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarFornecedorBtn.FlatAppearance.BorderSize = 0;
            this.alterarFornecedorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarFornecedorBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarFornecedorBtn.ForeColor = System.Drawing.Color.White;
            this.alterarFornecedorBtn.Location = new System.Drawing.Point(157, 352);
            this.alterarFornecedorBtn.Name = "alterarFornecedorBtn";
            this.alterarFornecedorBtn.Size = new System.Drawing.Size(106, 51);
            this.alterarFornecedorBtn.TabIndex = 18;
            this.alterarFornecedorBtn.Text = "Alterar";
            this.alterarFornecedorBtn.UseVisualStyleBackColor = false;
            this.alterarFornecedorBtn.Click += new System.EventHandler(this.alterarFornecedorBtn_Click_1);
            // 
            // novoFornecedorBtn
            // 
            this.novoFornecedorBtn.BackColor = System.Drawing.Color.Teal;
            this.novoFornecedorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoFornecedorBtn.FlatAppearance.BorderSize = 0;
            this.novoFornecedorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoFornecedorBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoFornecedorBtn.ForeColor = System.Drawing.Color.White;
            this.novoFornecedorBtn.Location = new System.Drawing.Point(21, 352);
            this.novoFornecedorBtn.Name = "novoFornecedorBtn";
            this.novoFornecedorBtn.Size = new System.Drawing.Size(121, 51);
            this.novoFornecedorBtn.TabIndex = 17;
            this.novoFornecedorBtn.Text = "Novo Fornecedor";
            this.novoFornecedorBtn.UseVisualStyleBackColor = false;
            this.novoFornecedorBtn.Click += new System.EventHandler(this.novoFornecedorBtn_Click_1);
            // 
            // consultaFonecedorGridView
            // 
            this.consultaFonecedorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaFonecedorGridView.Location = new System.Drawing.Point(21, 101);
            this.consultaFonecedorGridView.Name = "consultaFonecedorGridView";
            this.consultaFonecedorGridView.ReadOnly = true;
            this.consultaFonecedorGridView.Size = new System.Drawing.Size(575, 226);
            this.consultaFonecedorGridView.TabIndex = 15;
            this.consultaFonecedorGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaFonecedorGridView_CellDoubleClick);
            // 
            // pesquisaCnpjFornMskBox
            // 
            this.pesquisaCnpjFornMskBox.Location = new System.Drawing.Point(148, 21);
            this.pesquisaCnpjFornMskBox.Mask = "00.000.000/0000-00";
            this.pesquisaCnpjFornMskBox.Name = "pesquisaCnpjFornMskBox";
            this.pesquisaCnpjFornMskBox.Size = new System.Drawing.Size(127, 20);
            this.pesquisaCnpjFornMskBox.TabIndex = 14;
            this.pesquisaCnpjFornMskBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pesquisaNomeFornTbx
            // 
            this.pesquisaNomeFornTbx.Location = new System.Drawing.Point(148, 58);
            this.pesquisaNomeFornTbx.Name = "pesquisaNomeFornTbx";
            this.pesquisaNomeFornTbx.Size = new System.Drawing.Size(213, 20);
            this.pesquisaNomeFornTbx.TabIndex = 15;
            // 
            // pesquisarFornecedorBtn
            // 
            this.pesquisarFornecedorBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisarFornecedorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarFornecedorBtn.FlatAppearance.BorderSize = 0;
            this.pesquisarFornecedorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarFornecedorBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarFornecedorBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisarFornecedorBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisarFornecedorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisarFornecedorBtn.Location = new System.Drawing.Point(394, 21);
            this.pesquisarFornecedorBtn.Name = "pesquisarFornecedorBtn";
            this.pesquisarFornecedorBtn.Size = new System.Drawing.Size(124, 54);
            this.pesquisarFornecedorBtn.TabIndex = 16;
            this.pesquisarFornecedorBtn.Text = "Pesquisar";
            this.pesquisarFornecedorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarFornecedorBtn.UseVisualStyleBackColor = false;
            this.pesquisarFornecedorBtn.Click += new System.EventHandler(this.pesquisarFornecedorBtn_Click_1);
            // 
            // pesquisaNomeFornLbl
            // 
            this.pesquisaNomeFornLbl.AutoSize = true;
            this.pesquisaNomeFornLbl.BackColor = System.Drawing.Color.Transparent;
            this.pesquisaNomeFornLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeFornLbl.Location = new System.Drawing.Point(104, 61);
            this.pesquisaNomeFornLbl.Name = "pesquisaNomeFornLbl";
            this.pesquisaNomeFornLbl.Size = new System.Drawing.Size(38, 13);
            this.pesquisaNomeFornLbl.TabIndex = 11;
            this.pesquisaNomeFornLbl.Text = "Nome:";
            // 
            // pesquisaCnpjFornLbl
            // 
            this.pesquisaCnpjFornLbl.AutoSize = true;
            this.pesquisaCnpjFornLbl.BackColor = System.Drawing.Color.Transparent;
            this.pesquisaCnpjFornLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaCnpjFornLbl.Location = new System.Drawing.Point(105, 24);
            this.pesquisaCnpjFornLbl.Name = "pesquisaCnpjFornLbl";
            this.pesquisaCnpjFornLbl.Size = new System.Drawing.Size(37, 13);
            this.pesquisaCnpjFornLbl.TabIndex = 10;
            this.pesquisaCnpjFornLbl.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fornecedor";
            // 
            // TelaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Fornecedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaFonecedorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarTelaFornBtn;
        private System.Windows.Forms.Button excluirFornecedorBtn;
        private System.Windows.Forms.Button alterarFornecedorBtn;
        private System.Windows.Forms.Button novoFornecedorBtn;
        private System.Windows.Forms.DataGridView consultaFonecedorGridView;
        private System.Windows.Forms.MaskedTextBox pesquisaCnpjFornMskBox;
        private System.Windows.Forms.TextBox pesquisaNomeFornTbx;
        private System.Windows.Forms.Button pesquisarFornecedorBtn;
        private System.Windows.Forms.Label pesquisaNomeFornLbl;
        private System.Windows.Forms.Label pesquisaCnpjFornLbl;
        private System.Windows.Forms.Label label1;
    }
}