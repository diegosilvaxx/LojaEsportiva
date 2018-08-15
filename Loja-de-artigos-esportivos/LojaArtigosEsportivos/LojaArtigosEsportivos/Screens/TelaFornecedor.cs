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
    public partial class TelaFornecedor : Form
    {
        private int _codigoFornecedor = 0;
        public TelaFornecedor()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int CodigoFornecedor
        {
            get { return _codigoFornecedor; }
            set { _codigoFornecedor = value; }
        }
        CadastroDeFornecedor cadastroDeFornecedor = null;
        AlterarFornecedor alterarFornecedor = null;
        void cadastroDeFornecedor_Disposed(object sender, EventArgs e)
        {
            cadastroDeFornecedor = null;
        }
        void alterarFornecedor_Disposed(object sender, EventArgs e)
        {
            alterarFornecedor = null;
        }

        private void novoFornecedorBtn_Click_1(object sender, EventArgs e)
        {
            if (cadastroDeFornecedor == null)
            {
                cadastroDeFornecedor = new CadastroDeFornecedor();
                cadastroDeFornecedor.Disposed += new EventHandler(cadastroDeFornecedor_Disposed);
                cadastroDeFornecedor.Show();
            }
        }

        private void pesquisarFornecedorBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DALFornecedor dALFornecedor = new DALFornecedor();


                if (pesquisaNomeFornTbx.Text == string.Empty)
                {
                    consultaFonecedorGridView.DataSource = dALFornecedor.PesquisarPorCnpj(pesquisaCnpjFornMskBox.Text);
                    alterarNomesCulunasGridView();
                }
                else
                {
                    consultaFonecedorGridView.DataSource = dALFornecedor.PesquisarPorNome(pesquisaNomeFornTbx.Text);
                    alterarNomesCulunasGridView();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaFonecedorGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    CodigoFornecedor = Convert.ToInt32(consultaFonecedorGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Fornecedor selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
           
        }

        private void excluirFornecedorBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((CodigoFornecedor != 0))
                {
                    if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.IdFornecedor = CodigoFornecedor;
                        DALFornecedor dALFornecedor = new DALFornecedor();
                        dALFornecedor.Excluir(fornecedor.IdFornecedor);
                        consultaFonecedorGridView.DataSource = dALFornecedor.Pesquisar();
                        CodigoFornecedor = 0;
                        MessageBox.Show("Fornecedor excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou fornecedor nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarFornecedorBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CodigoFornecedor != 0)
                {                
                    if (alterarFornecedor == null)
                    {
                        alterarFornecedor = new AlterarFornecedor(CodigoFornecedor);
                        alterarFornecedor.Disposed += new EventHandler(alterarFornecedor_Disposed);
                        alterarFornecedor.Show();
                    }

                    DALFornecedor dALFornecedor = new DALFornecedor();
                    Fornecedor fornecedor = dALFornecedor.carregaFornecedor(CodigoFornecedor);

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou fornecedor nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarTelaFornBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void alterarNomesCulunasGridView()
        {
            consultaFonecedorGridView.Columns[0].HeaderText = "ID Fornecedor";
            consultaFonecedorGridView.Columns[1].HeaderText = "Nome";
            consultaFonecedorGridView.Columns[2].HeaderText = "CNPJ";
            consultaFonecedorGridView.Columns[3].HeaderText = "DDD";
            consultaFonecedorGridView.Columns[4].HeaderText = "Numero";
            consultaFonecedorGridView.Columns[5].HeaderText = "Tipo";
            consultaFonecedorGridView.Columns[6].HeaderText = "Email";
            consultaFonecedorGridView.AutoResizeColumns();
        }


    }
}
