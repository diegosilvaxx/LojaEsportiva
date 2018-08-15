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
    public partial class TelaProduto : Form
    {
        public string tipoProduto { get; set; }
        public TelaProduto()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int CodigoProduto { get; set; }
        CadastroDeProduto selecionarProdudoCadastro = null;
        AlterarProduto alterarProduto = null;
        void selecionarProdudoCadastro_Disposed_1(object sender, EventArgs e)
        {
            selecionarProdudoCadastro = null;
        }
        void alterarProduto_Disposed_1(object sender, EventArgs e)
        {
            alterarProduto = null;
        }
        private void novoProdutoBtn_Click_1(object sender, EventArgs e)
        {
            if (selecionarProdudoCadastro == null)
            {
                selecionarProdudoCadastro = new CadastroDeProduto();
                selecionarProdudoCadastro.Disposed += new EventHandler(selecionarProdudoCadastro_Disposed_1);
                selecionarProdudoCadastro.Show();
            }
        }

        private void pesquisarProdutoBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DALProduto dALProduto = new DALProduto();

                if (marcaPesqTbx.Text == string.Empty)
                {
                    consultarProdutoCadGridView.DataSource = dALProduto.PesquisarPorModelo(modeloPesqTbx.Text);
                    alterarNomesCulunasGridView();
                }
                else
                {
                    consultarProdutoCadGridView.DataSource = dALProduto.PesquisarPorMarca(marcaPesqTbx.Text);
                    alterarNomesCulunasGridView();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarTelaProdBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        public void alterarNomesCulunasGridView()
        {
            consultarProdutoCadGridView.Columns[0].HeaderText = "ID Produto";
            consultarProdutoCadGridView.Columns[1].HeaderText = "Modelo";
            consultarProdutoCadGridView.Columns[2].HeaderText = "Preço";
            consultarProdutoCadGridView.Columns[3].HeaderText = "Quantidade";
            consultarProdutoCadGridView.Columns[4].HeaderText = "Descrição";
            consultarProdutoCadGridView.Columns[5].HeaderText = "Categoria";
            consultarProdutoCadGridView.Columns[6].HeaderText = "Marca";
            consultarProdutoCadGridView.Columns[7].HeaderText = "Nome Fornecedor";
            consultarProdutoCadGridView.Columns[8].HeaderText = "ID Fornecedor";
            consultarProdutoCadGridView.Columns[9].HeaderText = "ID categoria";
            consultarProdutoCadGridView.AutoResizeColumns();
        }


        private void excluirProdutoBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((CodigoProduto != 0))
                {

                    if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Produto produto = new Produto();
                        produto.IdProduto = CodigoProduto;
                        DALProduto dALProduto = new DALProduto();
                        dALProduto.Excluir(produto.IdProduto);
                        consultarProdutoCadGridView.DataSource = dALProduto.Pesquisar();
                        CodigoProduto = 0;
                        MessageBox.Show("Produto excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou produto não selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultarProdutoCadGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    CodigoProduto = Convert.ToInt32(consultarProdutoCadGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Produto selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }

        }

        private void alterarProdutoBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CodigoProduto != 0)
                {
                    if (alterarProduto == null)
                    {
                        alterarProduto = new AlterarProduto(CodigoProduto, tipoProduto);
                        alterarProduto.Disposed += new EventHandler(alterarProduto_Disposed_1);
                        alterarProduto.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tabela vazia ou produto nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
