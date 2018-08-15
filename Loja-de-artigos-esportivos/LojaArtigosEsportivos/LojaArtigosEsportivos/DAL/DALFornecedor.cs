using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaArtigosEsportivos
{
    public class DALFornecedor
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();
        public DALFornecedor()
        {
           
        }
        public void Inserir(Fornecedor fornecedor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "insert into fornecedor(nome, cnpj, email, ddd, numero, tipo_numero) values (@nome, @cnpj, @email, @ddd, @numero, @tipo);";
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);
            cmd.Parameters.AddWithValue("@ddd", fornecedor.Ddd);
            cmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
            cmd.Parameters.AddWithValue("@tipo", fornecedor.Tipo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void Alterar(Fornecedor fornecedor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update fornecedor set nome=@nome,cnpj=@cnpj,email=@email, ddd=@ddd, numero=@numero, tipo_numero=@tipo where id_fornecedor=@idfornecedor;";
            cmd.Parameters.AddWithValue("@idfornecedor", fornecedor.IdFornecedor);
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);
            cmd.Parameters.AddWithValue("@ddd", fornecedor.Ddd);
            cmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
            cmd.Parameters.AddWithValue("@tipo", fornecedor.Tipo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            conn.Open();

            cmd.Parameters.AddWithValue("@idfornecedor", codigo);
            cmd.CommandText = "DELETE FROM fornecedor where id_fornecedor=@idfornecedor";

            cmd.ExecuteNonQuery();
 
            conn.Close();
        }
        public DataTable PesquisarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosForncedor = new MySqlDataAdapter("select * from fornecedor where fornecedor.nome like '%" + valor + "%'", conn);

            dadosForncedor.Fill(tabela);
            return tabela;
        }
        public DataTable PesquisarPorCnpj(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosForncedor = new MySqlDataAdapter("select * from fornecedor where fornecedor.cnpj like '%" + valor + "%'", conn);

            dadosForncedor.Fill(tabela);
            return tabela;
        }
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosForncedor = new MySqlDataAdapter("select * from fornecedor;", conn);
            dadosForncedor.Fill(tabela);
            return tabela;
        }
        public Fornecedor carregaFornecedor(int codigo)
        {
            Fornecedor fornecedor = new Fornecedor();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from fornecedor where fornecedor.id_fornecedor =" + codigo.ToString();
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                fornecedor.IdFornecedor = Convert.ToInt32(registro["id_fornecedor"]);
                fornecedor.Nome = Convert.ToString(registro["nome"]);
                fornecedor.Cnpj = Convert.ToString(registro["cnpj"]);
                fornecedor.Email = Convert.ToString(registro["email"]);
                fornecedor.Ddd = Convert.ToString(registro["ddd"]);
                fornecedor.Numero = Convert.ToString(registro["numero"]);
                fornecedor.Tipo = Convert.ToString(registro["tipo_numero"]);

            }
            conn.Close();
            return fornecedor;
        }
    }
}
