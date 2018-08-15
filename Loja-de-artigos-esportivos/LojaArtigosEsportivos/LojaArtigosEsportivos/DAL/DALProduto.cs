using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class DALProduto
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public void Inserir(Produto produto)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "insert into produto(id_grupo, categoria, id_fornecedor, nome_fornecedor, marca, modelo, descricao, quantidade, preco) values (@idGrupo, @categoria, @idFornecedor, @nomeFornecedor, @marca, @modelo, @descricao, @quantidade, @preco);";
            cmd.Parameters.AddWithValue("@idGrupo", produto.IdGrupo);
            cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
            cmd.Parameters.AddWithValue("@idFornecedor", produto.IdFornecedor);
            cmd.Parameters.AddWithValue("@nomeFornecedor", produto.NomeFornecedor);
            cmd.Parameters.AddWithValue("@marca", produto.Marca);
            cmd.Parameters.AddWithValue("@modelo", produto.Modelo);
            cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            cmd.Parameters.AddWithValue("@preco", produto.Preco);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Alterar(Produto produto)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update produto set id_grupo=@idGrupo, categoria=@categoria, marca=@marca,modelo=@modelo, quantidade=@quantidade, preco=@preco, descricao=@descricao where id_produto=@idProduto;";
            cmd.Parameters.AddWithValue("@idGrupo", produto.IdGrupo);
            cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
            cmd.Parameters.AddWithValue("@idProduto", produto.IdProduto);
            cmd.Parameters.AddWithValue("@marca", produto.Marca);
            cmd.Parameters.AddWithValue("@modelo", produto.Modelo);
            cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            cmd.Parameters.AddWithValue("@preco", produto.Preco);
            cmd.Parameters.AddWithValue("@descricao", produto.Descricao);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Excluir(int codigo)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@idProduto", codigo);
            cmd.CommandText = "DELETE FROM produto where id_produto=@idProduto";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable PesquisarPorMarca(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCalcado = new MySqlDataAdapter("select id_produto,modelo,preco,quantidade,descricao,categoria,marca,nome_fornecedor,id_fornecedor,id_grupo from produto where produto.marca like '%" + valor + "%'", conn);

            dadosCalcado.Fill(tabela);
            return tabela;
        }
        public DataTable PesquisarPorModelo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCalcado = new MySqlDataAdapter("select id_produto,modelo,preco,quantidade,descricao,categoria,marca,nome_fornecedor,id_fornecedor,id_grupo from produto where produto.modelo like '%" + valor + "%'", conn);

            dadosCalcado.Fill(tabela);
            return tabela;
        }
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCalcado = new MySqlDataAdapter("select id_produto,modelo,preco,quantidade,descricao,categoria,marca,nome_fornecedor,id_fornecedor,id_grupo from produto where id_produto = id_produto;", conn);
            dadosCalcado.Fill(tabela);
            return tabela;
        }
        public Produto carregaProduto(int codigo)
        {
            Produto produto = new Produto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from produto where produto.id_produto =" + codigo.ToString();
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                produto.IdProduto = Convert.ToInt32(registro["id_produto"]);
                produto.IdGrupo = Convert.ToInt32(registro["id_grupo"]);
                produto.Categoria = Convert.ToString(registro["categoria"]);
                produto.Marca = Convert.ToString(registro["marca"]);
                produto.Modelo = Convert.ToString(registro["modelo"]);
                produto.Quantidade = Convert.ToInt32(registro["quantidade"]);
                produto.Preco = Convert.ToDecimal(registro["preco"]);
                produto.Descricao = Convert.ToString(registro["descricao"]);

            }
            conn.Close();
            return produto;
        }

        public DataTable carregaComboBoxCategoria()
        {

            DataTable dtTabelas = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select categoria from grupo where estado_categoria = 'S'", conn);
            da.Fill(dtTabelas);

            conn.Close();

            return dtTabelas;
        }

        public Produto getIdCategoria(string categoria)
        {
            Produto produto = new Produto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id_grupo,estado_categoria from grupo where grupo.categoria = '" + categoria + "';";
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                produto.IdGrupo = Convert.ToInt32(registro["id_grupo"]);
            }
            conn.Close();
            return produto;
        }
    }
}
