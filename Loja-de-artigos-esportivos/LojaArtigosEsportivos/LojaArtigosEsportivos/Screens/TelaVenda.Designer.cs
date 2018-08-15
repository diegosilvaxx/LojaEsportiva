namespace LojaArtigosEsportivos
{
    partial class TelaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpfPesqVendaMskBx = new System.Windows.Forms.MaskedTextBox();
            this.cpfPesqVendaLbl = new System.Windows.Forms.Label();
            this.nomeClientePesqTbx = new System.Windows.Forms.TextBox();
            this.consultaVendaGridView = new System.Windows.Forms.DataGridView();
            this.nomeClientePesqLbl = new System.Windows.Forms.Label();
            this.excluirVendaBtn = new System.Windows.Forms.Button();
            this.cancelarTelaVendaBtn = new System.Windows.Forms.Button();
            this.novaVendaBtn = new System.Windows.Forms.Button();
            this.pesquisaVendaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaVendaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cpfPesqVendaMskBx);
            this.panel1.Controls.Add(this.cpfPesqVendaLbl);
            this.panel1.Controls.Add(this.nomeClientePesqTbx);
            this.panel1.Controls.Add(this.consultaVendaGridView);
            this.panel1.Controls.Add(this.nomeClientePesqLbl);
            this.panel1.Controls.Add(this.excluirVendaBtn);
            this.panel1.Controls.Add(this.cancelarTelaVendaBtn);
            this.panel1.Controls.Add(this.novaVendaBtn);
            this.panel1.Controls.Add(this.pesquisaVendaBtn);
            this.panel1.Location = new System.Drawing.Point(9, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 418);
            this.panel1.TabIndex = 0;
            // 
            // cpfPesqVendaMskBx
            // 
            this.cpfPesqVendaMskBx.Location = new System.Drawing.Point(141, 23);
            this.cpfPesqVendaMskBx.Mask = "000.000.000-00";
            this.cpfPesqVendaMskBx.Name = "cpfPesqVendaMskBx";
            this.cpfPesqVendaMskBx.Size = new System.Drawing.Size(101, 20);
            this.cpfPesqVendaMskBx.TabIndex = 29;
            this.cpfPesqVendaMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfPesqVendaLbl
            // 
            this.cpfPesqVendaLbl.AutoSize = true;
            this.cpfPesqVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpfPesqVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfPesqVendaLbl.Location = new System.Drawing.Point(105, 26);
            this.cpfPesqVendaLbl.Name = "cpfPesqVendaLbl";
            this.cpfPesqVendaLbl.Size = new System.Drawing.Size(30, 13);
            this.cpfPesqVendaLbl.TabIndex = 28;
            this.cpfPesqVendaLbl.Text = "CPF:";
            // 
            // nomeClientePesqTbx
            // 
            this.nomeClientePesqTbx.Location = new System.Drawing.Point(141, 63);
            this.nomeClientePesqTbx.Name = "nomeClientePesqTbx";
            this.nomeClientePesqTbx.Size = new System.Drawing.Size(221, 20);
            this.nomeClientePesqTbx.TabIndex = 30;
            // 
            // consultaVendaGridView
            // 
            this.consultaVendaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaVendaGridView.Location = new System.Drawing.Point(44, 108);
            this.consultaVendaGridView.Name = "consultaVendaGridView";
            this.consultaVendaGridView.Size = new System.Drawing.Size(532, 236);
            this.consultaVendaGridView.TabIndex = 26;
            this.consultaVendaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaVendaGridView_CellDoubleClick);
            // 
            // nomeClientePesqLbl
            // 
            this.nomeClientePesqLbl.AutoSize = true;
            this.nomeClientePesqLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeClientePesqLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClientePesqLbl.Location = new System.Drawing.Point(62, 66);
            this.nomeClientePesqLbl.Name = "nomeClientePesqLbl";
            this.nomeClientePesqLbl.Size = new System.Drawing.Size(73, 13);
            this.nomeClientePesqLbl.TabIndex = 25;
            this.nomeClientePesqLbl.Text = "Nome Cliente:";
            // 
            // excluirVendaBtn
            // 
            this.excluirVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirVendaBtn.FlatAppearance.BorderSize = 0;
            this.excluirVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirVendaBtn.ForeColor = System.Drawing.Color.White;
            this.excluirVendaBtn.Location = new System.Drawing.Point(188, 350);
            this.excluirVendaBtn.Name = "excluirVendaBtn";
            this.excluirVendaBtn.Size = new System.Drawing.Size(117, 50);
            this.excluirVendaBtn.TabIndex = 33;
            this.excluirVendaBtn.Text = "Excluir";
            this.excluirVendaBtn.UseVisualStyleBackColor = false;
            this.excluirVendaBtn.Click += new System.EventHandler(this.excluirVendaBtn_Click);
            // 
            // cancelarTelaVendaBtn
            // 
            this.cancelarTelaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaVendaBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaVendaBtn.Location = new System.Drawing.Point(459, 350);
            this.cancelarTelaVendaBtn.Name = "cancelarTelaVendaBtn";
            this.cancelarTelaVendaBtn.Size = new System.Drawing.Size(117, 50);
            this.cancelarTelaVendaBtn.TabIndex = 34;
            this.cancelarTelaVendaBtn.Text = "Cancelar";
            this.cancelarTelaVendaBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaVendaBtn.Click += new System.EventHandler(this.cancelarTelaVendaBtn_Click);
            // 
            // novaVendaBtn
            // 
            this.novaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.novaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novaVendaBtn.FlatAppearance.BorderSize = 0;
            this.novaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.novaVendaBtn.Location = new System.Drawing.Point(44, 350);
            this.novaVendaBtn.Name = "novaVendaBtn";
            this.novaVendaBtn.Size = new System.Drawing.Size(117, 50);
            this.novaVendaBtn.TabIndex = 32;
            this.novaVendaBtn.Text = "Nova Venda";
            this.novaVendaBtn.UseVisualStyleBackColor = false;
            this.novaVendaBtn.Click += new System.EventHandler(this.novaVendaBtn_Click);
            // 
            // pesquisaVendaBtn
            // 
            this.pesquisaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisaVendaBtn.FlatAppearance.BorderSize = 0;
            this.pesquisaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisaVendaBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisaVendaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisaVendaBtn.Location = new System.Drawing.Point(404, 23);
            this.pesquisaVendaBtn.Name = "pesquisaVendaBtn";
            this.pesquisaVendaBtn.Size = new System.Drawing.Size(130, 58);
            this.pesquisaVendaBtn.TabIndex = 31;
            this.pesquisaVendaBtn.Text = "Pesquisar";
            this.pesquisaVendaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisaVendaBtn.UseVisualStyleBackColor = false;
            this.pesquisaVendaBtn.Click += new System.EventHandler(this.pesquisaVendaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vendas";
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaVendaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cpfPesqVendaMskBx;
        private System.Windows.Forms.Label cpfPesqVendaLbl;
        private System.Windows.Forms.TextBox nomeClientePesqTbx;
        private System.Windows.Forms.DataGridView consultaVendaGridView;
        private System.Windows.Forms.Label nomeClientePesqLbl;
        private System.Windows.Forms.Button excluirVendaBtn;
        private System.Windows.Forms.Button cancelarTelaVendaBtn;
        private System.Windows.Forms.Button novaVendaBtn;
        private System.Windows.Forms.Button pesquisaVendaBtn;
        private System.Windows.Forms.Label label1;
    }
}