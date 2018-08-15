using MySql.Data.MySqlClient;
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
    public partial class LocalizarFornecedor : Form
    {
        private CadastroDeProduto cadastroDeProduto;
        private string _nomeFornecedor;
        public int IdFornecedor { get; set; }
        public LocalizarFornecedor()
        {
            InitializeComponent();
        }
      
        public LocalizarFornecedor(CadastroDeProduto cadastroDeProduto)
        {
            InitializeComponent();
            this.cadastroDeProduto = cadastroDeProduto;
           
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public string NomeFornecedor
        {
            get { return _nomeFornecedor; }
            set
            {
                _nomeFornecedor = value;
            }
        }

        private void localizarFornBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DALFornecedor dALFornecedor = new DALFornecedor();


                if (nomeLocalizaFornTbx.Text == string.Empty)
                {
                    localizaFornecedorGridView.DataSource = dALFornecedor.PesquisarPorCnpj(cnpjLocalizaFornMskBx.Text);
                    alterarNomesCulunasGridView();
                }
                else
                {
                    localizaFornecedorGridView.DataSource = dALFornecedor.PesquisarPorNome(nomeLocalizaFornTbx.Text);
                    alterarNomesCulunasGridView();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void localizaFornecedorGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    IdFornecedor = Convert.ToInt32(localizaFornecedorGridView.Rows[e.RowIndex].Cells[0].Value);
                    NomeFornecedor = Convert.ToString(localizaFornecedorGridView.Rows[e.RowIndex].Cells[1].Value);
                    //this.Close();
                    MessageBox.Show("Fornecedor selecionado!", "Aviso", MessageBoxButtons.OK);

                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
            
        }

        private void localizaFornecedorGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cancelaSelFornBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        public void alterarNomesCulunasGridView()
        {
            localizaFornecedorGridView.Columns[0].HeaderText = "ID Fornecedor";
            localizaFornecedorGridView.Columns[1].HeaderText = "Nome";
            localizaFornecedorGridView.Columns[2].HeaderText = "CNPJ";
            localizaFornecedorGridView.Columns[3].HeaderText = "DDD";
            localizaFornecedorGridView.Columns[4].HeaderText = "Numero";
            localizaFornecedorGridView.Columns[5].HeaderText = "Tpo";
            localizaFornecedorGridView.Columns[6].HeaderText = "Email";

        }

        private void LocalizarFornecedor_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastroFornBtn_Click(object sender, EventArgs e)
        {
            CadastroDeFornecedor cadastroDeFornecedor = new CadastroDeFornecedor();
            cadastroDeFornecedor.Show();
        }

        private void selecionarFornBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NomeFornecedor))
                {
                    cadastroDeProduto.IdFornecedor = IdFornecedor;
                    cadastroDeProduto.NomeFornecedor = NomeFornecedor;
                    cadastroDeProduto.FornecedorNoTextBox();
                    cadastroDeProduto.LiberaCampos();

                    Dispose();
                }
                else
                {
                    MessageBox.Show("Fornecedor não selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaSelFornBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
