namespace LojaArtigosEsportivos
{
    partial class TelaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCategoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.consultaCategoriaGridView = new System.Windows.Forms.DataGridView();
            this.categoriaPesqTbx = new System.Windows.Forms.TextBox();
            this.categoriaPesqLbl = new System.Windows.Forms.Label();
            this.pesquisaCategoriaBtn = new System.Windows.Forms.Button();
            this.cancelarTelaCateBtn = new System.Windows.Forms.Button();
            this.desativarAndAtivarBtn = new System.Windows.Forms.Button();
            this.excluirCategoriaBtn = new System.Windows.Forms.Button();
            this.novaCategoriaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCategoriaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.consultaCategoriaGridView);
            this.panel1.Controls.Add(this.categoriaPesqTbx);
            this.panel1.Controls.Add(this.categoriaPesqLbl);
            this.panel1.Controls.Add(this.pesquisaCategoriaBtn);
            this.panel1.Controls.Add(this.cancelarTelaCateBtn);
            this.panel1.Controls.Add(this.desativarAndAtivarBtn);
            this.panel1.Controls.Add(this.excluirCategoriaBtn);
            this.panel1.Controls.Add(this.novaCategoriaBtn);
            this.panel1.Location = new System.Drawing.Point(9, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 374);
            this.panel1.TabIndex = 0;
            // 
            // consultaCategoriaGridView
            // 
            this.consultaCategoriaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaCategoriaGridView.Location = new System.Drawing.Point(17, 114);
            this.consultaCategoriaGridView.Name = "consultaCategoriaGridView";
            this.consultaCategoriaGridView.ReadOnly = true;
            this.consultaCategoriaGridView.Size = new System.Drawing.Size(511, 161);
            this.consultaCategoriaGridView.TabIndex = 15;
            this.consultaCategoriaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // categoriaPesqTbx
            // 
            this.categoriaPesqTbx.Location = new System.Drawing.Point(150, 61);
            this.categoriaPesqTbx.Name = "categoriaPesqTbx";
            this.categoriaPesqTbx.Size = new System.Drawing.Size(100, 20);
            this.categoriaPesqTbx.TabIndex = 14;
            // 
            // categoriaPesqLbl
            // 
            this.categoriaPesqLbl.AutoSize = true;
            this.categoriaPesqLbl.Location = new System.Drawing.Point(89, 64);
            this.categoriaPesqLbl.Name = "categoriaPesqLbl";
            this.categoriaPesqLbl.Size = new System.Drawing.Size(55, 13);
            this.categoriaPesqLbl.TabIndex = 13;
            this.categoriaPesqLbl.Text = "Categoria:";
            // 
            // pesquisaCategoriaBtn
            // 
            this.pesquisaCategoriaBtn.BackColor = System.Drawing.Color.Teal;
            this.pesquisaCategoriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisaCategoriaBtn.FlatAppearance.BorderSize = 0;
            this.pesquisaCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisaCategoriaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaCategoriaBtn.ForeColor = System.Drawing.Color.White;
            this.pesquisaCategoriaBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA;
            this.pesquisaCategoriaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisaCategoriaBtn.Location = new System.Drawing.Point(299, 40);
            this.pesquisaCategoriaBtn.Name = "pesquisaCategoriaBtn";
            this.pesquisaCategoriaBtn.Size = new System.Drawing.Size(125, 60);
            this.pesquisaCategoriaBtn.TabIndex = 15;
            this.pesquisaCategoriaBtn.Text = "Pesquisar";
            this.pesquisaCategoriaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisaCategoriaBtn.UseVisualStyleBackColor = false;
            this.pesquisaCategoriaBtn.Click += new System.EventHandler(this.pesquisaCategoriaBtn_Click_1);
            // 
            // cancelarTelaCateBtn
            // 
            this.cancelarTelaCateBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaCateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaCateBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaCateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaCateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaCateBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaCateBtn.Location = new System.Drawing.Point(423, 290);
            this.cancelarTelaCateBtn.Name = "cancelarTelaCateBtn";
            this.cancelarTelaCateBtn.Size = new System.Drawing.Size(105, 55);
            this.cancelarTelaCateBtn.TabIndex = 19;
            this.cancelarTelaCateBtn.Text = "Cancelar";
            this.cancelarTelaCateBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaCateBtn.Click += new System.EventHandler(this.cancelarTelaCateBtn_Click_1);
            // 
            // desativarAndAtivarBtn
            // 
            this.desativarAndAtivarBtn.BackColor = System.Drawing.Color.Teal;
            this.desativarAndAtivarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desativarAndAtivarBtn.FlatAppearance.BorderSize = 0;
            this.desativarAndAtivarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desativarAndAtivarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desativarAndAtivarBtn.ForeColor = System.Drawing.Color.White;
            this.desativarAndAtivarBtn.Location = new System.Drawing.Point(270, 290);
            this.desativarAndAtivarBtn.Name = "desativarAndAtivarBtn";
            this.desativarAndAtivarBtn.Size = new System.Drawing.Size(105, 55);
            this.desativarAndAtivarBtn.TabIndex = 18;
            this.desativarAndAtivarBtn.Text = "Desativar/Ativar";
            this.desativarAndAtivarBtn.UseVisualStyleBackColor = false;
            this.desativarAndAtivarBtn.Click += new System.EventHandler(this.desativarAndAtivarBtn_Click_1);
            // 
            // excluirCategoriaBtn
            // 
            this.excluirCategoriaBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirCategoriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirCategoriaBtn.FlatAppearance.BorderSize = 0;
            this.excluirCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirCategoriaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirCategoriaBtn.ForeColor = System.Drawing.Color.White;
            this.excluirCategoriaBtn.Location = new System.Drawing.Point(145, 290);
            this.excluirCategoriaBtn.Name = "excluirCategoriaBtn";
            this.excluirCategoriaBtn.Size = new System.Drawing.Size(105, 55);
            this.excluirCategoriaBtn.TabIndex = 17;
            this.excluirCategoriaBtn.Text = "Excluir";
            this.excluirCategoriaBtn.UseVisualStyleBackColor = false;
            this.excluirCategoriaBtn.Click += new System.EventHandler(this.excluirCategoriaBtn_Click_1);
            // 
            // novaCategoriaBtn
            // 
            this.novaCategoriaBtn.BackColor = System.Drawing.Color.Teal;
            this.novaCategoriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novaCategoriaBtn.FlatAppearance.BorderSize = 0;
            this.novaCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novaCategoriaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaCategoriaBtn.ForeColor = System.Drawing.Color.White;
            this.novaCategoriaBtn.Location = new System.Drawing.Point(17, 290);
            this.novaCategoriaBtn.Name = "novaCategoriaBtn";
            this.novaCategoriaBtn.Size = new System.Drawing.Size(105, 55);
            this.novaCategoriaBtn.TabIndex = 16;
            this.novaCategoriaBtn.Text = "Nova Categoria";
            this.novaCategoriaBtn.UseVisualStyleBackColor = false;
            this.novaCategoriaBtn.Click += new System.EventHandler(this.novaCategoriaBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categoria";
            // 
            // TelaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(566, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCategoriaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView consultaCategoriaGridView;
        private System.Windows.Forms.TextBox categoriaPesqTbx;
        private System.Windows.Forms.Label categoriaPesqLbl;
        private System.Windows.Forms.Button pesquisaCategoriaBtn;
        private System.Windows.Forms.Button cancelarTelaCateBtn;
        private System.Windows.Forms.Button desativarAndAtivarBtn;
        private System.Windows.Forms.Button excluirCategoriaBtn;
        private System.Windows.Forms.Button novaCategoriaBtn;
        private System.Windows.Forms.Label label1;
    }
}