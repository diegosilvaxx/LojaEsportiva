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
    public partial class CadastroDeFornecedor : Form
    {
        public CadastroDeFornecedor()
        {
            InitializeComponent();
            numeroFornCadMskBx.Enabled = false;
            dddFornCadTbx.Enabled = false;
            dddFornCadTbx.MaxLength = 2;
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        private void cadastrarFornecedorBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();
                ValidarCamposFornecedor validarCamposFornecedor = new ValidarCamposFornecedor();
                fornecedor.Nome = nomeFornCadTbx.Text;
                fornecedor.Cnpj = cnpjFornCadMskBox.Text;
                fornecedor.Email = emailFornCadTbx.Text;
                fornecedor.Tipo = tipoNumeroFornCadCbx.Text;
                fornecedor.Numero = numeroFornCadMskBx.Text;
                fornecedor.Ddd = dddFornCadTbx.Text;

                if(validarCamposFornecedor.ValidarCampos(fornecedor) == 0)
                {
                    DALFornecedor dALFornecedor = new DALFornecedor();
                    dALFornecedor.Inserir(fornecedor);
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Dispose();
                }
                else
                {
                    switch (validarCamposFornecedor.ValidarCampos(fornecedor))
                    {
                        case 1:
                            MessageBox.Show("Nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("CNPJ invalido ou vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 3:
                            MessageBox.Show("Email invalido ou vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 4:
                            MessageBox.Show("Tipo é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 5:
                            MessageBox.Show("DDD é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 6:
                                MessageBox.Show("Numero é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                         
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numeroFornCadMskBx_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tipoNumeroFornCadCbx_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (tipoNumeroFornCadCbx.Text == "Telefone")
            {
                numeroFornCadMskBx.Enabled = true;
                dddFornCadTbx.Enabled = true;
                numeroFornCadMskBx.Mask = "0000-0000";
            }
            else
            {
                numeroFornCadMskBx.Enabled = true;
                dddFornCadTbx.Enabled = true;
                numeroFornCadMskBx.Mask = "00000-0000";
            }
        }

        private void cancelarCadFornBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dddFornCadTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dddFornCadTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void numeroFornCadMskBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
