using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class DALVenda
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();
        public int _idCompra;
        public DALVenda()
        {

        }
        public void Inserir(Venda venda)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "insert into compra(id_cliente, nome_cliente, valor_total) values (@id_cliente, @nome_cliente, @valor_total);";
            cmd.Parameters.AddWithValue("@id_cliente", venda.IdCliente);
            cmd.Parameters.AddWithValue("@nome_cliente", venda.NomeCliente);
            cmd.Parameters.AddWithValue("@valor_total", venda.ValorTotal);
            cmd.ExecuteNonQuery();

            _idCompra = Convert.ToInt32(cmd.LastInsertedId);

            conn.Close();
        }

        public void AtualizarEstoque(decimal quantidade, int idProdutoEstoque)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "update produto set quantidade=@quantidade where id_produto=@idProduto;";
            cmd.Parameters.AddWithValue("@idProduto", idProdutoEstoque);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0;";
            cmd.ExecuteNonQuery();

            cmd.Parameters.AddWithValue("@idCompra", codigo);
            cmd.CommandText = "DELETE FROM compra, produto_compra USING compra, produto_compra WHERE compra.id_compra = @idCompra AND produto_compra.id_compra = @idCompra;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 1;";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable PesquisarPorNomeCliente(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total from compra v join cliente c on v.id_cliente = c.id_cliente where v.nome_cliente like '%" + valor + "%'", conn);

            dadosVenda.Fill(tabela);
            return tabela;
        }
        public DataTable PesquisarPorCpf(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total from compra v join cliente c on v.id_cliente = c.id_cliente where c.cpf like '%" + valor + "%'", conn);

            dadosVenda.Fill(tabela);
            return tabela;
        }
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_compra, v.nome_cliente, c.cpf, v.valor_total from compra v, cliente c where v.id_cliente = c.id_cliente;", conn);
            dadosVenda.Fill(tabela);
            return tabela;
        }
        /*
        public Venda carregaVenda(int codigo)
        {
            Venda venda = new Venda();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from compra where compra.id_compra =" + codigo.ToString();
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                venda.IdVenda = Convert.ToInt32(registro["id_venda"]);
                venda.NomeCliente = Convert.ToString(registro["nome_cliente"]);
                venda.ValorTotal = Convert.ToDecimal(registro["valor_total"]);
                venda.produtosVenda.Modelo = Convert.ToString(registro["modelo"]);
                venda.produtosVenda.QtdProduto = Convert.ToInt32(registro["quantidade"]);
                venda.produtosVenda.TipoProduto = Convert.ToString(registro["tipo_produto"]);
            }
            return venda;
        }*/
        
        public void InserirProdutos(Venda venda)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "insert into produto_compra(id_produto, categoria, modelo, quantidade, id_compra, preco) values (@id_produto, @categoria, @modelo, @quantidade, @id_compra, @preco);";
            cmd.Parameters.AddWithValue("@id_compra", _idCompra);
            cmd.Parameters.AddWithValue("@categoria", venda.produtosVenda.Categoria);
            cmd.Parameters.AddWithValue("@id_produto", venda.produtosVenda.IdProduto);
            cmd.Parameters.AddWithValue("@modelo", venda.produtosVenda.Modelo);
            cmd.Parameters.AddWithValue("@quantidade", venda.produtosVenda.QtdProduto);
            cmd.Parameters.AddWithValue("@preco", venda.produtosVenda.Preco);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Produto getValorAndQtdProduto(string modelo)
        {

            Produto produto = new Produto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select preco,quantidade,id_produto,descricao from produto where produto.modelo = '" + modelo + "';";
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                produto.IdProduto = Convert.ToInt32(registro["id_produto"]);
                produto.Quantidade = Convert.ToInt32(registro["quantidade"]);
                produto.Preco = Convert.ToDecimal(registro["preco"]);
                produto.Descricao = Convert.ToString(registro["descricao"]);
            }
            conn.Close();
            return produto;
        }
  

        public DataTable carregaComboBoxProduto(string categoria)
        {

            DataTable dtTabelas = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select modelo from produto where categoria = '" + categoria + "';", conn);
            da.Fill(dtTabelas);

            conn.Close();

            return dtTabelas;
        }

        public decimal calculaPrecoVenda(decimal valorAtualVenda, decimal qtdValorVenda, decimal precoProduto)
        {
            decimal totalAPagar = 0;
            decimal precoAPagar = 0;

            precoAPagar = (qtdValorVenda * precoProduto);
            totalAPagar = valorAtualVenda + precoAPagar;

            return totalAPagar;
        }
    }
}
