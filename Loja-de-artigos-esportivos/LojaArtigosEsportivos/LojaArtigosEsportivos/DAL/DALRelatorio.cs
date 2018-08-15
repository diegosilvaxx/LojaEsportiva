using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LojaArtigosEsportivos
{
    public class DALRelatorio
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int _idVenda;
        public DALRelatorio()
        {
            
        }

        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dataRelatorio = new MySqlDataAdapter("select p.modelo,p.categoria,p.quantidade,p.preco from compra v join produto_compra p where v.id_compra like p.id_compra;", conn);
            dataRelatorio.Fill(tabela);
            return tabela;
        }
    }
}
