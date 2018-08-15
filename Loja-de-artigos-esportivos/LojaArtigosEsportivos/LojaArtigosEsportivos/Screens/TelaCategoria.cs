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
    public partial class TelaCategoria : Form
    {
        public TelaCategoria()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        private int _codigoCategoria;

        CadastroDeCategoria cadastroDeCategoria = null;

        void cadastroDeCategoria_Disposed(object sender, EventArgs e)
        {
            cadastroDeCategoria = null;
        }
        private void pesquisaCategoriaBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DALGrupo dALGrupo = new DALGrupo();
                MySqlConnection conn = new Conexao().ObjetoConexao();

                if (!(categoriaPesqTbx.Text == string.Empty))
                {
                    consultaCategoriaGridView.DataSource = dALGrupo.PesquisarPorCategoria(categoriaPesqTbx.Text);
                    alterarNomesCulunasGridView();
                }
                else
                {
                    consultaCategoriaGridView.DataSource = dALGrupo.Pesquisar();
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
            consultaCategoriaGridView.Columns[0].HeaderText = "ID Grupo";
            consultaCategoriaGridView.Columns[1].HeaderText = "Categoria";
            consultaCategoriaGridView.Columns[2].HeaderText = "Ativo";
            consultaCategoriaGridView.AutoResizeColumns();

        }
        private void desativarAndAtivarBtn_Click_1(object sender, EventArgs e)
        {
            DALGrupo dALGrupo = new DALGrupo();

            Grupo grupo = dALGrupo.getEstadoCategoria(_codigoCategoria);
            if (_codigoCategoria != 0)
            {
                if (grupo.EstadoCategoria == 'S')
                {
                    grupo.IdGrupo = _codigoCategoria;
                    grupo.EstadoCategoria = 'N';
                    dALGrupo.Alterar(grupo);

                    MessageBox.Show("Categoria desativada com sucesso!");

                    _codigoCategoria = 0;

                    consultaCategoriaGridView.DataSource = dALGrupo.Pesquisar();
                }
                else
                {
                    grupo.IdGrupo = _codigoCategoria;
                    grupo.EstadoCategoria = 'S';
                    dALGrupo.Alterar(grupo);

                    MessageBox.Show("Categoria ativada com sucesso!");

                    _codigoCategoria = 0;

                    consultaCategoriaGridView.DataSource = dALGrupo.Pesquisar();
                }
            }
            else
            {
                MessageBox.Show("Tabela vazia ou categoria não selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void excluirCategoriaBtn_Click_1(object sender, EventArgs e)
        {

            if ((_codigoCategoria != 0))
            {

                if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Grupo grupo = new Grupo();
                    grupo.IdGrupo = _codigoCategoria;
                    DALGrupo dALGrupo = new DALGrupo();
                    DALProduto dALProduto = new DALProduto();
                    Produto produto = dALGrupo.checaProdutoLinkado(_codigoCategoria);
                    if (!(produto.IdGrupo == _codigoCategoria))
                    {
                        dALGrupo.Excluir(grupo.IdGrupo);
                        consultaCategoriaGridView.DataSource = dALGrupo.Pesquisar();
                        _codigoCategoria = 0;
                        MessageBox.Show("Categoria excluida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Categoria está linkada com algum produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Tabela vazia ou categoria não selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    _codigoCategoria = Convert.ToInt32(consultaCategoriaGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Categoria selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
        }

        private void novaCategoriaBtn_Click_1(object sender, EventArgs e)
        {
            if (cadastroDeCategoria == null)
            {
                cadastroDeCategoria = new CadastroDeCategoria();
                cadastroDeCategoria.Disposed += new EventHandler(cadastroDeCategoria_Disposed);
                cadastroDeCategoria.Show();
            }
        }

        private void cancelarTelaCateBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TelaCategoria_Load_1(object sender, EventArgs e)
        {

        }


    }
}
