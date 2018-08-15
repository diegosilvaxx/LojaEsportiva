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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public menuForm menuForm;
   
        private void logarSistemaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioSistema usuarioSistema = new UsuarioSistema();

                usuarioSistema.Usuario = usuarioLoginTbx.Text;             
                usuarioSistema.Senha = senhaLoginTbx.Text;
                
                DALUsuario dALUsuario = new DALUsuario();

                if (dALUsuario.VerificaUsuario(usuarioSistema))
                {

                    menuForm = new menuForm(this);
                    menuForm.Show();
               
                    this.Hide();
 
                }
                else
                {
                    MessageBox.Show("Usuário e senha incorretos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarTelaLoginBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void fechaTelas()
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
