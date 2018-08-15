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
    public partial class LocalizaCliente : Form
    {
        public LocalizaCliente()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public NovaVenda telaVenda;
        public LocalizaCliente(NovaVenda telaVenda)
        {
            InitializeComponent();
            this.telaVenda = telaVenda;

        }
        private void localizarClienteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DALCliente dALCliente = new DALCliente();


                if (nomeLocalizaClientTbx.Text == string.Empty)
                {
                    localizaClienteGridView.DataSource = dALCliente.PesquisarPorCpf(cpfLocalizaClienteMskBx.Text);
                    alterarNomesCulunasGridView();
                }
                else
                {
                    localizaClienteGridView.DataSource = dALCliente.PesquisarPorNome(nomeLocalizaClientTbx.Text);
                    alterarNomesCulunasGridView();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selecionaClienteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(IdCliente != 0)
                {
                    telaVenda.NomeCliente = NomeCliente;
                    telaVenda.IdCliente = IdCliente;
                    telaVenda.ClienteNoTextBox();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Cliente nao selecionado!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void localizaClienteGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    IdCliente = Convert.ToInt32(localizaClienteGridView.Rows[e.RowIndex].Cells[0].Value);
                    NomeCliente = Convert.ToString(localizaClienteGridView.Rows[e.RowIndex].Cells[1].Value);
                    //this.Close();
                    MessageBox.Show("Cliente selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
     
        }

        public void alterarNomesCulunasGridView()
        {
            localizaClienteGridView.Columns[0].HeaderText = "ID Cliente";
            localizaClienteGridView.Columns[1].HeaderText = "Nome";
            localizaClienteGridView.Columns[2].HeaderText = "CPF";
            localizaClienteGridView.Columns[3].HeaderText = "Email";
            localizaClienteGridView.Columns[4].HeaderText = "Data Nascimento";
            localizaClienteGridView.Columns[5].HeaderText = "Sexo";
            localizaClienteGridView.Columns[6].HeaderText = "Rua";
            localizaClienteGridView.Columns[7].HeaderText = "Numero Casa";
            localizaClienteGridView.Columns[8].HeaderText = "Bairro";
            localizaClienteGridView.Columns[9].HeaderText = "Estado";
            localizaClienteGridView.Columns[10].HeaderText = "Cidade";
            localizaClienteGridView.Columns[11].HeaderText = "DDD";
            localizaClienteGridView.Columns[12].HeaderText = "Numero Telefone";
            localizaClienteGridView.Columns[13].HeaderText = "Tipo Numero";
            localizaClienteGridView.AutoResizeColumns();
        }

        private void cancelaLocalizaClienteBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LocalizaCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeCliente cadastroDeCliente = new CadastroDeCliente();
            cadastroDeCliente.Show();
        }
    }
}
