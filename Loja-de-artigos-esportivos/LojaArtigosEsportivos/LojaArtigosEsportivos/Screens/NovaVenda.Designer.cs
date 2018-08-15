namespace LojaArtigosEsportivos
{
    partial class NovaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.efetuaVendaLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.excluirCarrinhoBtn = new System.Windows.Forms.Button();
            this.avisoLbl = new System.Windows.Forms.Label();
            this.idProdutoVendaTbx = new System.Windows.Forms.TextBox();
            this.idProdutoVendaLbl = new System.Windows.Forms.Label();
            this.descricaoProdVendaTbx = new System.Windows.Forms.TextBox();
            this.descricaoProdVendaLbl = new System.Windows.Forms.Label();
            this.cancelarTelaVendaBtn = new System.Windows.Forms.Button();
            this.finalizaVendaBtn = new System.Windows.Forms.Button();
            this.adcCarrinhoVendaBtn = new System.Windows.Forms.Button();
            this.valorTotalVendaTbx = new System.Windows.Forms.TextBox();
            this.valorTotalVendaLbl = new System.Windows.Forms.Label();
            this.consultaCarrinhoVendaGridView = new System.Windows.Forms.DataGridView();
            this.id_produtoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaVendaCbx = new System.Windows.Forms.ComboBox();
            this.qtdVendaLbl = new System.Windows.Forms.Label();
            this.categoriaVendaLbl = new System.Windows.Forms.Label();
            this.modeloProdutoVendaCbx = new System.Windows.Forms.ComboBox();
            this.qtdVendaTbx = new System.Windows.Forms.TextBox();
            this.nomeClienteVendaTbx = new System.Windows.Forms.TextBox();
            this.localizaClienteBtn = new System.Windows.Forms.Button();
            this.modeloProdutoVendaLbl = new System.Windows.Forms.Label();
            this.nomeClienteVendaLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCarrinhoVendaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // efetuaVendaLbl
            // 
            this.efetuaVendaLbl.AutoSize = true;
            this.efetuaVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.efetuaVendaLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efetuaVendaLbl.Location = new System.Drawing.Point(293, 9);
            this.efetuaVendaLbl.Name = "efetuaVendaLbl";
            this.efetuaVendaLbl.Size = new System.Drawing.Size(164, 25);
            this.efetuaVendaLbl.TabIndex = 19;
            this.efetuaVendaLbl.Text = "Efetuar Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.excluirCarrinhoBtn);
            this.panel1.Controls.Add(this.avisoLbl);
            this.panel1.Controls.Add(this.idProdutoVendaTbx);
            this.panel1.Controls.Add(this.idProdutoVendaLbl);
            this.panel1.Controls.Add(this.descricaoProdVendaTbx);
            this.panel1.Controls.Add(this.descricaoProdVendaLbl);
            this.panel1.Controls.Add(this.cancelarTelaVendaBtn);
            this.panel1.Controls.Add(this.finalizaVendaBtn);
            this.panel1.Controls.Add(this.adcCarrinhoVendaBtn);
            this.panel1.Controls.Add(this.valorTotalVendaTbx);
            this.panel1.Controls.Add(this.valorTotalVendaLbl);
            this.panel1.Controls.Add(this.consultaCarrinhoVendaGridView);
            this.panel1.Controls.Add(this.categoriaVendaCbx);
            this.panel1.Controls.Add(this.qtdVendaLbl);
            this.panel1.Controls.Add(this.categoriaVendaLbl);
            this.panel1.Controls.Add(this.modeloProdutoVendaCbx);
            this.panel1.Controls.Add(this.qtdVendaTbx);
            this.panel1.Controls.Add(this.nomeClienteVendaTbx);
            this.panel1.Controls.Add(this.localizaClienteBtn);
            this.panel1.Controls.Add(this.modeloProdutoVendaLbl);
            this.panel1.Controls.Add(this.nomeClienteVendaLbl);
            this.panel1.Location = new System.Drawing.Point(9, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 474);
            this.panel1.TabIndex = 20;
            // 
            // excluirCarrinhoBtn
            // 
            this.excluirCarrinhoBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirCarrinhoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirCarrinhoBtn.FlatAppearance.BorderSize = 0;
            this.excluirCarrinhoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirCarrinhoBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirCarrinhoBtn.ForeColor = System.Drawing.Color.White;
            this.excluirCarrinhoBtn.Location = new System.Drawing.Point(544, 160);
            this.excluirCarrinhoBtn.Name = "excluirCarrinhoBtn";
            this.excluirCarrinhoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.excluirCarrinhoBtn.Size = new System.Drawing.Size(96, 49);
            this.excluirCarrinhoBtn.TabIndex = 102;
            this.excluirCarrinhoBtn.Text = "Excluir do Carrinho";
            this.excluirCarrinhoBtn.UseVisualStyleBackColor = false;
            this.excluirCarrinhoBtn.Click += new System.EventHandler(this.excluirCarrinhoBtn_Click);
            // 
            // avisoLbl
            // 
            this.avisoLbl.AutoSize = true;
            this.avisoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoLbl.Location = new System.Drawing.Point(83, 190);
            this.avisoLbl.Name = "avisoLbl";
            this.avisoLbl.Size = new System.Drawing.Size(305, 13);
            this.avisoLbl.TabIndex = 101;
            this.avisoLbl.Text = "[*]Todos os campos com asteriscos são obrigatórios.";
            // 
            // idProdutoVendaTbx
            // 
            this.idProdutoVendaTbx.Location = new System.Drawing.Point(525, 93);
            this.idProdutoVendaTbx.Name = "idProdutoVendaTbx";
            this.idProdutoVendaTbx.ReadOnly = true;
            this.idProdutoVendaTbx.Size = new System.Drawing.Size(100, 20);
            this.idProdutoVendaTbx.TabIndex = 43;
            // 
            // idProdutoVendaLbl
            // 
            this.idProdutoVendaLbl.AutoSize = true;
            this.idProdutoVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.idProdutoVendaLbl.Location = new System.Drawing.Point(458, 96);
            this.idProdutoVendaLbl.Name = "idProdutoVendaLbl";
            this.idProdutoVendaLbl.Size = new System.Drawing.Size(61, 13);
            this.idProdutoVendaLbl.TabIndex = 51;
            this.idProdutoVendaLbl.Text = "ID Produto:";
            // 
            // descricaoProdVendaTbx
            // 
            this.descricaoProdVendaTbx.Location = new System.Drawing.Point(161, 93);
            this.descricaoProdVendaTbx.Multiline = true;
            this.descricaoProdVendaTbx.Name = "descricaoProdVendaTbx";
            this.descricaoProdVendaTbx.ReadOnly = true;
            this.descricaoProdVendaTbx.Size = new System.Drawing.Size(275, 84);
            this.descricaoProdVendaTbx.TabIndex = 42;
            // 
            // descricaoProdVendaLbl
            // 
            this.descricaoProdVendaLbl.AutoSize = true;
            this.descricaoProdVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.descricaoProdVendaLbl.Location = new System.Drawing.Point(102, 96);
            this.descricaoProdVendaLbl.Name = "descricaoProdVendaLbl";
            this.descricaoProdVendaLbl.Size = new System.Drawing.Size(58, 13);
            this.descricaoProdVendaLbl.TabIndex = 49;
            this.descricaoProdVendaLbl.Text = "Descrição:";
            // 
            // cancelarTelaVendaBtn
            // 
            this.cancelarTelaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaVendaBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaVendaBtn.Location = new System.Drawing.Point(531, 421);
            this.cancelarTelaVendaBtn.Name = "cancelarTelaVendaBtn";
            this.cancelarTelaVendaBtn.Size = new System.Drawing.Size(109, 29);
            this.cancelarTelaVendaBtn.TabIndex = 48;
            this.cancelarTelaVendaBtn.Text = "Cancelar";
            this.cancelarTelaVendaBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaVendaBtn.Click += new System.EventHandler(this.cancelarTelaVendaBtn_Click);
            // 
            // finalizaVendaBtn
            // 
            this.finalizaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.finalizaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizaVendaBtn.FlatAppearance.BorderSize = 0;
            this.finalizaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizaVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.finalizaVendaBtn.Location = new System.Drawing.Point(396, 421);
            this.finalizaVendaBtn.Name = "finalizaVendaBtn";
            this.finalizaVendaBtn.Size = new System.Drawing.Size(109, 29);
            this.finalizaVendaBtn.TabIndex = 45;
            this.finalizaVendaBtn.Text = "Finalizar Venda";
            this.finalizaVendaBtn.UseVisualStyleBackColor = false;
            this.finalizaVendaBtn.Click += new System.EventHandler(this.finalizaVendaBtn_Click_1);
            // 
            // adcCarrinhoVendaBtn
            // 
            this.adcCarrinhoVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.adcCarrinhoVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adcCarrinhoVendaBtn.FlatAppearance.BorderSize = 0;
            this.adcCarrinhoVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adcCarrinhoVendaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adcCarrinhoVendaBtn.ForeColor = System.Drawing.Color.White;
            this.adcCarrinhoVendaBtn.Location = new System.Drawing.Point(442, 160);
            this.adcCarrinhoVendaBtn.Name = "adcCarrinhoVendaBtn";
            this.adcCarrinhoVendaBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adcCarrinhoVendaBtn.Size = new System.Drawing.Size(96, 49);
            this.adcCarrinhoVendaBtn.TabIndex = 44;
            this.adcCarrinhoVendaBtn.Text = "Adiciona ao Carrinho";
            this.adcCarrinhoVendaBtn.UseVisualStyleBackColor = false;
            this.adcCarrinhoVendaBtn.Click += new System.EventHandler(this.adcCarrinhoVendaBtn_Click_1);
            // 
            // valorTotalVendaTbx
            // 
            this.valorTotalVendaTbx.Enabled = false;
            this.valorTotalVendaTbx.Location = new System.Drawing.Point(171, 425);
            this.valorTotalVendaTbx.Name = "valorTotalVendaTbx";
            this.valorTotalVendaTbx.Size = new System.Drawing.Size(100, 20);
            this.valorTotalVendaTbx.TabIndex = 100;
            // 
            // valorTotalVendaLbl
            // 
            this.valorTotalVendaLbl.AutoSize = true;
            this.valorTotalVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.valorTotalVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalVendaLbl.Location = new System.Drawing.Point(92, 428);
            this.valorTotalVendaLbl.Name = "valorTotalVendaLbl";
            this.valorTotalVendaLbl.Size = new System.Drawing.Size(73, 13);
            this.valorTotalVendaLbl.TabIndex = 44;
            this.valorTotalVendaLbl.Text = "Valor Total:";
            // 
            // consultaCarrinhoVendaGridView
            // 
            this.consultaCarrinhoVendaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaCarrinhoVendaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produtoEstoque,
            this.categoria,
            this.modelo,
            this.quantidade,
            this.preco,
            this.quantidade_estoque});
            this.consultaCarrinhoVendaGridView.Location = new System.Drawing.Point(86, 215);
            this.consultaCarrinhoVendaGridView.Name = "consultaCarrinhoVendaGridView";
            this.consultaCarrinhoVendaGridView.ReadOnly = true;
            this.consultaCarrinhoVendaGridView.Size = new System.Drawing.Size(554, 193);
            this.consultaCarrinhoVendaGridView.TabIndex = 43;
            this.consultaCarrinhoVendaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaCarrinhoVendaGridView_CellDoubleClick);
            // 
            // id_produtoEstoque
            // 
            this.id_produtoEstoque.HeaderText = "Id Produto no Estoque";
            this.id_produtoEstoque.Name = "id_produtoEstoque";
            this.id_produtoEstoque.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // quantidade_estoque
            // 
            this.quantidade_estoque.HeaderText = "Quantidade No Estoque";
            this.quantidade_estoque.Name = "quantidade_estoque";
            this.quantidade_estoque.ReadOnly = true;
            // 
            // categoriaVendaCbx
            // 
            this.categoriaVendaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaVendaCbx.FormattingEnabled = true;
            this.categoriaVendaCbx.Location = new System.Drawing.Point(162, 66);
            this.categoriaVendaCbx.Name = "categoriaVendaCbx";
            this.categoriaVendaCbx.Size = new System.Drawing.Size(121, 21);
            this.categoriaVendaCbx.TabIndex = 39;
            this.categoriaVendaCbx.SelectedIndexChanged += new System.EventHandler(this.categoriaVendaCbx_SelectedIndexChanged_1);
            this.categoriaVendaCbx.SelectedValueChanged += new System.EventHandler(this.categoriaVendaCbx_SelectedValueChanged_1);
            this.categoriaVendaCbx.Click += new System.EventHandler(this.categoriaVendaCbx_DropDown_1);
            // 
            // qtdVendaLbl
            // 
            this.qtdVendaLbl.AutoSize = true;
            this.qtdVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.qtdVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdVendaLbl.Location = new System.Drawing.Point(483, 69);
            this.qtdVendaLbl.Name = "qtdVendaLbl";
            this.qtdVendaLbl.Size = new System.Drawing.Size(75, 13);
            this.qtdVendaLbl.TabIndex = 41;
            this.qtdVendaLbl.Text = "Quantidade * :";
            // 
            // categoriaVendaLbl
            // 
            this.categoriaVendaLbl.AutoSize = true;
            this.categoriaVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoriaVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaVendaLbl.Location = new System.Drawing.Point(95, 68);
            this.categoriaVendaLbl.Name = "categoriaVendaLbl";
            this.categoriaVendaLbl.Size = new System.Drawing.Size(65, 13);
            this.categoriaVendaLbl.TabIndex = 40;
            this.categoriaVendaLbl.Text = "Categoria * :";
            // 
            // modeloProdutoVendaCbx
            // 
            this.modeloProdutoVendaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeloProdutoVendaCbx.FormattingEnabled = true;
            this.modeloProdutoVendaCbx.Location = new System.Drawing.Point(345, 65);
            this.modeloProdutoVendaCbx.Name = "modeloProdutoVendaCbx";
            this.modeloProdutoVendaCbx.Size = new System.Drawing.Size(132, 21);
            this.modeloProdutoVendaCbx.TabIndex = 40;
            this.modeloProdutoVendaCbx.SelectedIndexChanged += new System.EventHandler(this.modeloProdutoVendaCbx_SelectedIndexChanged_1);
            this.modeloProdutoVendaCbx.Click += new System.EventHandler(this.comboBox1_DropDown_1);
            // 
            // qtdVendaTbx
            // 
            this.qtdVendaTbx.Location = new System.Drawing.Point(564, 65);
            this.qtdVendaTbx.Name = "qtdVendaTbx";
            this.qtdVendaTbx.Size = new System.Drawing.Size(61, 20);
            this.qtdVendaTbx.TabIndex = 41;
            this.qtdVendaTbx.Text = "0";
            this.qtdVendaTbx.TextChanged += new System.EventHandler(this.qtdVendaTbx_TextChanged_1);
            this.qtdVendaTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtdVendaTbx_KeyPress);
            // 
            // nomeClienteVendaTbx
            // 
            this.nomeClienteVendaTbx.Enabled = false;
            this.nomeClienteVendaTbx.Location = new System.Drawing.Point(161, 27);
            this.nomeClienteVendaTbx.Name = "nomeClienteVendaTbx";
            this.nomeClienteVendaTbx.Size = new System.Drawing.Size(275, 20);
            this.nomeClienteVendaTbx.TabIndex = 37;
            // 
            // localizaClienteBtn
            // 
            this.localizaClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.localizaClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.localizaClienteBtn.FlatAppearance.BorderSize = 0;
            this.localizaClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localizaClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizaClienteBtn.ForeColor = System.Drawing.Color.White;
            this.localizaClienteBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.localizaClienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizaClienteBtn.Location = new System.Drawing.Point(442, 18);
            this.localizaClienteBtn.Name = "localizaClienteBtn";
            this.localizaClienteBtn.Size = new System.Drawing.Size(119, 36);
            this.localizaClienteBtn.TabIndex = 38;
            this.localizaClienteBtn.Text = "Localizar";
            this.localizaClienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.localizaClienteBtn.UseVisualStyleBackColor = false;
            this.localizaClienteBtn.Click += new System.EventHandler(this.localizaClienteBtn_Click_1);
            // 
            // modeloProdutoVendaLbl
            // 
            this.modeloProdutoVendaLbl.AutoSize = true;
            this.modeloProdutoVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.modeloProdutoVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloProdutoVendaLbl.Location = new System.Drawing.Point(285, 68);
            this.modeloProdutoVendaLbl.Name = "modeloProdutoVendaLbl";
            this.modeloProdutoVendaLbl.Size = new System.Drawing.Size(55, 13);
            this.modeloProdutoVendaLbl.TabIndex = 35;
            this.modeloProdutoVendaLbl.Text = "Modelo * :";
            // 
            // nomeClienteVendaLbl
            // 
            this.nomeClienteVendaLbl.AutoSize = true;
            this.nomeClienteVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeClienteVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteVendaLbl.Location = new System.Drawing.Point(77, 30);
            this.nomeClienteVendaLbl.Name = "nomeClienteVendaLbl";
            this.nomeClienteVendaLbl.Size = new System.Drawing.Size(83, 13);
            this.nomeClienteVendaLbl.TabIndex = 34;
            this.nomeClienteVendaLbl.Text = "Nome Cliente * :";
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.efetuaVendaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar Vendas";
            this.Load += new System.EventHandler(this.NovaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCarrinhoVendaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label efetuaVendaLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idProdutoVendaTbx;
        private System.Windows.Forms.Label idProdutoVendaLbl;
        private System.Windows.Forms.TextBox descricaoProdVendaTbx;
        private System.Windows.Forms.Label descricaoProdVendaLbl;
        private System.Windows.Forms.Button cancelarTelaVendaBtn;
        private System.Windows.Forms.Button finalizaVendaBtn;
        private System.Windows.Forms.Button adcCarrinhoVendaBtn;
        private System.Windows.Forms.TextBox valorTotalVendaTbx;
        private System.Windows.Forms.Label valorTotalVendaLbl;
        private System.Windows.Forms.DataGridView consultaCarrinhoVendaGridView;
        private System.Windows.Forms.ComboBox categoriaVendaCbx;
        private System.Windows.Forms.Label qtdVendaLbl;
        private System.Windows.Forms.Label categoriaVendaLbl;
        private System.Windows.Forms.ComboBox modeloProdutoVendaCbx;
        private System.Windows.Forms.TextBox qtdVendaTbx;
        private System.Windows.Forms.TextBox nomeClienteVendaTbx;
        private System.Windows.Forms.Button localizaClienteBtn;
        private System.Windows.Forms.Label modeloProdutoVendaLbl;
        private System.Windows.Forms.Label nomeClienteVendaLbl;
        private System.Windows.Forms.Label avisoLbl;
        private System.Windows.Forms.Button excluirCarrinhoBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produtoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_estoque;
    }
}