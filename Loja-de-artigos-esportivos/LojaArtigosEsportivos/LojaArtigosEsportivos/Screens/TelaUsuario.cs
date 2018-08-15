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
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
            salvarCadUsuarioBtn.Enabled = false;
            nomeCompletoCadTbx.Enabled = false;
            usuarioLoginCadTbx.Enabled = false;
            senhaCadUsuarioTbx.Enabled = false;
            repSenhaCadUsuarioTbx.Enabled = false;
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        private int CodigoUsuario;

        private int alterar;
        private void cadastrarUsuarioBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                UsuarioSistema usuarioSistema = new UsuarioSistema();

                usuarioSistema.Nome = nomeCompletoCadTbx.Text;
                usuarioSistema.Usuario = usuarioLoginCadTbx.Text;
                usuarioSistema.Senha = senhaCadUsuarioTbx.Text;

                if (alterar != 0)
                {
                    if (ValidarCampos() == 0)
                    {
                        if (MessageBox.Show("Deseja realmente alterar isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            DALUsuario dALUsuario = new DALUsuario();
                            usuarioSistema.IdUsuario = CodigoUsuario;
                            dALUsuario.Alterar(usuarioSistema);
                            alterar = 0;
                            MessageBox.Show("Usuário alterado com sucesso!");
                            CodigoUsuario = 0;
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        switch (ValidarCampos())
                        {

                            case 1:
                                MessageBox.Show("Nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 2:
                                MessageBox.Show("Usuário é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 3:
                                MessageBox.Show("Senha é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 4:
                                MessageBox.Show("Repitir a senha é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 5:
                                MessageBox.Show("Senha não corresponde a Repitir senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }
                    }

                }
                else
                {
                    if (ValidarCampos() == 0)
                    {

                        DALUsuario dALUsuario = new DALUsuario();
                        dALUsuario.Inserir(usuarioSistema);
                        MessageBox.Show("Usuario inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    else
                    {
                        switch (ValidarCampos())
                        {
                            case 1:
                                MessageBox.Show("Nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 2:
                                MessageBox.Show("Usuário é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 3:
                                MessageBox.Show("Senha é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 4:
                                MessageBox.Show("Repitir a senha é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;

                            case 5:
                                MessageBox.Show("Senha não corresponde a Repitir senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void consultaUsuariosGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    CodigoUsuario = Convert.ToInt32(consultaUsuariosGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Usuário selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }

        }

        private void pesquisarUsuarioBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DALUsuario dALUsuario = new DALUsuario();

                consultaUsuariosGridView.DataSource = dALUsuario.PesquisarPorNome(nomePesquisaUsuarioTbx.Text);
                alterarNomesCulunasGridView();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirUsuarioBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((CodigoUsuario != 0))
                {
                    if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        UsuarioSistema usuarioSistema = new UsuarioSistema();
                        usuarioSistema.IdUsuario = CodigoUsuario;
                        DALUsuario dALUsuario = new DALUsuario();
                        dALUsuario.Excluir(usuarioSistema.IdUsuario);
                        consultaUsuariosGridView.DataSource = dALUsuario.Pesquisar();
                        CodigoUsuario = 0;
                        MessageBox.Show("Usuário excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou usuário nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarUsuarioBtn_Click_1(object sender, EventArgs e)
        {
            alterar = 1;

            if (CodigoUsuario != 0)
            {

                nomeCompletoCadTbx.Text = "";
                usuarioLoginCadTbx.Text = "";
                senhaCadUsuarioTbx.Text = "";
                repSenhaCadUsuarioTbx.Text = "";
                nomeCompletoCadTbx.Enabled = true;
                usuarioLoginCadTbx.Enabled = true;
                senhaCadUsuarioTbx.Enabled = true;
                repSenhaCadUsuarioTbx.Enabled = true;
                salvarCadUsuarioBtn.Enabled = true;
                DALUsuario dALUsuario = new DALUsuario();
                UsuarioSistema usuarioSistema = dALUsuario.carregaUsuario(CodigoUsuario);

                nomeCompletoCadTbx.Text = usuarioSistema.Nome;
                usuarioLoginCadTbx.Text = usuarioSistema.Usuario;
                senhaCadUsuarioTbx.Text = usuarioSistema.Senha;
            }
            else
            {
                MessageBox.Show("Tabela vazia ou usuário nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarTelaCadUsuarioBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();

        }

        public int ValidarCampos()
        {
            if (string.IsNullOrEmpty(nomeCompletoCadTbx.Text))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(usuarioLoginCadTbx.Text))
            {
                return 2;
            }
            if (string.IsNullOrEmpty(senhaCadUsuarioTbx.Text))
            {
                return 3;
            }
            if (string.IsNullOrEmpty(repSenhaCadUsuarioTbx.Text))
            {
                return 4;
            }
            if (!(senhaCadUsuarioTbx.Text == repSenhaCadUsuarioTbx.Text))
            {
                return 5;
            }
            return 0;
        }

        private void novoUsuarioBtn_Click_1(object sender, EventArgs e)
        {
            nomeCompletoCadTbx.Text = "";
            usuarioLoginCadTbx.Text = "";
            senhaCadUsuarioTbx.Text = "";
            repSenhaCadUsuarioTbx.Text = "";
            alterar = 0;
            CodigoUsuario = 0;
            salvarCadUsuarioBtn.Enabled = true;
            nomeCompletoCadTbx.Enabled = true;
            usuarioLoginCadTbx.Enabled = true;
            senhaCadUsuarioTbx.Enabled = true;
            repSenhaCadUsuarioTbx.Enabled = true;
        }

        public void alterarNomesCulunasGridView()
        {
            consultaUsuariosGridView.Columns[0].HeaderText = "ID Usuário";
            consultaUsuariosGridView.Columns[1].HeaderText = "Nome Completo";
            consultaUsuariosGridView.Columns[2].HeaderText = "Usuário";
            consultaUsuariosGridView.AutoResizeColumns();
        }

        private void TelaUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
