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
    public partial class AlterarFornecedor : Form
    {
        private int _codigoFornecedor = 0;
        public AlterarFornecedor()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public AlterarFornecedor(int codigo)
        {
            this._codigoFornecedor = codigo;
            InitializeComponent();
            carregarDadosNoTextBox();
        }
        public void carregarDadosNoTextBox()
        {

            if (_codigoFornecedor != 0)
            {
                DALFornecedor dALFornecedor = new DALFornecedor();
                Fornecedor fornecedor = dALFornecedor.carregaFornecedor(_codigoFornecedor);

                nomeAltFornTbx.Text = fornecedor.Nome;
                cnpjAltFornMskBx.Text = fornecedor.Cnpj;
                emailAltFornTbx.Text = fornecedor.Email;
                dddAltFornTbx.Text = fornecedor.Ddd;
                tipoNumeroAltFornCbx.Text = fornecedor.Tipo;
                numeroAltFornMskBx.Text = fornecedor.Numero;

            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void salvarFornBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();
                ValidarCamposFornecedor validarCamposFornecedor = new ValidarCamposFornecedor();
                fornecedor.Nome = nomeAltFornTbx.Text;
                fornecedor.Cnpj = cnpjAltFornMskBx.Text;
                fornecedor.Email = emailAltFornTbx.Text;
                fornecedor.Ddd = dddAltFornTbx.Text;
                fornecedor.Numero = numeroAltFornMskBx.Text;
                fornecedor.Tipo = tipoNumeroAltFornCbx.Text;
                fornecedor.IdFornecedor = _codigoFornecedor;

                if ((_codigoFornecedor != 0))
                {
                    if(validarCamposFornecedor.ValidarCampos(fornecedor) == 0)
                    {
                        if (MessageBox.Show("Deseja realmente alterar isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            DALFornecedor dALFornecedor = new DALFornecedor();
                            dALFornecedor.Alterar(fornecedor);

                            MessageBox.Show("Fornecedor alterado com sucesso!");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tipoNumeroAltFornCbx_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (tipoNumeroAltFornCbx.Text == "Telefone")
            {
                numeroAltFornMskBx.Mask = "0000-0000";
                numeroAltFornMskBx.MaskInputRejected += new MaskInputRejectedEventHandler(numeroAltFornMskBx_MaskInputRejected_1);
            }
            else
            {
                numeroAltFornMskBx.Mask = "00000-0000";
                numeroAltFornMskBx.MaskInputRejected += new MaskInputRejectedEventHandler(numeroAltFornMskBx_MaskInputRejected_1);
            }
        }

        private void numeroAltFornMskBx_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cancelarAltFornBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dddAltFornTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void numeroAltFornMskBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
