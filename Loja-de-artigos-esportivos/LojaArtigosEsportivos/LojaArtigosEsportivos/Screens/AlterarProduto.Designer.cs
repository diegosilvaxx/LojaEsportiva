namespace LojaArtigosEsportivos
{
    partial class AlterarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarProduto));
            this.alterarProdutoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avisoLbl = new System.Windows.Forms.Label();
            this.categoriaAltProdCbx = new System.Windows.Forms.ComboBox();
            this.descricaoAltProdLbl = new System.Windows.Forms.Label();
            this.categoriaAltProdLbl = new System.Windows.Forms.Label();
            this.descricaoAltProdTbx = new System.Windows.Forms.TextBox();
            this.quantidadeAltProdTbx = new System.Windows.Forms.TextBox();
            this.cancelarAltProdBtn = new System.Windows.Forms.Button();
            this.salvarAltProdBtn = new System.Windows.Forms.Button();
            this.precoAltProdTbx = new System.Windows.Forms.TextBox();
            this.modeloAltProdTbx = new System.Windows.Forms.TextBox();
            this.marcaAltProdTbx = new System.Windows.Forms.TextBox();
            this.precoAltProdLbl = new System.Windows.Forms.Label();
            this.quantidadeAltProdLbl = new System.Windows.Forms.Label();
            this.modeloAltProdLbl = new System.Windows.Forms.Label();
            this.marcaAltProdLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alterarProdutoLbl
            // 
            this.alterarProdutoLbl.AutoSize = true;
            this.alterarProdutoLbl.BackColor = System.Drawing.Color.Transparent;
            this.alterarProdutoLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarProdutoLbl.Location = new System.Drawing.Point(165, 9);
            this.alterarProdutoLbl.Name = "alterarProdutoLbl";
            this.alterarProdutoLbl.Size = new System.Drawing.Size(246, 37);
            this.alterarProdutoLbl.TabIndex = 0;
            this.alterarProdutoLbl.Text = "Alterar Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.avisoLbl);
            this.panel1.Controls.Add(this.categoriaAltProdCbx);
            this.panel1.Controls.Add(this.descricaoAltProdLbl);
            this.panel1.Controls.Add(this.categoriaAltProdLbl);
            this.panel1.Controls.Add(this.descricaoAltProdTbx);
            this.panel1.Controls.Add(this.quantidadeAltProdTbx);
            this.panel1.Controls.Add(this.cancelarAltProdBtn);
            this.panel1.Controls.Add(this.salvarAltProdBtn);
            this.panel1.Controls.Add(this.precoAltProdTbx);
            this.panel1.Controls.Add(this.modeloAltProdTbx);
            this.panel1.Controls.Add(this.marcaAltProdTbx);
            this.panel1.Controls.Add(this.precoAltProdLbl);
            this.panel1.Controls.Add(this.quantidadeAltProdLbl);
            this.panel1.Controls.Add(this.modeloAltProdLbl);
            this.panel1.Controls.Add(this.marcaAltProdLbl);
            this.panel1.Location = new System.Drawing.Point(9, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 360);
            this.panel1.TabIndex = 1;
            // 
            // avisoLbl
            // 
            this.avisoLbl.AutoSize = true;
            this.avisoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoLbl.Location = new System.Drawing.Point(57, 334);
            this.avisoLbl.Name = "avisoLbl";
            this.avisoLbl.Size = new System.Drawing.Size(305, 13);
            this.avisoLbl.TabIndex = 63;
            this.avisoLbl.Text = "[*]Todos os campos com asteriscos são obrigatórios.";
            // 
            // categoriaAltProdCbx
            // 
            this.categoriaAltProdCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaAltProdCbx.FormattingEnabled = true;
            this.categoriaAltProdCbx.Location = new System.Drawing.Point(140, 37);
            this.categoriaAltProdCbx.Name = "categoriaAltProdCbx";
            this.categoriaAltProdCbx.Size = new System.Drawing.Size(111, 21);
            this.categoriaAltProdCbx.TabIndex = 55;
            this.categoriaAltProdCbx.SelectedIndexChanged += new System.EventHandler(this.categoriaAltProdCbx_SelectedIndexChanged_1);
            this.categoriaAltProdCbx.Click += new System.EventHandler(this.categoriaAltProdCbx_DropDown_1);
            // 
            // descricaoAltProdLbl
            // 
            this.descricaoAltProdLbl.AutoSize = true;
            this.descricaoAltProdLbl.Location = new System.Drawing.Point(66, 165);
            this.descricaoAltProdLbl.Name = "descricaoAltProdLbl";
            this.descricaoAltProdLbl.Size = new System.Drawing.Size(68, 13);
            this.descricaoAltProdLbl.TabIndex = 54;
            this.descricaoAltProdLbl.Text = "Descrição * :";
            // 
            // categoriaAltProdLbl
            // 
            this.categoriaAltProdLbl.AutoSize = true;
            this.categoriaAltProdLbl.Location = new System.Drawing.Point(69, 40);
            this.categoriaAltProdLbl.Name = "categoriaAltProdLbl";
            this.categoriaAltProdLbl.Size = new System.Drawing.Size(65, 13);
            this.categoriaAltProdLbl.TabIndex = 53;
            this.categoriaAltProdLbl.Text = "Categoria * :";
            // 
            // descricaoAltProdTbx
            // 
            this.descricaoAltProdTbx.Location = new System.Drawing.Point(140, 162);
            this.descricaoAltProdTbx.Multiline = true;
            this.descricaoAltProdTbx.Name = "descricaoAltProdTbx";
            this.descricaoAltProdTbx.Size = new System.Drawing.Size(299, 87);
            this.descricaoAltProdTbx.TabIndex = 60;
            // 
            // quantidadeAltProdTbx
            // 
            this.quantidadeAltProdTbx.Location = new System.Drawing.Point(339, 79);
            this.quantidadeAltProdTbx.Name = "quantidadeAltProdTbx";
            this.quantidadeAltProdTbx.Size = new System.Drawing.Size(100, 20);
            this.quantidadeAltProdTbx.TabIndex = 57;
            this.quantidadeAltProdTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeAltProdTbx_KeyPress);
            // 
            // cancelarAltProdBtn
            // 
            this.cancelarAltProdBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarAltProdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarAltProdBtn.FlatAppearance.BorderSize = 0;
            this.cancelarAltProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarAltProdBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarAltProdBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarAltProdBtn.Location = new System.Drawing.Point(295, 276);
            this.cancelarAltProdBtn.Name = "cancelarAltProdBtn";
            this.cancelarAltProdBtn.Size = new System.Drawing.Size(144, 44);
            this.cancelarAltProdBtn.TabIndex = 62;
            this.cancelarAltProdBtn.Text = "Cancelar";
            this.cancelarAltProdBtn.UseVisualStyleBackColor = false;
            this.cancelarAltProdBtn.Click += new System.EventHandler(this.cancelarAltProdBtn_Click_1);
            // 
            // salvarAltProdBtn
            // 
            this.salvarAltProdBtn.BackColor = System.Drawing.Color.Teal;
            this.salvarAltProdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarAltProdBtn.FlatAppearance.BorderSize = 0;
            this.salvarAltProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarAltProdBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarAltProdBtn.ForeColor = System.Drawing.Color.White;
            this.salvarAltProdBtn.Location = new System.Drawing.Point(97, 276);
            this.salvarAltProdBtn.Name = "salvarAltProdBtn";
            this.salvarAltProdBtn.Size = new System.Drawing.Size(139, 44);
            this.salvarAltProdBtn.TabIndex = 61;
            this.salvarAltProdBtn.Text = "Salvar";
            this.salvarAltProdBtn.UseVisualStyleBackColor = false;
            this.salvarAltProdBtn.Click += new System.EventHandler(this.salvarAltProdBtn_Click_1);
            // 
            // precoAltProdTbx
            // 
            this.precoAltProdTbx.Location = new System.Drawing.Point(339, 119);
            this.precoAltProdTbx.Name = "precoAltProdTbx";
            this.precoAltProdTbx.Size = new System.Drawing.Size(100, 20);
            this.precoAltProdTbx.TabIndex = 59;
            // 
            // modeloAltProdTbx
            // 
            this.modeloAltProdTbx.Location = new System.Drawing.Point(140, 119);
            this.modeloAltProdTbx.Name = "modeloAltProdTbx";
            this.modeloAltProdTbx.Size = new System.Drawing.Size(111, 20);
            this.modeloAltProdTbx.TabIndex = 58;
            // 
            // marcaAltProdTbx
            // 
            this.marcaAltProdTbx.Location = new System.Drawing.Point(139, 79);
            this.marcaAltProdTbx.Name = "marcaAltProdTbx";
            this.marcaAltProdTbx.Size = new System.Drawing.Size(112, 20);
            this.marcaAltProdTbx.TabIndex = 56;
            // 
            // precoAltProdLbl
            // 
            this.precoAltProdLbl.AutoSize = true;
            this.precoAltProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.precoAltProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoAltProdLbl.Location = new System.Drawing.Point(285, 122);
            this.precoAltProdLbl.Name = "precoAltProdLbl";
            this.precoAltProdLbl.Size = new System.Drawing.Size(48, 13);
            this.precoAltProdLbl.TabIndex = 45;
            this.precoAltProdLbl.Text = "Preco * :";
            // 
            // quantidadeAltProdLbl
            // 
            this.quantidadeAltProdLbl.AutoSize = true;
            this.quantidadeAltProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantidadeAltProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeAltProdLbl.Location = new System.Drawing.Point(258, 82);
            this.quantidadeAltProdLbl.Name = "quantidadeAltProdLbl";
            this.quantidadeAltProdLbl.Size = new System.Drawing.Size(75, 13);
            this.quantidadeAltProdLbl.TabIndex = 44;
            this.quantidadeAltProdLbl.Text = "Quantidade * :";
            // 
            // modeloAltProdLbl
            // 
            this.modeloAltProdLbl.AutoSize = true;
            this.modeloAltProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.modeloAltProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloAltProdLbl.Location = new System.Drawing.Point(79, 122);
            this.modeloAltProdLbl.Name = "modeloAltProdLbl";
            this.modeloAltProdLbl.Size = new System.Drawing.Size(55, 13);
            this.modeloAltProdLbl.TabIndex = 43;
            this.modeloAltProdLbl.Text = "Modelo * :";
            // 
            // marcaAltProdLbl
            // 
            this.marcaAltProdLbl.AutoSize = true;
            this.marcaAltProdLbl.BackColor = System.Drawing.Color.Transparent;
            this.marcaAltProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaAltProdLbl.Location = new System.Drawing.Point(84, 81);
            this.marcaAltProdLbl.Name = "marcaAltProdLbl";
            this.marcaAltProdLbl.Size = new System.Drawing.Size(50, 13);
            this.marcaAltProdLbl.TabIndex = 42;
            this.marcaAltProdLbl.Text = "Marca * :";
            // 
            // AlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.alterarProdutoLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alterarProdutoLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox categoriaAltProdCbx;
        private System.Windows.Forms.Label descricaoAltProdLbl;
        private System.Windows.Forms.Label categoriaAltProdLbl;
        private System.Windows.Forms.TextBox descricaoAltProdTbx;
        private System.Windows.Forms.TextBox quantidadeAltProdTbx;
        private System.Windows.Forms.Button cancelarAltProdBtn;
        private System.Windows.Forms.Button salvarAltProdBtn;
        private System.Windows.Forms.TextBox precoAltProdTbx;
        private System.Windows.Forms.TextBox modeloAltProdTbx;
        private System.Windows.Forms.TextBox marcaAltProdTbx;
        private System.Windows.Forms.Label precoAltProdLbl;
        private System.Windows.Forms.Label quantidadeAltProdLbl;
        private System.Windows.Forms.Label modeloAltProdLbl;
        private System.Windows.Forms.Label marcaAltProdLbl;
        private System.Windows.Forms.Label avisoLbl;
    }
}