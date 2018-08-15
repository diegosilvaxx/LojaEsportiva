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
    public class DALCalcado
    {
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALCalcado(AcessoBD conexao)
        {
            objConexao = conexao;
        }
        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz o cadastro no banco
        public void Inserir(Calcado calcado)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que insere na tabela Fornecedor do banco
            cmd.CommandText = "insert into calcado(nome_fornecedor,marca, modelo, tamanho, cor, quantidade, preco) values (@nomefornecedor, @marca, @modelo, @tamanho, @cor, @quantidade, @preco);";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@nomefornecedor", calcado.NomeFornecedor);
            cmd.Parameters.AddWithValue("@marca", calcado.Marca);
            cmd.Parameters.AddWithValue("@modelo", calcado.Modelo);
            cmd.Parameters.AddWithValue("@tamanho", calcado.Tamanho);
            cmd.Parameters.AddWithValue("@cor", calcado.Cor);
            cmd.Parameters.AddWithValue("@quantidade", calcado.Quantidade);
            cmd.Parameters.AddWithValue("@preco", calcado.Preco);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Fecha a conexao do banco
            objConexao.Desconectar();
        }

        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz a alteraçao no banco
        public void Alterar(Calcado calcado)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que altera na tabela Fornecedor do banco
            cmd.CommandText = "update calcado set marca=@marca,modelo=@modelo,tamanho=@tamanho, cor=@cor, quantidade=@quantidade, preco=@preco where id_calcado=@idcalcado;";
            //Adicionando os atributos do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@idcalcado", calcado.IdCalcado);
            //cmd.Parameters.AddWithValue("@nomefornecedor", calcado.NomeFornecedor);
            cmd.Parameters.AddWithValue("@marca", calcado.Marca);
            cmd.Parameters.AddWithValue("@modelo", calcado.Modelo);
            cmd.Parameters.AddWithValue("@tamanho", calcado.Tamanho);
            cmd.Parameters.AddWithValue("@cor", calcado.Cor);
            cmd.Parameters.AddWithValue("@quantidade", calcado.Quantidade);
            cmd.Parameters.AddWithValue("@preco", calcado.Preco);

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
            cmd.Parameters.AddWithValue("@idcalcado", codigo);

            //Comando que deleta na tabela Fornecedor do banco
            cmd.CommandText = "DELETE FROM calcado where id_calcado=@idcalcado";

            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que faz a pesquisa de fornecedor no banco por nome
        public DataTable PesquisarPorMarca(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from calcado where calcado.marca like '%" + valor + "%'", objConexao.StringConexao);

            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco por cnpj
        public DataTable PesquisarPorModelo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from calcado where calcado.modelo like '%" + valor + "%'", objConexao.StringConexao);

            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de fornecedor no banco
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from calcado;", objConexao.StringConexao);
            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que tras do banco os dados do Fornecedor e armazena-os em seus atributos da classe
        public Calcado carregaCalcado(int codigo)
        {
            //Cria um objeto do tipo Fornecedor que irá armazenar os dados que virao do banco
            Calcado calcado = new Calcado();
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Comando que pesquisa na tabela Fornecedor do banco
            cmd.CommandText = "select * from calcado where calcado.id_calcado =" + codigo.ToString();
            //Abre a conexao do banco
            objConexao.Conectar();
            //Cria um objeto do tipo MySqlDataReader e executa as linhas de comandos no banco como leitura
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                calcado.IdCalcado = Convert.ToInt32(registro["id_calcado"]);
                calcado.NomeFornecedor = Convert.ToString(registro["nome_fornecedor"]);
                calcado.Marca = Convert.ToString(registro["marca"]);
                calcado.Modelo = Convert.ToString(registro["modelo"]);
                calcado.Tamanho = Convert.ToString(registro["tamanho"]);
                calcado.Cor = Convert.ToString(registro["cor"]);
                calcado.Quantidade = Convert.ToInt32(registro["quantidade"]);
                calcado.Preco = Convert.ToDecimal(registro["preco"]);

            }
            return calcado;
        }
    }
}
