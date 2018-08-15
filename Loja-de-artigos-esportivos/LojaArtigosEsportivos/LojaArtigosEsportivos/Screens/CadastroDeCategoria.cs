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
    public partial class CadastroDeCategoria : Form
    {
        public CadastroDeCategoria()
        {
            InitializeComponent();
        }

        private void cadastrarCategoriaBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Grupo grupo = new Grupo();
                grupo.Categoria = categoriaCadTbx.Text;
                grupo.EstadoCategoria = Convert.ToChar(estadoCategoriaCbx.Text);

                if (ValidaCampo() == 0)
                {
                    MySqlConnection conn = new Conexao().ObjetoConexao();
                    DALGrupo dALGrupo = new DALGrupo();
                    dALGrupo.Inserir(grupo);
                    MessageBox.Show("Categoria cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Dispose();
                }
                else
                {
                    switch (ValidaCampo())
                    {
                        case 1:
                            MessageBox.Show("Informar categoria é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Informar o estado da categoria é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int ValidaCampo()
        {
            if (string.IsNullOrEmpty(categoriaCadTbx.Text))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(estadoCategoriaCbx.Text))
            {
                return 2;
            }
            return 0;
        }

        private void cancelarCadCategoriaBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
