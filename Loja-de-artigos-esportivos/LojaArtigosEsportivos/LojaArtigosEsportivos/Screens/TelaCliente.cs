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
    public partial class TelaCliente : Form
    {
        private int _codigoCliente = 0;
        Cliente cliente = new Cliente();
        public TelaCliente()
        {
            InitializeComponent();
            
        }
       
        public int CodigoCliente
        {
            get { return _codigoCliente; }
            set { _codigoCliente = value; }
        }
        CadastroDeCliente cadastroDeCliente = null;
        AlterarCliente alterarCliente = null;
        void cadastroDeCliente_Disposed_1(object sender, EventArgs e)
        {
            cadastroDeCliente = null;
        }
        void alterarCliente_Disposed_1(object sender, EventArgs e)
        {
            alterarCliente = null;
        }

        private void novoClienteBtn_Click_1(object sender, EventArgs e)
        {         
            if (cadastroDeCliente == null)
            {
                cadastroDeCliente = new CadastroDeCliente();
                cadastroDeCliente.Disposed += new EventHandler(cadastroDeCliente_Disposed_1);
                cadastroDeCliente.Show();
            }

        }

        private void pesquisarClienteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DALCliente dALCliente = new DALCliente();
                MySqlConnection conn = new Conexao().ObjetoConexao();

                if (nomeClientePesquisaTbx.Text == string.Empty)
                {
                    consultaClienteGridView.DataSource = dALCliente.PesquisarPorCpf(cpfClientePesquisaMskBox.Text);
                    alterarNomesCulunasGridView();

                }
                else
                {
                    consultaClienteGridView.DataSource = dALCliente.PesquisarPorNome(nomeClientePesquisaTbx.Text);
                    alterarNomesCulunasGridView();
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaClienteGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    CodigoCliente = Convert.ToInt32(consultaClienteGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Cliente selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
            
        }

        private void alterarClienteBtn_Click_1(object sender, EventArgs e)
        {

            if (CodigoCliente != 0)
            {
                
                if (alterarCliente == null)
                {
                    alterarCliente = new AlterarCliente(CodigoCliente);
                    alterarCliente.Disposed += new EventHandler(alterarCliente_Disposed_1);
                    alterarCliente.Show();
                }


                DALCliente dALCliente = new DALCliente();
                Cliente cliente = dALCliente.carregaCliente(CodigoCliente);

            }
            else
            {
                MessageBox.Show("Tabela vazia ou cliente nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirClienteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((CodigoCliente != 0))
                {
                    if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Idcliente = CodigoCliente;
                        DALCliente dALCliente = new DALCliente();
                        dALCliente.Excluir(cliente.Idcliente);
                        consultaClienteGridView.DataSource = dALCliente.Pesquisar();
                        CodigoCliente = 0;
                        MessageBox.Show("Cliente excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou cliente nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void cancelarClienteBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        public void alterarNomesCulunasGridView()
        {
            consultaClienteGridView.Columns[0].HeaderText = "ID Cliente";
            consultaClienteGridView.Columns[1].HeaderText = "Nome";
            consultaClienteGridView.Columns[2].HeaderText = "CPF";            
            consultaClienteGridView.Columns[3].HeaderText = "Email";
            consultaClienteGridView.Columns[4].HeaderText = "Data Nascimento";
            consultaClienteGridView.Columns[5].HeaderText = "Sexo";
            consultaClienteGridView.Columns[6].HeaderText = "Rua";
            consultaClienteGridView.Columns[7].HeaderText = "Numero Casa";
            consultaClienteGridView.Columns[8].HeaderText = "Bairro";
            consultaClienteGridView.Columns[9].HeaderText = "Estado";
            consultaClienteGridView.Columns[10].HeaderText = "Cidade";
            consultaClienteGridView.Columns[11].HeaderText = "DDD";
            consultaClienteGridView.Columns[12].HeaderText = "Numero Telefone";
            consultaClienteGridView.Columns[13].HeaderText = "Tipo Numero";
            consultaClienteGridView.AutoResizeColumns();
        }

        private void idClientePesquisaLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void pesquisarClienteBtn_Click(object sender, EventArgs e)
        {

        }

        private void alterarClienteBtn_Click(object sender, EventArgs e)
        {

        }

        private void excluirClienteBtn_Click(object sender, EventArgs e)
        {

        }

        private void consultaClienteGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}