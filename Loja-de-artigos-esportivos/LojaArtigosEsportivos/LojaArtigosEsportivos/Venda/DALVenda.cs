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
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;

        public int _idVenda;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALVenda(AcessoBD conexao)
        {
            objConexao = conexao;
        }
        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz o cadastro no banco
        public void Inserir(Venda venda)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
       
            cmd.CommandText = "insert into venda(id_cliente, nome_cliente, valor_total) values (@id_cliente, @nome_cliente, @valor_total);";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@id_cliente", venda.IdCliente);
            cmd.Parameters.AddWithValue("@nome_cliente", venda.NomeCliente);
            cmd.Parameters.AddWithValue("@valor_total", venda.ValorTotal);
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Essa variavel pegara no banco o ultimo id registrado e a armazenará
            _idVenda = Convert.ToInt32(cmd.LastInsertedId);
       
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }

        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz a alteraçao no banco
        public void AtualizarEstoque(string tipoProduto,decimal quantidade,int idProdutoEstoque)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();

            if(tipoProduto == "Bola")
            {
                //Comando que altera na tabela Fornecedor do banco
                cmd.CommandText = "update bola set quantidade=@quantidade where id_bola=@idbola;";
                //Adicionando os atributos do objeto Cliente nos parametros
                cmd.Parameters.AddWithValue("@idbola", idProdutoEstoque);
                // cmd.Parameters.AddWithValue("@nomefornecedor", bola.NomeFornecedor);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                //Executa as linhas de comandos
                cmd.ExecuteNonQuery();
                //Fecha a conexao do banco
                objConexao.Desconectar();
            }
            else
            {
                //Comando que altera na tabela Fornecedor do banco
                cmd.CommandText = "update calcado set quantidade=@quantidade where id_calcado=@idcalcado;";
                //Adicionando os atributos do objeto Cliente nos parametros
                cmd.Parameters.AddWithValue("@idcalcado", idProdutoEstoque);
                // cmd.Parameters.AddWithValue("@nomefornecedor", bola.NomeFornecedor);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                //Executa as linhas de comandos
                cmd.ExecuteNonQuery();
                //Fecha a conexao do banco
                objConexao.Desconectar();
            }

        }
        
        public void Excluir(int codigo)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0;";
            //Adicionando o atributo primario do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@idvenda", codigo);
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Comando que deleta na tabela Fornecedor do banco
            cmd.CommandText = "DELETE FROM venda, produto_venda USING venda, produto_venda WHERE venda.id_venda = @idvenda AND produto_venda.id_venda = @idvenda;";
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Comando que deleta na tabela Cliente do banco
            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 1;";
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();

        }
        //Metodo que faz a pesquisa de fornecedor no banco por nome
        public DataTable PesquisarPorNomeCliente(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_venda, v.nome_cliente, c.cpf, v.valor_total from venda v, cliente c where v.nome_cliente like '%" + valor + "%'", objConexao.StringConexao);

            dadosVenda.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco por cnpj
        public DataTable PesquisarPorCpf(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosVenda = new MySqlDataAdapter("select v.id_venda, v.nome_cliente, c.cpf, v.valor_total from venda v inner join cliente c where c.cpf like '%" + valor + "%'", objConexao.StringConexao);

            dadosVenda.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select v.id_venda, v.nome_cliente,v.valor_total from venda v  where v.id_venda like v.id_venda;", objConexao.StringConexao);
            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que tras do banco os dados do Fornecedor e armazena-os em seus atributos da classe
        public Venda carregaVenda(int codigo)
        {
            //Cria um objeto do tipo Fornecedor que irá armazenar os dados que virao do banco
            Venda venda = new Venda();
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Comando que pesquisa na tabela Fornecedor do banco
            cmd.CommandText = "select * from venda where venda.id_venda =" + codigo.ToString();
            //Abre a conexao do banco
            objConexao.Conectar();
            //Cria um objeto do tipo MySqlDataReader e executa as linhas de comandos no banco como leitura
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                venda.IdVenda = Convert.ToInt32(registro["id_venda"]);
                venda.NomeCliente = Convert.ToString(registro["nome_cliente"]);
                venda.ValorTotal = Convert.ToDecimal(registro["valor_total"]);
                venda.produtosVenda.IdProduto = Convert.ToInt32(registro["id_produto"]);
                venda.produtosVenda.Modelo = Convert.ToString(registro["modelo"]);
                venda.produtosVenda.QtdProduto = Convert.ToInt32(registro["quantidade"]);
                venda.produtosVenda.TipoProduto = Convert.ToString(registro["tipo_produto"]);
            }
            return venda;
        }


        public void InserirProdutos(Venda venda)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que insere na tabela Fornecedor do banco
            cmd.CommandText = "insert into produto_venda(tipo_produto, modelo, quantidade, id_venda, preco) values (@tipo_produto, @modelo, @quantidade, @id_venda, @preco);";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@id_venda", _idVenda);
            cmd.Parameters.AddWithValue("@tipo_produto", venda.produtosVenda.TipoProduto);
            cmd.Parameters.AddWithValue("@modelo", venda.produtosVenda.Modelo);
            cmd.Parameters.AddWithValue("@quantidade", venda.produtosVenda.QtdProduto);
            cmd.Parameters.AddWithValue("@preco", venda.produtosVenda.Preco);
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Fecha a conexao do banco
            objConexao.Desconectar();
        }    
        
    }
}
