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
    public partial class CadastroDeProduto : Form
    {
        public CadastroDeProduto()
        {
            InitializeComponent();
            fornecedorLocalizadoTbx.Enabled = false;
            marcaCadProdTbx.Enabled = false;
            modeloCadProdTbx.Enabled = false;
            qtdCadProdTbx.Enabled = false;
            precoCadProdTbx.Enabled = false;
            categoriaProdutoCbx.Enabled = false;
            descricaoProdutoTbx.Enabled = false;
            
        }

        private int _quantidade = 0;
        private decimal _preco = 0;
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }

        public void FornecedorNoTextBox()
        {
            fornecedorLocalizadoTbx.Text = NomeFornecedor;

        }
        LocalizarFornecedor localizarFornecedor = null;
        void localizarFornecedor_Disposed_1(object sender, EventArgs e)
        {
            localizarFornecedor = null;
        }
        public bool LiberaCampos()
        {
            if (!(fornecedorLocalizadoTbx.Text == ""))
            {
                categoriaProdutoCbx.Enabled = true;
                marcaCadProdTbx.Enabled = true;
                modeloCadProdTbx.Enabled = true;
                qtdCadProdTbx.Enabled = true;
                precoCadProdTbx.Enabled = true;
                descricaoProdutoTbx.Enabled = true;

                return true;
            }
            else
            {
                return false;
            }
        }
        private void avancarCadProdBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (LiberaCampos() == true)
                {
                    DALGrupo dALGrupo = new DALGrupo();
                    DALProduto dALProduto = new DALProduto();
                    Produto produto = dALProduto.getIdCategoria(categoriaProdutoCbx.Text);
                    ValidarCamposProduto validarCamposProduto = new ValidarCamposProduto();
                    Grupo grupo = dALGrupo.getEstadoCategoria(produto.IdGrupo);

                    if (grupo.EstadoCategoria == 'S')
                    {
                        produto.Categoria = categoriaProdutoCbx.Text;
                        produto.IdFornecedor = IdFornecedor;
                        produto.NomeFornecedor = NomeFornecedor;
                        produto.Marca = marcaCadProdTbx.Text;
                        produto.Modelo = modeloCadProdTbx.Text;
                        produto.Descricao = descricaoProdutoTbx.Text;
                        if (TestarIntAndDecimalVazio() == true)
                        {
                            produto.Quantidade = _quantidade;
                            produto.Preco = _preco;
                        }

                        if (validarCamposProduto.ValidarCampos(produto) == 0)
                        {
                            MySqlConnection conn = new Conexao().ObjetoConexao();

                            dALProduto.Inserir(produto);
                            MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            Dispose();
                        }
                        else
                        {
                            switch (validarCamposProduto.ValidarCampos(produto))
                            {
                                case 1:
                                    MessageBox.Show("Marca é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case 2:
                                    MessageBox.Show("Modelo é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case 3:
                                    MessageBox.Show("Descrição é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case 4:
                                    MessageBox.Show("Quantidade é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case 5:
                                    MessageBox.Show("Preço é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case 6:
                                    MessageBox.Show("Categoria é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Categoria vazia ou indisponível no momento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void localizarFornBtn_Click_1(object sender, EventArgs e)
        {
            if (localizarFornecedor == null)
            {
                localizarFornecedor = new LocalizarFornecedor(this);
                localizarFornecedor.Disposed += new EventHandler(localizarFornecedor_Disposed_1);
                localizarFornecedor.Show();
            }

        }

        private void cancelarSelCadProdBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        public bool TestarIntAndDecimalVazio()
        {
            if (qtdCadProdTbx.Text == "")
            {
                _quantidade = 0;
            }
            else
            {
                _quantidade = Convert.ToInt32(qtdCadProdTbx.Text);
            }
            if (precoCadProdTbx.Text == "")
            {
                _preco = 0;
            }
            else
            {
                _preco = Convert.ToDecimal(precoCadProdTbx.Text);
            }
            return true;
        }

        private void qtdCadProdTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void precoCadProdTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void CadastroDeProduto_Load_1(object sender, EventArgs e)
        {

        }

        private void categoriaProdutoCbx_DropDown_1(object sender, EventArgs e)
        {
            DALProduto dALProduto = new DALProduto();

            categoriaProdutoCbx.DataSource = dALProduto.carregaComboBoxCategoria();
            categoriaProdutoCbx.DisplayMember = "categoria";
        }

        private void CadastroDeProduto_Load(object sender, EventArgs e)
        {

        }

        private void qtdCadProdTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
