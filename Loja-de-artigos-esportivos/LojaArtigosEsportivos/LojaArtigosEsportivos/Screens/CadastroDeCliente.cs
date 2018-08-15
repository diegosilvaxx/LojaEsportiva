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
    public partial class CadastroDeCliente : Form
    {
        
        public string sexo { get; set; }

        public CadastroDeCliente()
        {
            InitializeComponent();
            telefoneAltClienteMskBx.Enabled = false;
            dddTelefoneCadClienteTbx.Enabled = false;
            dddTelefoneCadClienteTbx.MaxLength = 2;
        }
        
        
        public void LimpaTextBox()
        {
            nomeCadClienteTbx.Clear();          
            cpfCadClienteMskBox.Clear();
            emailCadClienteTbx.Clear();
            dataNascCadClienteMskBx.Clear();
            ruaCadClienteTbx.Clear();
            bairroCadClienteTbx.Clear();            
            cidadeCadClienteTbx.Clear();
            numeroCadClienteTbx.Clear();
            dddTelefoneCadClienteTbx.Clear();
            telefoneAltClienteMskBx.Clear();
        }



        private void cadastrarClienteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                Cliente cliente = new Cliente();
                ValidarCamposCliente validarCamposCliente = new ValidarCamposCliente();

                cliente.Nome = nomeCadClienteTbx.Text;
                cliente.Cpf = cpfCadClienteMskBox.Text;
                cliente.Email = emailCadClienteTbx.Text;
                cliente.Sexo = this.sexo;
                cliente.DataNasc = dataNascCadClienteMskBx.Text;
                cliente.Rua = ruaCadClienteTbx.Text;
                cliente.Bairro = bairroCadClienteTbx.Text;
                cliente.Estado = estadoCadClienteCbx.Text;
                cliente.Cidade = cidadeCadClienteTbx.Text;
                cliente.NumeroCasa = numeroCadClienteTbx.Text;
                cliente.Ddd = dddTelefoneCadClienteTbx.Text;
                cliente.Numero = telefoneAltClienteMskBx.Text;
                cliente.Tipo = tipoTelCadClienteCbx.Text;


                if (validarCamposCliente.ValidarCampos(cliente) == 0)
                {
                    MySqlConnection conn = new Conexao().ObjetoConexao();
                    DALCliente dALCliente = new DALCliente();
                    dALCliente.Inserir(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTextBox();
                    conn.Close();
                    Dispose();
                }
                else
                {
                    switch (validarCamposCliente.ValidarCampos(cliente))
                    {
                        case 1:
                            MessageBox.Show("Nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Sexo é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 3:
                            MessageBox.Show("Email invalido ou vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 4:
                            MessageBox.Show("CPF invalido ou vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 5:
                            MessageBox.Show("Data de Nascimento invalido ou vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void cancelarCadClienteBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void mascCadClienteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.sexo = mascCadClienteRadioBtn.Text;
        }
        private void FemCadClienteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.sexo = FemCadClienteRadioBtn.Text;
        }

        private void cpfCadClienteTbx_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void telefoneAltClienteMskBx_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dddTelefoneCadClienteTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CadastroDeCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void numeroCadClienteTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tipoTelCadClienteCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoTelCadClienteCbx_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (tipoTelCadClienteCbx.Text == "Telefone")
            {
                telefoneAltClienteMskBx.Enabled = true;
                dddTelefoneCadClienteTbx.Enabled = true;
                telefoneAltClienteMskBx.Mask = "0000-0000";
            }
            else
            {
                telefoneAltClienteMskBx.Enabled = true;
                dddTelefoneCadClienteTbx.Enabled = true;
                telefoneAltClienteMskBx.Mask = "00000-0000";
            }
        }

        private void CadastroDeCliente_Load(object sender, EventArgs e)
        {

        }

        private void dddTelefoneCadClienteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void telefoneAltClienteMskBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void numeroCadClienteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void FemCadClienteRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            this.sexo = FemCadClienteRadioBtn.Text;
        }
    }
}
