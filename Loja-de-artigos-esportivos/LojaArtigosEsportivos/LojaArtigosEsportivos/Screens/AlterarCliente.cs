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
    public partial class AlterarCliente : Form
    {
       
        private int _codigoCliente;
        public string sexo { get;set; }

      
        public void radioBtnSelecionado(string sexo)
        {
            string valor = "M";
            if(sexo == valor)
            {
                masculinoAltClienteRadBtn.Checked = true;
            }
            else
            {
                femininoAltClienteRadBtn.Checked = true;
            }
        }
        public AlterarCliente()
        {
            InitializeComponent();        
        }
        
       public AlterarCliente(int codigo)
        {
            this._codigoCliente = codigo;
            InitializeComponent();
            carregarDadosNoTextBox();
        }
        public void carregarDadosNoTextBox()
        {

            if (_codigoCliente != 0)
            {
                DALCliente dALCliente = new DALCliente();
                Cliente cliente = dALCliente.carregaCliente(_codigoCliente);
                                
                nomeAltClienteTbx.Text = cliente.Nome;
                cpfAltClienteMskBox.Text = cliente.Cpf;
                emailAltClienteTbx.Text = cliente.Email;
                dataNascAltClienteMskBx.Text = cliente.DataNasc;
                radioBtnSelecionado(cliente.Sexo);
                ruaAltClienteTbx.Text = cliente.Rua;
                bairroAltClienteTbx.Text = cliente.Bairro;
                estadoAltClienteCbx.Text = cliente.Estado;
                cidadeAltClienteTbx.Text = cliente.Cidade;
                numeroAltClienteTbx.Text = cliente.NumeroCasa;
                dddTelAltClienteTbx.Text = cliente.Ddd;
                telefoneAltClienteMskBx.Text = cliente.Numero;
                tipoTelAltClienteCbx.Text = cliente.Tipo;

            }           
        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salvarAltClienteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                ValidarCamposCliente validarCamposCliente = new ValidarCamposCliente();

                cliente.Nome = nomeAltClienteTbx.Text;
                cliente.Cpf = cpfAltClienteMskBox.Text;
                cliente.Email = emailAltClienteTbx.Text;
                cliente.DataNasc = dataNascAltClienteMskBx.Text;
                cliente.Sexo = this.sexo;
                cliente.Rua = ruaAltClienteTbx.Text;
                cliente.Bairro = bairroAltClienteTbx.Text;
                cliente.Estado = estadoAltClienteCbx.Text;
                cliente.Cidade = cidadeAltClienteTbx.Text;
                cliente.NumeroCasa = numeroAltClienteTbx.Text;
                cliente.Ddd = dddTelAltClienteTbx.Text;
                cliente.Numero = telefoneAltClienteMskBx.Text;
                cliente.Tipo = tipoTelAltClienteCbx.Text;
                cliente.Idcliente = _codigoCliente;

                if ((_codigoCliente != 0))
                {
                    if(validarCamposCliente.ValidarCampos(cliente) == 0)
                    {
                        if (MessageBox.Show("Deseja realmente alterar isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            DALCliente dALCliente = new DALCliente();
                            MySqlConnection conn = new Conexao().ObjetoConexao();
                            dALCliente.Alterar(cliente);

                            MessageBox.Show("Cliente alterado com sucesso!");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarAltClienteBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void masculinoAltClienteRadBtn_MouseEnter_1(object sender, EventArgs e)
        {
            
        }

        private void femininoAltClienteRadBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            this.sexo = femininoAltClienteRadBtn.Text;
        }

        private void masculinoAltClienteRadBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            this.sexo = masculinoAltClienteRadBtn.Text;
        }

        private void cidadeAltClienteTbx_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ruaAltClienteTbx_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tipoTelAltClienteCbx_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (tipoTelAltClienteCbx.Text == "Telefone")
            {
                telefoneAltClienteMskBx.Mask = "0000-0000";
                telefoneAltClienteMskBx.MaskInputRejected += new MaskInputRejectedEventHandler(telefoneAltClienteMskBx_MaskInputRejected_1);
            }
            else
            {
                telefoneAltClienteMskBx.Mask = "00000-0000";
                telefoneAltClienteMskBx.MaskInputRejected += new MaskInputRejectedEventHandler(telefoneAltClienteMskBx_MaskInputRejected_1);
            }
        }

        private void telefoneAltClienteMskBx_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tipoTelAltClienteCbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numeroAltClienteTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dddTelAltClienteTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void AlterarCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void tipoTelAltClienteCbx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tipoTelAltClienteCbx.Text == "Telefone")
            {
                telefoneAltClienteMskBx.Enabled = true;
                dddTelAltClienteTbx.Enabled = true;
                telefoneAltClienteMskBx.Mask = "0000-0000";
            }
            else
            {
                telefoneAltClienteMskBx.Enabled = true;
                dddTelAltClienteTbx.Enabled = true;
                telefoneAltClienteMskBx.Mask = "00000-0000";
            }
        }

        private void dddTelAltClienteTbx_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numeroAltClienteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
