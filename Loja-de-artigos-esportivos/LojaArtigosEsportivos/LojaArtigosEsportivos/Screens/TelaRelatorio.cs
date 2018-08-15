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
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public decimal total;
        private void TelaRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                DALRelatorio dALRelatorio = new DALRelatorio();

                consultaVendaGridview.DataSource = dALRelatorio.Pesquisar();
                alterarNomesCulunasGridView();
                valorTotal();
                valorTotalVendaTbx.Text = total.ToString("C2");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }
        public void alterarNomesCulunasGridView()
        {
            consultaVendaGridview.Columns[0].HeaderText = "Modelo";
            consultaVendaGridview.Columns[1].HeaderText = "Produto";
            consultaVendaGridview.Columns[2].HeaderText = "Quantidade";
            consultaVendaGridview.Columns[3].HeaderText = "Preço";
    

        }

        private void cancelarTelaRelatorioBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private decimal valorTotal()
        {
            total = 0;
            int i = 0;
            decimal qtd = 0;
            decimal valor = 0;
            
            for (i = 0; i < consultaVendaGridview.Rows.Count; i++)
            {
                qtd = Convert.ToDecimal(consultaVendaGridview.Rows[i].Cells[2].Value);
                valor = Convert.ToDecimal(consultaVendaGridview.Rows[i].Cells[3].Value);

                total = total + ( qtd * valor);
            }
            return total;
        }

        private void valorTotalVendaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelarTelaRelatorioBtn_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
