namespace LojaArtigosEsportivos
{
    partial class Ajuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajuda));
            this.maisBtn = new System.Windows.Forms.Button();
            this.sairTelaAjudaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maisBtn
            // 
            this.maisBtn.BackColor = System.Drawing.Color.Teal;
            this.maisBtn.FlatAppearance.BorderSize = 0;
            this.maisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maisBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maisBtn.ForeColor = System.Drawing.Color.White;
            this.maisBtn.Location = new System.Drawing.Point(652, 285);
            this.maisBtn.Name = "maisBtn";
            this.maisBtn.Size = new System.Drawing.Size(86, 39);
            this.maisBtn.TabIndex = 0;
            this.maisBtn.Text = "Mais...";
            this.maisBtn.UseVisualStyleBackColor = false;
            this.maisBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sairTelaAjudaBtn
            // 
            this.sairTelaAjudaBtn.BackColor = System.Drawing.Color.Teal;
            this.sairTelaAjudaBtn.FlatAppearance.BorderSize = 0;
            this.sairTelaAjudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairTelaAjudaBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairTelaAjudaBtn.ForeColor = System.Drawing.Color.White;
            this.sairTelaAjudaBtn.Location = new System.Drawing.Point(785, 285);
            this.sairTelaAjudaBtn.Name = "sairTelaAjudaBtn";
            this.sairTelaAjudaBtn.Size = new System.Drawing.Size(86, 39);
            this.sairTelaAjudaBtn.TabIndex = 1;
            this.sairTelaAjudaBtn.Text = "Sair";
            this.sairTelaAjudaBtn.UseVisualStyleBackColor = false;
            this.sairTelaAjudaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 128);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informações";
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.ClientSize = new System.Drawing.Size(895, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sairTelaAjudaBtn);
            this.Controls.Add(this.maisBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maisBtn;
        private System.Windows.Forms.Button sairTelaAjudaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}