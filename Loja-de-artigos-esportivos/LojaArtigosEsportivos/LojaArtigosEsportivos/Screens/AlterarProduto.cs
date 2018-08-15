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
    public partial class AlterarProduto : Form
    {
        private int _codigoProduto;
        private string _tipoProduto;
        private int _quantidade;
        private decimal _preco;
        public AlterarProduto()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public AlterarProduto(int codigo, string tipoProduto)
        {
            this._codigoProduto = codigo;
            this._tipoProduto = tipoProduto;
            InitializeComponent();
            carregarDadosNoTextBox();
        }

        public void carregarDadosNoTextBox()
        {

            if (_codigoProduto != 0)
            {
                DALProduto dALProduto = new DALProduto();
                Produto produto = dALProduto.carregaProduto(_codigoProduto);

                categoriaAltProdCbx.DataSource = dALProduto.carregaComboBoxCategoria();
                categoriaAltProdCbx.DisplayMember = "categoria";

                marcaAltProdTbx.Text = produto.Marca;
                modeloAltProdTbx.Text = produto.Modelo;
                quantidadeAltProdTbx.Text = Convert.ToString(produto.Quantidade);
                precoAltProdTbx.Text = Convert.ToString(produto.Preco);
                descricaoAltProdTbx.Text = produto.Descricao;
                categoriaAltProdCbx.SelectedIndex = categoriaAltProdCbx.FindStringExact(produto.Categoria);
                 
            }
        }
        private void cancelarAltProdBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void salvarAltProdBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((_codigoProduto != 0))
                {

                    DALGrupo dALGrupo = new DALGrupo();
                    DALProduto dALProduto = new DALProduto();
                    Produto produto = dALProduto.getIdCategoria(categoriaAltProdCbx.Text);
                    ValidarCamposProduto validarCamposProduto = new ValidarCamposProduto();
                    Grupo grupo = dALGrupo.getEstadoCategoria(produto.IdGrupo);

                    if (grupo.EstadoCategoria == 'S')
                    {
                        produto.Marca = marcaAltProdTbx.Text;
                        produto.Modelo = modeloAltProdTbx.Text;
                        produto.Descricao = descricaoAltProdTbx.Text;
                        produto.Categoria = categoriaAltProdCbx.Text;
                        if (TestarIntAndDecimalVazio() == true)
                        {
                            produto.Quantidade = _quantidade;
                            produto.Preco = _preco;
                        }
                        produto.IdProduto = _codigoProduto;

                        if (validarCamposProduto.ValidarCampos(produto) == 0)
                        {
                            if (MessageBox.Show("Deseja realmente alterar isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {

                                dALProduto.Alterar(produto);

                                MessageBox.Show("Produto alterado com sucesso!");
                                conn.Close();
                                Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
                        MessageBox.Show("Categoria indisponível no momento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool TestarIntAndDecimalVazio()
        {
            if (quantidadeAltProdTbx.Text == "")
            {
                _quantidade = 0;
            }
            else
            {
                _quantidade = Convert.ToInt32(quantidadeAltProdTbx.Text);
            }
            if (precoAltProdTbx.Text == "")
            {
                _preco = 0;
            }
            else
            {
                _preco = Convert.ToDecimal(precoAltProdTbx.Text);
            }
            return true;
        }

        private void AlterarProduto_Load_1(object sender, EventArgs e)
        {

        }

        private void quantidadeAltProdTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void marcaAltProdLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void categoriaAltProdCbx_DropDown_1(object sender, EventArgs e)
        {
            
        }

        private void categoriaAltProdCbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
  
        }

        private void quantidadeAltProdTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
