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
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        private int _codigoVenda;
        NovaVenda novaVenda = null;
        void novaVenda_Disposed(object sender, EventArgs e)
        {
            novaVenda = null;
        }
        private void novaVendaBtn_Click(object sender, EventArgs e)
        {
            
            if (novaVenda == null)
            {
                novaVenda = new NovaVenda();
                novaVenda.Disposed += new EventHandler(novaVenda_Disposed);
                novaVenda.Show();
            }
        }

        private void pesquisaVendaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DALVenda dALVenda = new DALVenda();


                if (string.IsNullOrEmpty(cpfPesqVendaMskBx.Text))
                {
                    consultaVendaGridView.DataSource = dALVenda.PesquisarPorNomeCliente(nomeClientePesqTbx.Text);
                    alterarNomesCulunasGridView();
                }
                else if(string.IsNullOrEmpty(nomeClientePesqTbx.Text))
                {
                    consultaVendaGridView.DataSource = dALVenda.PesquisarPorCpf(cpfPesqVendaMskBx.Text);
                    alterarNomesCulunasGridView();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void alterarNomesCulunasGridView()
        {
            consultaVendaGridView.Columns[0].HeaderText = "ID Venda";
            consultaVendaGridView.Columns[1].HeaderText = "Nome Cliente";
            consultaVendaGridView.Columns[2].HeaderText = "CPF";
            consultaVendaGridView.Columns[3].HeaderText = "Valor Total";

        }

        private void cancelarTelaVendaBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void consultaVendaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    _codigoVenda = Convert.ToInt32(consultaVendaGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Venda selecionada!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
         
        }

        private void excluirVendaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((_codigoVenda != 0))
                {
                   
                    if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {                      
                        DALVenda dALVenda = new DALVenda();
                        dALVenda.Excluir(_codigoVenda);
                        consultaVendaGridView.DataSource = dALVenda.Pesquisar();
                        _codigoVenda = 0;
                        MessageBox.Show("Venda excluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou venda não selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
