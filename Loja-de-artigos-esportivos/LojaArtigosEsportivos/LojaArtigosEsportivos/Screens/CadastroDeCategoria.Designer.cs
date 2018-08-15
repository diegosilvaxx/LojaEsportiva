namespace LojaArtigosEsportivos
{
    partial class CadastroDeCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeCategoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.estadoCategoriaLbl = new System.Windows.Forms.Label();
            this.categoriaLbl = new System.Windows.Forms.Label();
            this.estadoCategoriaCbx = new System.Windows.Forms.ComboBox();
            this.categoriaCadTbx = new System.Windows.Forms.TextBox();
            this.cancelarCadCategoriaBtn = new System.Windows.Forms.Button();
            this.cadastrarCategoriaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.estadoCategoriaLbl);
            this.panel1.Controls.Add(this.categoriaLbl);
            this.panel1.Controls.Add(this.estadoCategoriaCbx);
            this.panel1.Controls.Add(this.categoriaCadTbx);
            this.panel1.Controls.Add(this.cancelarCadCategoriaBtn);
            this.panel1.Controls.Add(this.cadastrarCategoriaBtn);
            this.panel1.Location = new System.Drawing.Point(10, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 369);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "[*]Todos os campos com asteriscos são obrigatórios.";
            // 
            // estadoCategoriaLbl
            // 
            this.estadoCategoriaLbl.AutoSize = true;
            this.estadoCategoriaLbl.BackColor = System.Drawing.Color.Transparent;
            this.estadoCategoriaLbl.Location = new System.Drawing.Point(156, 127);
            this.estadoCategoriaLbl.Name = "estadoCategoriaLbl";
            this.estadoCategoriaLbl.Size = new System.Drawing.Size(44, 13);
            this.estadoCategoriaLbl.TabIndex = 11;
            this.estadoCategoriaLbl.Text = "Ativo * :";
            // 
            // categoriaLbl
            // 
            this.categoriaLbl.AutoSize = true;
            this.categoriaLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoriaLbl.Location = new System.Drawing.Point(135, 70);
            this.categoriaLbl.Name = "categoriaLbl";
            this.categoriaLbl.Size = new System.Drawing.Size(65, 13);
            this.categoriaLbl.TabIndex = 10;
            this.categoriaLbl.Text = "Categoria * :";
            // 
            // estadoCategoriaCbx
            // 
            this.estadoCategoriaCbx.FormattingEnabled = true;
            this.estadoCategoriaCbx.Items.AddRange(new object[] {
            "S",
            "N"});
            this.estadoCategoriaCbx.Location = new System.Drawing.Point(206, 124);
            this.estadoCategoriaCbx.Name = "estadoCategoriaCbx";
            this.estadoCategoriaCbx.Size = new System.Drawing.Size(51, 21);
            this.estadoCategoriaCbx.TabIndex = 9;
            // 
            // categoriaCadTbx
            // 
            this.categoriaCadTbx.Location = new System.Drawing.Point(206, 67);
            this.categoriaCadTbx.Name = "categoriaCadTbx";
            this.categoriaCadTbx.Size = new System.Drawing.Size(100, 20);
            this.categoriaCadTbx.TabIndex = 8;
            // 
            // cancelarCadCategoriaBtn
            // 
            this.cancelarCadCategoriaBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarCadCategoriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarCadCategoriaBtn.FlatAppearance.BorderSize = 0;
            this.cancelarCadCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarCadCategoriaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarCadCategoriaBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarCadCategoriaBtn.Location = new System.Drawing.Point(288, 245);
            this.cancelarCadCategoriaBtn.Name = "cancelarCadCategoriaBtn";
            this.cancelarCadCategoriaBtn.Size = new System.Drawing.Size(120, 49);
            this.cancelarCadCategoriaBtn.TabIndex = 11;
            this.cancelarCadCategoriaBtn.Text = "Cancelar";
            this.cancelarCadCategoriaBtn.UseVisualStyleBackColor = false;
            this.cancelarCadCategoriaBtn.Click += new System.EventHandler(this.cancelarCadCategoriaBtn_Click_1);
            // 
            // cadastrarCategoriaBtn
            // 
            this.cadastrarCategoriaBtn.BackColor = System.Drawing.Color.Teal;
            this.cadastrarCategoriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarCategoriaBtn.FlatAppearance.BorderSize = 0;
            this.cadastrarCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarCategoriaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarCategoriaBtn.ForeColor = System.Drawing.Color.White;
            this.cadastrarCategoriaBtn.Location = new System.Drawing.Point(126, 245);
            this.cadastrarCategoriaBtn.Name = "cadastrarCategoriaBtn";
            this.cadastrarCategoriaBtn.Size = new System.Drawing.Size(120, 49);
            this.cadastrarCategoriaBtn.TabIndex = 10;
            this.cadastrarCategoriaBtn.Text = "Cadastrar";
            this.cadastrarCategoriaBtn.UseVisualStyleBackColor = false;
            this.cadastrarCategoriaBtn.Click += new System.EventHandler(this.cadastrarCategoriaBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Categoria";
            // 
            // CadastroDeCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(558, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroDeCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label estadoCategoriaLbl;
        private System.Windows.Forms.Label categoriaLbl;
        private System.Windows.Forms.ComboBox estadoCategoriaCbx;
        private System.Windows.Forms.TextBox categoriaCadTbx;
        private System.Windows.Forms.Button cancelarCadCategoriaBtn;
        private System.Windows.Forms.Button cadastrarCategoriaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}