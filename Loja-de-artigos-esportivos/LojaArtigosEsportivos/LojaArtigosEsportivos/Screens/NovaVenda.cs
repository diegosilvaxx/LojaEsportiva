using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaArtigosEsportivos
{
    public partial class NovaVenda : Form
    {
        public NovaVenda()
        {
            InitializeComponent();
            modeloProdutoVendaCbx.Enabled = false;
            qtdVendaTbx.Enabled = false;
            categoriaVendaCbx.Visible = false;
            modeloProdutoVendaCbx.Visible = false;
            qtdVendaTbx.Visible = false;
            categoriaVendaLbl.Visible = false;
            modeloProdutoVendaLbl.Visible = false;
            qtdVendaLbl.Visible = false;
            finalizaVendaBtn.Enabled = false;
            descricaoProdVendaLbl.Visible = false;
            descricaoProdVendaTbx.Visible = false;
            idProdutoVendaLbl.Visible = false;
            idProdutoVendaTbx.Visible = false;
            adcCarrinhoVendaBtn.Enabled = false;
        }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        private int codigoProduto;
        LocalizaCliente localizaCliente = null;

        MySqlConnection conn = new Conexao().ObjetoConexao();

        void localizaCliente_Disposed(object sender, EventArgs e)
        {
            localizaCliente = null;
        }

        private decimal qtdValorVenda;
        public decimal precoAtualVenda;
        private decimal _qtdProdutoEstoque;
        private int _idProdutoEstoque = 0;
        private decimal _qtdAtualizadaEstoque = 0;

        public void ClienteNoTextBox()
        {
            nomeClienteVendaTbx.Text = NomeCliente;
            if (nomeClienteVendaTbx.Text != "")
            {
                categoriaVendaCbx.Visible = true;
                modeloProdutoVendaCbx.Visible = true;
                qtdVendaTbx.Visible = true;
                categoriaVendaLbl.Visible = true;
                modeloProdutoVendaLbl.Visible = true;
                qtdVendaLbl.Visible = true;
                descricaoProdVendaLbl.Visible = true;
                descricaoProdVendaTbx.Visible = true;
                idProdutoVendaLbl.Visible = true;
                idProdutoVendaTbx.Visible = true;
            }

        }
        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            DALVenda dALVenda = new DALVenda();

            modeloProdutoVendaCbx.DataSource = dALVenda.carregaComboBoxProduto(categoriaVendaCbx.Text);
            modeloProdutoVendaCbx.DisplayMember = "modelo";

        }

        private void adcCarrinhoVendaBtn_Click_1(object sender, EventArgs e)
        {
            DALVenda dALVenda = new DALVenda();
            qtdValorVenda = Convert.ToDecimal(qtdVendaTbx.Text);
            Produto produto = dALVenda.getValorAndQtdProduto(modeloProdutoVendaCbx.Text);

            if (qtdValorVenda != 0)
            {
                if (qtdValorVenda <= produto.Quantidade)
                {

                    valorTotalVendaTbx.Text = Convert.ToString(dALVenda.calculaPrecoVenda(precoAtualVenda, qtdValorVenda, produto.Preco));
                    precoAtualVenda = Convert.ToDecimal(valorTotalVendaTbx.Text);

                    consultaCarrinhoVendaGridView.Rows.Add(produto.IdProduto, categoriaVendaCbx.Text, modeloProdutoVendaCbx.Text, qtdVendaTbx.Text, produto.Preco, produto.Quantidade);

                    finalizaVendaBtn.Enabled = true;
                    adcCarrinhoVendaBtn.Enabled = false;

                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("A quantidade escolhida é maior que contida no estoque Produto: " + modeloProdutoVendaCbx.Text + "/Quantidade: " + produto.Quantidade, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A quantidade é inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void qtdVendaTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void finalizaVendaBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Venda venda = new Venda();
                ValidarCamposVenda validarCamposVenda = new ValidarCamposVenda();
                venda.NomeCliente = this.NomeCliente;
                venda.IdCliente = IdCliente;
                venda.ValorTotal = Convert.ToDecimal(valorTotalVendaTbx.Text);

                DALVenda dALVenda = new DALVenda();
                dALVenda.Inserir(venda);

                for (int i = 0; i < (consultaCarrinhoVendaGridView.Rows.Count - 1); i++)
                {

                    DataGridViewRow row = consultaCarrinhoVendaGridView.Rows[i];

                    venda.produtosVenda.Categoria = Convert.ToString(row.Cells["categoria"].Value);
                    venda.produtosVenda.Modelo = Convert.ToString(row.Cells["modelo"].Value);
                    venda.produtosVenda.QtdProduto = Convert.ToInt32(row.Cells["quantidade"].Value);
                    venda.produtosVenda.Preco = Convert.ToDecimal(row.Cells["preco"].Value);
                    _qtdProdutoEstoque = Convert.ToInt32(row.Cells["quantidade_estoque"].Value);
                    _idProdutoEstoque = Convert.ToInt32(row.Cells["id_produtoEstoque"].Value);
                    venda.produtosVenda.IdProduto = _idProdutoEstoque;

                    _qtdAtualizadaEstoque = Convert.ToInt32(_qtdProdutoEstoque - venda.produtosVenda.QtdProduto);

                    dALVenda.InserirProdutos(venda);

                    dALVenda.AtualizarEstoque(_qtdAtualizadaEstoque, _idProdutoEstoque);

                }
                MessageBox.Show("Venda finalizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarTelaVendaBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void localizaClienteBtn_Click_1(object sender, EventArgs e)
        {
            if (localizaCliente == null)
            {
                localizaCliente = new LocalizaCliente(this);
                localizaCliente.Disposed += new EventHandler(localizaCliente_Disposed);
                localizaCliente.Show();
            }

        }

        public void LiberaBtnCarrinho()
        {

            if (!string.IsNullOrEmpty(modeloProdutoVendaCbx.Text) &&
                 !string.IsNullOrEmpty(qtdVendaTbx.Text) &&
                 !string.IsNullOrEmpty(categoriaVendaCbx.Text) &&
                 qtdVendaTbx.Text != "0")
            {
                adcCarrinhoVendaBtn.Enabled = true;
            }
        }

        private void produtoVendaLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void valorTotalVendaLbl_Click_1(object sender, EventArgs e)
        {

        }

        public void limpaCampos()
        {
            qtdVendaTbx.Clear();
            modeloProdutoVendaCbx.Text = "";
            categoriaVendaCbx.Text = "";
        }



        private void NovaVenda_Load_1(object sender, EventArgs e)
        {

        }

        private void qtdVendaTbx_TextChanged_1(object sender, EventArgs e)
        {
            LiberaBtnCarrinho();
        }

        private void categoriaVendaCbx_SelectedValueChanged_1(object sender, EventArgs e)
        {

        }

        private void categoriaVendaCbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            modeloProdutoVendaCbx.Enabled = true;
            modeloProdutoVendaCbx.DataSource = null;
            qtdVendaTbx.Enabled = false;
            descricaoProdVendaTbx.Text = "";
        }

        private void categoriaVendaCbx_DropDown_1(object sender, EventArgs e)
        {
            DALProduto dALProduto = new DALProduto();

            categoriaVendaCbx.DataSource = dALProduto.carregaComboBoxCategoria();
            categoriaVendaCbx.DisplayMember = "categoria";
        }

        private void modeloProdutoVendaCbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DALVenda dALVenda = new DALVenda();
            Produto produto = dALVenda.getValorAndQtdProduto(modeloProdutoVendaCbx.Text);
            descricaoProdVendaTbx.Text = produto.Descricao;
            idProdutoVendaTbx.Text = Convert.ToString(produto.IdProduto);
            qtdVendaTbx.Enabled = true;
            qtdVendaTbx.Text = "0";
        }

        private void NovaVenda_Load(object sender, EventArgs e)
        {

        }

        private void qtdVendaTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void consultaCarrinhoVendaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    codigoProduto = Convert.ToInt32(consultaCarrinhoVendaGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Produto selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
        }

        private void excluirCarrinhoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoProduto != 0)
                {
                    for (int i = 0; i < (consultaCarrinhoVendaGridView.Rows.Count - 1); i++)
                    {

                        DataGridViewRow row = consultaCarrinhoVendaGridView.Rows[i];
                        int idP;

                        idP = Convert.ToInt32(row.Cells["id_produtoEstoque"].Value);

                        if (codigoProduto == idP)
                        {
                            consultaCarrinhoVendaGridView.Rows.Remove(consultaCarrinhoVendaGridView.Rows[i]);
                        }
                    }
                    codigoProduto = 0;
                }
                else
                {
                    MessageBox.Show("Produto não selecionado!");
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }

        }
    }
}

