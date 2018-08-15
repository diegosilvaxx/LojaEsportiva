namespace LojaArtigosEsportivos
{
    partial class TelaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.modeloPesqTbx = new System.Windows.Forms.TextBox();
            this.marcaPesqTbx = new System.Windows.Forms.TextBox();
            this.consultarProdutoCadGridView = new System.Windows.Forms.DataGridView();
            this.modeloPesqProdLbl = new System.Windows.Forms.Label();
            this.marcaPesqProdLbl = new System.Windows.Forms.Label();
            this.cancelarTelaProdBtn = new System.Windows.Forms.Button();
            this.novoProdutoBtn = new System.Windows.Forms.Button();
            this.alterarProdutoBtn = new System.Windows.Forms.Button();
            this.excluirProdutoBtn = new System.Windows.Forms.Button();
            this.pesquisarProdutoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultarProdutoCadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.modeloPesqTbx);
            this.panel1.Controls.Add(this.marcaPesqTbx);
            this.panel1.Controls.Add(this.consultarProdutoCadGridView);
            this.panel1.Controls.Add(this.modeloPesqProdLbl);
            this.panel1.Controls.Add(this.marcaPesqProdLbl);
            this.panel1.Controls.Add(this.cancelarTelaProdBtn);
            this.panel1.Controls.Add(this.novoProdutoBtn);
            this.panel1.Controls.Add(this.alterarProdutoBtn);
            this.panel1.Controls.Add(this.excluirProdutoBtn);
            this.panel1.Controls.Add(this.pesquisarProdutoBtn);
            this.panel1.Location = new System.Drawing.Point(9, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 407);
            this.panel1.TabIndex = 0;
            // 
            // modeloPesqTbx
            // 
            this.modeloPesqTbx.Location = new System.Drawing.Point(104, 61);
            this.modeloPesqTbx.Name = "modeloPesqTbx";
            this.modeloPesqTbx.Size = new System.Drawing.Size(267, 20);
            this.modeloPesqTbx.TabIndex = 22;
            // 
            // marcaPesqTbx
            // 
            this.marcaPesqTbx.Location = new System.Drawing.Point(104, 27);
            this.marcaPesqTbx.Name = "marcaPesqTbx";
            this.marcaPesqTbx.Size = new System.Drawing.Size(267, 20);
            this.marcaPesqTbx.TabIndex = 21;
            // 
            // consultarProdutoCadGridView
            // 
            this.consultarProdutoCadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultarProdutoCadGridView.Location = new System.Drawing.Point(18, 99);
            this.consultarProdutoCadGridView.Name = "consultarProdutoCadGridView";
            this.consultarProdutoCadGridView.ReadOnly = true;
            this.consultarProdutoCadGridView.Size = new System.Drawing.Size(561, 229);
            this.consultarProdutoCadGridView.TabIndex = 20;
            this.consultarProdutoCadGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultarProdutoCadGridView_CellDoubleClick_1);
            // 
            // modeloPesqProdLbl
            // 
            this.modeloPesqProdLbl.AutoSize = true;
            this.modeloPesqProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.modeloPesqProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloPesqProdLbl.Location = new System.Drawing.Point(55, 64);
            this.modeloPesqProdLbl.Name = "modeloPesqProdLbl";
            this.modeloPesqProdLbl.Size = new System.Drawing.Size(45, 13);
            this.modeloPesqProdLbl.TabIndex = 19;
            this.modeloPesqProdLbl.Text = "Modelo:";
            // 
            // marcaPesqProdLbl
            // 
            this.marcaPesqProdLbl.AutoSize = true;
            this.marcaPesqProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.marcaPesqProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaPesqProdLbl.Location = new System.Drawing.Point(55, 29);
            this.marcaPesqProdLbl.Name = "marcaPesqProdLbl";
            this.marcaPesqProdLbl.Size = new System.Drawing.Size(40, 13);
            this.marcaPesqProdLbl.TabIndex = 18;
            this.marcaPesqProdLbl.Text = "Marca:";
            // 
            // cancelarTelaProdBtn
            // 
            this.cancelarTelaProdBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaProdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaProdBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaProdBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaProdBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaProdBtn.Location = new System.Drawing.Point(483, 334);
            this.cancelarTelaProdBtn.Name = "cancelarTelaProdBtn";
            this.cancelarTelaProdBtn.Size = new System.Drawing.Size(96, 52);
            this.cancelarTelaProdBtn.TabIndex = 27;
            this.cancelarTelaProdBtn.Text = "Cancelar";
            this.cancelarTelaProdBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaProdBtn.Click += new System.EventHandler(this.cancelarTelaProdBtn_Click_1);
            // 
            // novoProdutoBtn
            // 
            this.novoProdutoBtn.BackColor = System.Drawing.Color.Teal;
            this.novoProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoProdutoBtn.FlatAppearance.BorderSize = 0;
            this.novoProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoProdutoBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoProdutoBtn.ForeColor = System.Drawing.Color.White;
            this.novoProdutoBtn.Location = new System.Drawing.Point(18, 334);
            this.novoProdutoBtn.Name = "novoProdutoBtn";
            this.novoProdutoBtn.Size = new System.Drawing.Size(96, 52);
            this.novoProdutoBtn.TabIndex = 24;
            this.novoProdutoBtn.Text = "Novo Produto";
            this.novoProdutoBtn.UseVisualStyleBackColor = false;
            this.novoProdutoBtn.Click += new System.EventHandler(this.novoProdutoBtn_Click_1);
            // 
            // alterarProdutoBtn
            // 
            this.alterarProdutoBtn.BackColor = System.Drawing.Color.Teal;
            this.alterarProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarProdutoBtn.FlatAppearance.BorderSize = 0;
            this.alterarProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarProdutoBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarProdutoBtn.ForeColor = System.Drawing.Color.White;
            this.alterarProdutoBtn.Location = new System.Drawing.Point(132, 334);
            this.alterarProdutoBtn.Name = "alterarProdutoBtn";
            this.alterarProdutoBtn.Size = new System.Drawing.Size(96, 52);
            this.alterarProdutoBtn.TabIndex = 25;
            this.alterarProdutoBtn.Text = "Alterar";
            this.alterarProdutoBtn.UseVisualStyleBackColor = false;
            this.alterarProdutoBtn.Click += new System.EventHandler(this.alterarProdutoBtn_Click_1);
            // 
            // excluirProdutoBtn
            // 
            this.excluirProdutoBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirProdutoBtn.FlatAppearance.BorderSize = 0;
            this.excluirProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirProdutoBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirProdutoBtn.ForeColor = System.Drawing.Color.White;
            this.excluirProdutoBtn.Location = new System.Drawing.Point(246, 334);
            this.excluirProdutoBtn.Name = "excluirProdutoBtn";
            this.excluirProdutoBtn.Size = new System.Drawing.Size(96, 52);
            this.excluirProdutoBtn.TabIndex = 26;
            this.excluirProdutoBtn.Text = "Excluir";
            this.excluirProdutoBtn.UseVisualStyleBackColor = false;
            this.excluirProdutoBtn.Click += new System.EventHandler(this.excluirProdutoBtn_Click_1);
            // 
            // pesquisarProdutoBtn
            // 
            this.pesquisarProdutoBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisarProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarProdutoBtn.FlatAppearance.BorderSize = 0;
            this.pesquisarProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarProdutoBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarProdutoBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisarProdutoBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisarProdutoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisarProdutoBtn.Location = new System.Drawing.Point(393, 27);
            this.pesquisarProdutoBtn.Name = "pesquisarProdutoBtn";
            this.pesquisarProdutoBtn.Size = new System.Drawing.Size(122, 52);
            this.pesquisarProdutoBtn.TabIndex = 23;
            this.pesquisarProdutoBtn.Text = "Pesquisar";
            this.pesquisarProdutoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarProdutoBtn.UseVisualStyleBackColor = false;
            this.pesquisarProdutoBtn.Click += new System.EventHandler(this.pesquisarProdutoBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Produto";
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultarProdutoCadGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox modeloPesqTbx;
        private System.Windows.Forms.TextBox marcaPesqTbx;
        private System.Windows.Forms.DataGridView consultarProdutoCadGridView;
        private System.Windows.Forms.Label modeloPesqProdLbl;
        private System.Windows.Forms.Label marcaPesqProdLbl;
        private System.Windows.Forms.Button cancelarTelaProdBtn;
        private System.Windows.Forms.Button novoProdutoBtn;
        private System.Windows.Forms.Button alterarProdutoBtn;
        private System.Windows.Forms.Button excluirProdutoBtn;
        private System.Windows.Forms.Button pesquisarProdutoBtn;
        private System.Windows.Forms.Label label1;
    }
}