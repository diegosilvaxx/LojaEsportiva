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
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALFornecedor(AcessoBD conexao)
        {
            objConexao = conexao;
        }
        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz o cadastro no banco
        public void Inserir(Fornecedor fornecedor)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que insere na tabela Fornecedor do banco
            cmd.CommandText = "insert into fornecedor(nome, cnpj, email, ddd, numero, tipo) values (@nome, @cnpj, @email, @ddd, @numero, @tipo);";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);
            cmd.Parameters.AddWithValue("@ddd", fornecedor.telefoneFornecedor.Ddd);
            cmd.Parameters.AddWithValue("@numero", fornecedor.telefoneFornecedor.Numero);
            cmd.Parameters.AddWithValue("@tipo", fornecedor.telefoneFornecedor.Tipo);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Fecha a conexao do banco
            objConexao.Desconectar();
        }

        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz a alteraçao no banco
        public void Alterar(Fornecedor fornecedor)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que altera na tabela Fornecedor do banco
            cmd.CommandText = "update fornecedor set nome=@nome,cnpj=@cnpj,email=@email, ddd=@ddd, numero=@numero, tipo=@tipo where id_fornecedor=@idfornecedor;";
            //Adicionando os atributos do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@idfornecedor", fornecedor.IdFornecedor);
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);
            cmd.Parameters.AddWithValue("@ddd", fornecedor.telefoneFornecedor.Ddd);
            cmd.Parameters.AddWithValue("@numero", fornecedor.telefoneFornecedor.Numero);
            cmd.Parameters.AddWithValue("@tipo", fornecedor.telefoneFornecedor.Tipo);

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
            cmd.Parameters.AddWithValue("@idfornecedor", codigo);

            //Comando que deleta na tabela Fornecedor do banco
            cmd.CommandText = "DELETE FROM fornecedor where id_fornecedor=@idfornecedor";

            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que faz a pesquisa de fornecedor no banco por nome
        public DataTable PesquisarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from fornecedor where fornecedor.nome like '%" + valor + "%'", objConexao.StringConexao);

            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco por cnpj
        public DataTable PesquisarPorCnpj(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from fornecedor where fornecedor.cnpj like '%" + valor + "%'", objConexao.StringConexao);

            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from fornecedor;", objConexao.StringConexao);
            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que tras do banco os dados do Fornecedor e armazena-os em seus atributos da classe
        public Fornecedor carregaFornecedor(int codigo)
        {
            //Cria um objeto do tipo Fornecedor que irá armazenar os dados que virao do banco
            Fornecedor fornecedor = new Fornecedor();
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Comando que pesquisa na tabela Fornecedor do banco
            cmd.CommandText = "select * from fornecedor where fornecedor.id_fornecedor =" + codigo.ToString();
            //Abre a conexao do banco
            objConexao.Conectar();
            //Cria um objeto do tipo MySqlDataReader e executa as linhas de comandos no banco como leitura
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                fornecedor.IdFornecedor = Convert.ToInt32(registro["id_fornecedor"]);
                fornecedor.Nome = Convert.ToString(registro["nome"]);
                fornecedor.Cnpj = Convert.ToString(registro["cnpj"]);
                fornecedor.Email = Convert.ToString(registro["email"]);
                fornecedor.telefoneFornecedor.Ddd = Convert.ToString(registro["ddd"]);
                fornecedor.telefoneFornecedor.Numero = Convert.ToString(registro["numero"]);
                fornecedor.telefoneFornecedor.Tipo = Convert.ToString(registro["tipo"]);

            }
            return fornecedor;
        }
    }
}
