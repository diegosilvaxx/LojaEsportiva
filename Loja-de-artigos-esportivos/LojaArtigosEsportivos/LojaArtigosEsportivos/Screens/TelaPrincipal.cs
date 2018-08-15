using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaArtigosEsportivos
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();

        }
        TelaLogin telaLogin;
        public menuForm(TelaLogin telaLogin)
        {
            InitializeComponent();
            this.telaLogin = telaLogin;
        }

        TelaCliente telaCliente = null;
        TelaFornecedor telaFornecedor = null;
        TelaProduto telaProduto = null;
        TelaVenda telaVenda = null;
        TelaRelatorio telaRelatorio = null;
        TelaUsuario telaUsuario = null;
        TelaCategoria telaCategoria = null;

        void telaCategoria_Disposed(object sender, EventArgs e)
        {
            telaCategoria = null;
        }
        void telaCliente_Disposed(object sender, EventArgs e)
        {
            telaCliente = null;
        }
        void telaFornecedor_Disposed(object sender, EventArgs e)
        {
            telaFornecedor = null;
        }
        void telaProduto_Disposed(object sender, EventArgs e)
        {
            telaProduto = null;
        }
        void telaRelatorio_Disposed(object sender, EventArgs e)
        {
            telaRelatorio = null;
        }
        void telaVenda_Disposed(object sender, EventArgs e)
        {
            telaVenda = null;
        }
        void telaUsuario_Disposed(object sender, EventArgs e)
        {
            telaUsuario = null;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("calc");

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    
        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaProduto frmProduto = new TelaProduto();
            frmProduto.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void alterarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.telaLogin.Show();
            this.telaLogin.fechaTelas();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void telaCategoriaBtn_Click(object sender, EventArgs e)
        {
            if (telaCategoria == null)
            {
                telaCategoria = new TelaCategoria();
                telaCategoria.Disposed += new EventHandler(telaCategoria_Disposed);
                telaCategoria.Show();
            }     
        }

        private void clienteBtn1_Click(object sender, EventArgs e)
        {
            if (telaCliente == null)
            {
                telaCliente = new TelaCliente();
                telaCliente.Disposed += new EventHandler(telaCliente_Disposed);
                telaCliente.Show();
            }
        }

        private void fornecedorBtn1_Click(object sender, EventArgs e)
        {
            if (telaFornecedor == null)
            {
                telaFornecedor = new TelaFornecedor();
                telaFornecedor.Disposed += new EventHandler(telaFornecedor_Disposed);
                telaFornecedor.Show();
            }
        }

        private void produtoBtn1_Click(object sender, EventArgs e)
        {
            if (telaProduto == null)
            {
                telaProduto = new TelaProduto();
                telaProduto.Disposed += new EventHandler(telaProduto_Disposed);
                telaProduto.Show();
            }
        }

        private void vendasBtn1_Click(object sender, EventArgs e)
        {
            if (telaVenda == null)
            {
                telaVenda = new TelaVenda();
                telaVenda.Disposed += new EventHandler(telaVenda_Disposed);
                telaVenda.Show();
            }
        }

        private void relatorioProdVendaBtn1_Click(object sender, EventArgs e)
        {
            if (telaRelatorio == null)
            {
                telaRelatorio = new TelaRelatorio();
                telaRelatorio.Disposed += new EventHandler(telaRelatorio_Disposed);
                telaRelatorio.Show();
            }
        }

        private void cadastroUsuarioBtn1_Click(object sender, EventArgs e)
        {

            if (telaUsuario == null)
            {
                telaUsuario = new TelaUsuario();
                telaUsuario.Disposed += new EventHandler(telaUsuario_Disposed);
                telaUsuario.Show();
            }
        }

        private void sairSistemaBtn1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente sair do sistema?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongDateString();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.ShowDialog();
        }
    }
}
