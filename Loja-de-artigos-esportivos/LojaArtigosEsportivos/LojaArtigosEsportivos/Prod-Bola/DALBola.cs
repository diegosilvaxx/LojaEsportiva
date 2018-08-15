using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaArtigosEsportivos
{
    public class DALBola
    {
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALBola(AcessoBD conexao)
        {
            objConexao = conexao;
        }
        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz o cadastro no banco
        public void Inserir(Bola bola)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que insere na tabela Fornecedor do banco
            cmd.CommandText = "insert into bola(nome_fornecedor, marca, modelo, calibragem, cor, quantidade, preco) values (@nomefornecedor, @marca, @modelo, @calibragem, @cor, @quantidade, @preco);";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@nomefornecedor", bola.NomeFornecedor);
            cmd.Parameters.AddWithValue("@marca", bola.Marca);
            cmd.Parameters.AddWithValue("@modelo", bola.Modelo);
            cmd.Parameters.AddWithValue("@calibragem", bola.Calibragem);
            cmd.Parameters.AddWithValue("@cor", bola.Cor);
            cmd.Parameters.AddWithValue("@quantidade", bola.Quantidade);
            cmd.Parameters.AddWithValue("@preco", bola.Preco);



            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Fecha a conexao do banco
            objConexao.Desconectar();
        }

        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz a alteraçao no banco
        public void Alterar(Bola bola)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que altera na tabela Fornecedor do banco
            cmd.CommandText = "update bola set marca=@marca,modelo=@modelo,calibragem=@calibragem, cor=@cor, quantidade=@quantidade, preco=@preco where id_bola=@idbola;";
            //Adicionando os atributos do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@idbola", bola.IdBola);
            // cmd.Parameters.AddWithValue("@nomefornecedor", bola.NomeFornecedor);
            cmd.Parameters.AddWithValue("@marca", bola.Marca);
            cmd.Parameters.AddWithValue("@modelo", bola.Modelo);
            cmd.Parameters.AddWithValue("@calibragem", bola.Calibragem);
            cmd.Parameters.AddWithValue("@cor", bola.Cor);
            cmd.Parameters.AddWithValue("@quantidade", bola.Quantidade);
            cmd.Parameters.AddWithValue("@preco", bola.Preco);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que identifica a chave primaria do Fornecedor e seta no parametro e faz a exclusao do mesmo no banco
        public void Excluir(int codigo)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();

            //Adicionando o atributo primario do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@idbola", codigo);

            //Comando que deleta na tabela Fornecedor do banco
            cmd.CommandText = "DELETE FROM bola where id_bola=@idbola";

            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que faz a pesquisa de fornecedor no banco por nome
        public DataTable PesquisarPorMarca(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from bola where bola.marca like '%" + valor + "%'", objConexao.StringConexao);

            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco por cnpj
        public DataTable PesquisarPorModelo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from bola where bola.modelo like '%" + valor + "%'", objConexao.StringConexao);

            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from bola;", objConexao.StringConexao);
            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que tras do banco os dados do Fornecedor e armazena-os em seus atributos da classe
        public Bola carregaBola(int codigo)
        {
            //Cria um objeto do tipo Fornecedor que irá armazenar os dados que virao do banco
            Bola bola = new Bola();
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Comando que pesquisa na tabela Fornecedor do banco
            cmd.CommandText = "select * from bola where bola.id_bola =" + codigo.ToString();
            //Abre a conexao do banco
            objConexao.Conectar();
            //Cria um objeto do tipo MySqlDataReader e executa as linhas de comandos no banco como leitura
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                bola.IdBola = Convert.ToInt32(registro["id_bola"]);
                bola.NomeFornecedor = Convert.ToString(registro["nome_fornecedor"]);
                bola.Marca = Convert.ToString(registro["marca"]);
                bola.Modelo = Convert.ToString(registro["modelo"]);
                bola.Calibragem = Convert.ToString(registro["calibragem"]);
                bola.Cor = Convert.ToString(registro["cor"]);
                bola.Quantidade = Convert.ToInt32(registro["quantidade"]);
                bola.Preco = Convert.ToDecimal(registro["preco"]);

            }
            return bola;
        }
    }
}
