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
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;

        public int _idVenda;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALRelatorio(AcessoBD conexao)
        {
            objConexao = conexao;
        }

        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dataRelatorio = new MySqlDataAdapter("select p.modelo,p.tipo_produto,p.quantidade,p.preco from venda v join produto_venda p where v.id_venda like p.id_venda;", objConexao.StringConexao);
            dataRelatorio.Fill(tabela);
            return tabela;
        }
    }
}
