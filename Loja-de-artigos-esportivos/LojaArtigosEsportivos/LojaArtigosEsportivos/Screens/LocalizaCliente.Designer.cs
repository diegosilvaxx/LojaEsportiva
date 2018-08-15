namespace LojaArtigosEsportivos
{
    partial class LocalizaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizaCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cadastroClienteBtn = new System.Windows.Forms.Button();
            this.cpfLocalizaClienteMskBx = new System.Windows.Forms.MaskedTextBox();
            this.cancelaLocalizaClienteBtn = new System.Windows.Forms.Button();
            this.selecionaClienteBtn = new System.Windows.Forms.Button();
            this.localizaClienteGridView = new System.Windows.Forms.DataGridView();
            this.nomeLocalizaClientTbx = new System.Windows.Forms.TextBox();
            this.nomeLocalizaClienteLbl = new System.Windows.Forms.Label();
            this.cpfLocalizaClienteLbl = new System.Windows.Forms.Label();
            this.localizarClienteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizaClienteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consultar Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cadastroClienteBtn);
            this.panel1.Controls.Add(this.cpfLocalizaClienteMskBx);
            this.panel1.Controls.Add(this.cancelaLocalizaClienteBtn);
            this.panel1.Controls.Add(this.selecionaClienteBtn);
            this.panel1.Controls.Add(this.localizaClienteGridView);
            this.panel1.Controls.Add(this.nomeLocalizaClientTbx);
            this.panel1.Controls.Add(this.nomeLocalizaClienteLbl);
            this.panel1.Controls.Add(this.cpfLocalizaClienteLbl);
            this.panel1.Controls.Add(this.localizarClienteBtn);
            this.panel1.Location = new System.Drawing.Point(9, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 406);
            this.panel1.TabIndex = 10;
            // 
            // cadastroClienteBtn
            // 
            this.cadastroClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.cadastroClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastroClienteBtn.FlatAppearance.BorderSize = 0;
            this.cadastroClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroClienteBtn.ForeColor = System.Drawing.Color.White;
            this.cadastroClienteBtn.Location = new System.Drawing.Point(16, 332);
            this.cadastroClienteBtn.Name = "cadastroClienteBtn";
            this.cadastroClienteBtn.Size = new System.Drawing.Size(105, 57);
            this.cadastroClienteBtn.TabIndex = 21;
            this.cadastroClienteBtn.Text = "Novo Cliente";
            this.cadastroClienteBtn.UseVisualStyleBackColor = false;
            this.cadastroClienteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpfLocalizaClienteMskBx
            // 
            this.cpfLocalizaClienteMskBx.Location = new System.Drawing.Point(152, 21);
            this.cpfLocalizaClienteMskBx.Mask = "000.000.000-00";
            this.cpfLocalizaClienteMskBx.Name = "cpfLocalizaClienteMskBx";
            this.cpfLocalizaClienteMskBx.Size = new System.Drawing.Size(120, 20);
            this.cpfLocalizaClienteMskBx.TabIndex = 16;
            this.cpfLocalizaClienteMskBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cancelaLocalizaClienteBtn
            // 
            this.cancelaLocalizaClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelaLocalizaClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelaLocalizaClienteBtn.FlatAppearance.BorderSize = 0;
            this.cancelaLocalizaClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelaLocalizaClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelaLocalizaClienteBtn.ForeColor = System.Drawing.Color.White;
            this.cancelaLocalizaClienteBtn.Location = new System.Drawing.Point(440, 332);
            this.cancelaLocalizaClienteBtn.Name = "cancelaLocalizaClienteBtn";
            this.cancelaLocalizaClienteBtn.Size = new System.Drawing.Size(103, 57);
            this.cancelaLocalizaClienteBtn.TabIndex = 20;
            this.cancelaLocalizaClienteBtn.Text = "Cancelar";
            this.cancelaLocalizaClienteBtn.UseVisualStyleBackColor = false;
            this.cancelaLocalizaClienteBtn.Click += new System.EventHandler(this.cancelaLocalizaClienteBtn_Click);
            // 
            // selecionaClienteBtn
            // 
            this.selecionaClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.selecionaClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selecionaClienteBtn.FlatAppearance.BorderSize = 0;
            this.selecionaClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecionaClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionaClienteBtn.ForeColor = System.Drawing.Color.White;
            this.selecionaClienteBtn.Location = new System.Drawing.Point(303, 332);
            this.selecionaClienteBtn.Name = "selecionaClienteBtn";
            this.selecionaClienteBtn.Size = new System.Drawing.Size(105, 57);
            this.selecionaClienteBtn.TabIndex = 19;
            this.selecionaClienteBtn.Text = "Selecionar";
            this.selecionaClienteBtn.UseVisualStyleBackColor = false;
            this.selecionaClienteBtn.Click += new System.EventHandler(this.selecionaClienteBtn_Click);
            // 
            // localizaClienteGridView
            // 
            this.localizaClienteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localizaClienteGridView.Location = new System.Drawing.Point(16, 108);
            this.localizaClienteGridView.Name = "localizaClienteGridView";
            this.localizaClienteGridView.ReadOnly = true;
            this.localizaClienteGridView.Size = new System.Drawing.Size(527, 218);
            this.localizaClienteGridView.TabIndex = 13;
            this.localizaClienteGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.localizaClienteGridView_CellDoubleClick);
            // 
            // nomeLocalizaClientTbx
            // 
            this.nomeLocalizaClientTbx.Location = new System.Drawing.Point(152, 59);
            this.nomeLocalizaClientTbx.Name = "nomeLocalizaClientTbx";
            this.nomeLocalizaClientTbx.Size = new System.Drawing.Size(120, 20);
            this.nomeLocalizaClientTbx.TabIndex = 17;
            // 
            // nomeLocalizaClienteLbl
            // 
            this.nomeLocalizaClienteLbl.AutoSize = true;
            this.nomeLocalizaClienteLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeLocalizaClienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLocalizaClienteLbl.Location = new System.Drawing.Point(108, 62);
            this.nomeLocalizaClienteLbl.Name = "nomeLocalizaClienteLbl";
            this.nomeLocalizaClienteLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeLocalizaClienteLbl.TabIndex = 11;
            this.nomeLocalizaClienteLbl.Text = "Nome:";
            // 
            // cpfLocalizaClienteLbl
            // 
            this.cpfLocalizaClienteLbl.AutoSize = true;
            this.cpfLocalizaClienteLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpfLocalizaClienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLocalizaClienteLbl.Location = new System.Drawing.Point(116, 24);
            this.cpfLocalizaClienteLbl.Name = "cpfLocalizaClienteLbl";
            this.cpfLocalizaClienteLbl.Size = new System.Drawing.Size(30, 13);
            this.cpfLocalizaClienteLbl.TabIndex = 10;
            this.cpfLocalizaClienteLbl.Text = "CPF:";
            // 
            // localizarClienteBtn
            // 
            this.localizarClienteBtn.AutoSize = true;
            this.localizarClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.localizarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.localizarClienteBtn.FlatAppearance.BorderSize = 0;
            this.localizarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localizarClienteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizarClienteBtn.ForeColor = System.Drawing.Color.White;
            this.localizarClienteBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.localizarClienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizarClienteBtn.Location = new System.Drawing.Point(320, 24);
            this.localizarClienteBtn.Name = "localizarClienteBtn";
            this.localizarClienteBtn.Size = new System.Drawing.Size(115, 53);
            this.localizarClienteBtn.TabIndex = 18;
            this.localizarClienteBtn.Text = "Localizar";
            this.localizarClienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.localizarClienteBtn.UseVisualStyleBackColor = false;
            this.localizarClienteBtn.Click += new System.EventHandler(this.localizarClienteBtn_Click);
            // 
            // LocalizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizaClienteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cpfLocalizaClienteMskBx;
        public System.Windows.Forms.Button cancelaLocalizaClienteBtn;
        public System.Windows.Forms.Button selecionaClienteBtn;
        private System.Windows.Forms.DataGridView localizaClienteGridView;
        private System.Windows.Forms.TextBox nomeLocalizaClientTbx;
        private System.Windows.Forms.Label nomeLocalizaClienteLbl;
        private System.Windows.Forms.Label cpfLocalizaClienteLbl;
        private System.Windows.Forms.Button localizarClienteBtn;
        public System.Windows.Forms.Button cadastroClienteBtn;
    }
}