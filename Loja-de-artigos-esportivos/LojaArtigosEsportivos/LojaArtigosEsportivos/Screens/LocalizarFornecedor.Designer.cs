namespace LojaArtigosEsportivos
{
    partial class LocalizarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarFornecedor));
            this.consultaFornLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cadastroFornBtn = new System.Windows.Forms.Button();
            this.cnpjLocalizaFornMskBx = new System.Windows.Forms.MaskedTextBox();
            this.nomeLocalizaFornTbx = new System.Windows.Forms.TextBox();
            this.nomeLocalizaFornLbl = new System.Windows.Forms.Label();
            this.cnpjLocalizaFornLbl = new System.Windows.Forms.Label();
            this.localizarFornBtn = new System.Windows.Forms.Button();
            this.cancelaSelFornBtn = new System.Windows.Forms.Button();
            this.selecionarFornBtn = new System.Windows.Forms.Button();
            this.localizaFornecedorGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizaFornecedorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaFornLbl
            // 
            this.consultaFornLbl.AutoSize = true;
            this.consultaFornLbl.BackColor = System.Drawing.Color.Transparent;
            this.consultaFornLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaFornLbl.Location = new System.Drawing.Point(184, 9);
            this.consultaFornLbl.Name = "consultaFornLbl";
            this.consultaFornLbl.Size = new System.Drawing.Size(262, 29);
            this.consultaFornLbl.TabIndex = 10;
            this.consultaFornLbl.Text = "Consultar Fornecedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cadastroFornBtn);
            this.panel1.Controls.Add(this.cnpjLocalizaFornMskBx);
            this.panel1.Controls.Add(this.nomeLocalizaFornTbx);
            this.panel1.Controls.Add(this.nomeLocalizaFornLbl);
            this.panel1.Controls.Add(this.cnpjLocalizaFornLbl);
            this.panel1.Controls.Add(this.localizarFornBtn);
            this.panel1.Controls.Add(this.cancelaSelFornBtn);
            this.panel1.Controls.Add(this.selecionarFornBtn);
            this.panel1.Controls.Add(this.localizaFornecedorGridView);
            this.panel1.Location = new System.Drawing.Point(9, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 405);
            this.panel1.TabIndex = 11;
            // 
            // cadastroFornBtn
            // 
            this.cadastroFornBtn.BackColor = System.Drawing.Color.Teal;
            this.cadastroFornBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastroFornBtn.FlatAppearance.BorderSize = 0;
            this.cadastroFornBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroFornBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroFornBtn.ForeColor = System.Drawing.Color.White;
            this.cadastroFornBtn.Location = new System.Drawing.Point(15, 339);
            this.cadastroFornBtn.Name = "cadastroFornBtn";
            this.cadastroFornBtn.Size = new System.Drawing.Size(120, 50);
            this.cadastroFornBtn.TabIndex = 21;
            this.cadastroFornBtn.Text = "Novo Fornecedor";
            this.cadastroFornBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadastroFornBtn.UseVisualStyleBackColor = false;
            this.cadastroFornBtn.Click += new System.EventHandler(this.cadastroFornBtn_Click);
            // 
            // cnpjLocalizaFornMskBx
            // 
            this.cnpjLocalizaFornMskBx.Location = new System.Drawing.Point(83, 21);
            this.cnpjLocalizaFornMskBx.Mask = "00.000.000/00000-00";
            this.cnpjLocalizaFornMskBx.Name = "cnpjLocalizaFornMskBx";
            this.cnpjLocalizaFornMskBx.Size = new System.Drawing.Size(124, 20);
            this.cnpjLocalizaFornMskBx.TabIndex = 16;
            this.cnpjLocalizaFornMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nomeLocalizaFornTbx
            // 
            this.nomeLocalizaFornTbx.Location = new System.Drawing.Point(83, 57);
            this.nomeLocalizaFornTbx.Name = "nomeLocalizaFornTbx";
            this.nomeLocalizaFornTbx.Size = new System.Drawing.Size(253, 20);
            this.nomeLocalizaFornTbx.TabIndex = 17;
            // 
            // nomeLocalizaFornLbl
            // 
            this.nomeLocalizaFornLbl.AutoSize = true;
            this.nomeLocalizaFornLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeLocalizaFornLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLocalizaFornLbl.Location = new System.Drawing.Point(40, 60);
            this.nomeLocalizaFornLbl.Name = "nomeLocalizaFornLbl";
            this.nomeLocalizaFornLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeLocalizaFornLbl.TabIndex = 14;
            this.nomeLocalizaFornLbl.Text = "Nome:";
            // 
            // cnpjLocalizaFornLbl
            // 
            this.cnpjLocalizaFornLbl.AutoSize = true;
            this.cnpjLocalizaFornLbl.BackColor = System.Drawing.Color.Transparent;
            this.cnpjLocalizaFornLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpjLocalizaFornLbl.Location = new System.Drawing.Point(40, 24);
            this.cnpjLocalizaFornLbl.Name = "cnpjLocalizaFornLbl";
            this.cnpjLocalizaFornLbl.Size = new System.Drawing.Size(37, 13);
            this.cnpjLocalizaFornLbl.TabIndex = 13;
            this.cnpjLocalizaFornLbl.Text = "CNPJ:";
            // 
            // localizarFornBtn
            // 
            this.localizarFornBtn.AutoSize = true;
            this.localizarFornBtn.BackColor = System.Drawing.Color.Teal;
            this.localizarFornBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.localizarFornBtn.FlatAppearance.BorderSize = 0;
            this.localizarFornBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localizarFornBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizarFornBtn.ForeColor = System.Drawing.Color.White;
            this.localizarFornBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.localizarFornBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizarFornBtn.Location = new System.Drawing.Point(391, 21);
            this.localizarFornBtn.Name = "localizarFornBtn";
            this.localizarFornBtn.Size = new System.Drawing.Size(115, 57);
            this.localizarFornBtn.TabIndex = 18;
            this.localizarFornBtn.Text = "Localizar";
            this.localizarFornBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.localizarFornBtn.UseVisualStyleBackColor = false;
            this.localizarFornBtn.Click += new System.EventHandler(this.localizarFornBtn_Click_1);
            // 
            // cancelaSelFornBtn
            // 
            this.cancelaSelFornBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelaSelFornBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelaSelFornBtn.FlatAppearance.BorderSize = 0;
            this.cancelaSelFornBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelaSelFornBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelaSelFornBtn.ForeColor = System.Drawing.Color.White;
            this.cancelaSelFornBtn.Location = new System.Drawing.Point(455, 339);
            this.cancelaSelFornBtn.Name = "cancelaSelFornBtn";
            this.cancelaSelFornBtn.Size = new System.Drawing.Size(120, 50);
            this.cancelaSelFornBtn.TabIndex = 20;
            this.cancelaSelFornBtn.Text = "Cancelar";
            this.cancelaSelFornBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelaSelFornBtn.UseVisualStyleBackColor = false;
            this.cancelaSelFornBtn.Click += new System.EventHandler(this.cancelaSelFornBtn_Click);
            // 
            // selecionarFornBtn
            // 
            this.selecionarFornBtn.BackColor = System.Drawing.Color.Teal;
            this.selecionarFornBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selecionarFornBtn.FlatAppearance.BorderSize = 0;
            this.selecionarFornBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecionarFornBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionarFornBtn.ForeColor = System.Drawing.Color.White;
            this.selecionarFornBtn.Location = new System.Drawing.Point(319, 339);
            this.selecionarFornBtn.Name = "selecionarFornBtn";
            this.selecionarFornBtn.Size = new System.Drawing.Size(120, 50);
            this.selecionarFornBtn.TabIndex = 19;
            this.selecionarFornBtn.Text = "Selecionar";
            this.selecionarFornBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selecionarFornBtn.UseVisualStyleBackColor = false;
            this.selecionarFornBtn.Click += new System.EventHandler(this.selecionarFornBtn_Click);
            // 
            // localizaFornecedorGridView
            // 
            this.localizaFornecedorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localizaFornecedorGridView.Location = new System.Drawing.Point(15, 104);
            this.localizaFornecedorGridView.Name = "localizaFornecedorGridView";
            this.localizaFornecedorGridView.ReadOnly = true;
            this.localizaFornecedorGridView.Size = new System.Drawing.Size(560, 218);
            this.localizaFornecedorGridView.TabIndex = 9;
            this.localizaFornecedorGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.localizaFornecedorGridView_CellDoubleClick_1);
            // 
            // LocalizarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consultaFornLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LocalizarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fornecedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizaFornecedorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label consultaFornLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cnpjLocalizaFornMskBx;
        private System.Windows.Forms.TextBox nomeLocalizaFornTbx;
        private System.Windows.Forms.Label nomeLocalizaFornLbl;
        private System.Windows.Forms.Label cnpjLocalizaFornLbl;
        private System.Windows.Forms.Button localizarFornBtn;
        public System.Windows.Forms.Button cancelaSelFornBtn;
        public System.Windows.Forms.Button selecionarFornBtn;
        private System.Windows.Forms.DataGridView localizaFornecedorGridView;
        public System.Windows.Forms.Button cadastroFornBtn;
    }
}