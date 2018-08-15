using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;

namespace LojaArtigosEsportivos
{
    public class DALUsuario
    {
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;

        public int _idVenda;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALUsuario(AcessoBD conexao)
        {
            objConexao = conexao;
        }
        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz o cadastro no banco
        public bool VerificaUsuario(UsuarioSistema usuarioSistema)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            int retorno = -1;
            cmd.CommandText = "select * from usuario where usuario=@usuario and senha=@senha;";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@usuario", usuarioSistema.Usuario);
            cmd.Parameters.AddWithValue("@senha", usuarioSistema.Senha);

            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //Fecha a conexao do banco
            objConexao.Desconectar();

            if(retorno > 0)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }

        public void Inserir(UsuarioSistema usuarioSistema)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que insere na tabela Fornecedor do banco
            cmd.CommandText = "insert into usuario(nome, usuario, senha) values (@nome, @usuario, @senha);";
            //Adicionando os atributos do objeto Fornecedor nos parametros
            cmd.Parameters.AddWithValue("@nome", usuarioSistema.Nome);
            cmd.Parameters.AddWithValue("@usuario", usuarioSistema.Usuario);
            cmd.Parameters.AddWithValue("@senha", usuarioSistema.Senha);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Fecha a conexao do banco
            objConexao.Desconectar();
        }

        //Metodo que atribui nos parametros os atributos do objeto Fornecedor e faz a alteraçao no banco
        public void Alterar(UsuarioSistema usuarioSistema)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que altera na tabela Fornecedor do banco
            cmd.CommandText = "update usuario set nome=@nome,usuario=@usuario,senha=@senha where id_usuario=@idusuario;";
            //Adicionando os atributos do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@idusuario", usuarioSistema.IdUsuario);
            // cmd.Parameters.AddWithValue("@nomefornecedor", bola.NomeFornecedor);
            cmd.Parameters.AddWithValue("@nome", usuarioSistema.Nome);
            cmd.Parameters.AddWithValue("@usuario", usuarioSistema.Usuario);
            cmd.Parameters.AddWithValue("@senha", usuarioSistema.Senha);

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
            cmd.Parameters.AddWithValue("@idusuario", codigo);

            //Comando que deleta na tabela Fornecedor do banco
            cmd.CommandText = "DELETE FROM usuario where id_usuario=@idusuario";

            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que faz a pesquisa de fornecedor no banco por nome
        public DataTable PesquisarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosUsuario = new MySqlDataAdapter("select usuario.id_usuario,usuario.nome,usuario.usuario from usuario where usuario.nome like '%" + valor + "%'", objConexao.StringConexao);

            dadosUsuario.Fill(tabela);
            return tabela;
        }
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosUsuario = new MySqlDataAdapter("select usuario.id_usuario,usuario.nome,usuario.usuario from usuario;", objConexao.StringConexao);

            dadosUsuario.Fill(tabela);
            return tabela;
        }

        public UsuarioSistema carregaUsuario(int codigo)
        {
            //Cria um objeto do tipo Fornecedor que irá armazenar os dados que virao do banco
            UsuarioSistema usuarioSistema = new UsuarioSistema();
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Comando que pesquisa na tabela Fornecedor do banco
            cmd.CommandText = "select * from usuario where usuario.id_usuario =" + codigo.ToString();
            //Abre a conexao do banco
            objConexao.Conectar();
            //Cria um objeto do tipo MySqlDataReader e executa as linhas de comandos no banco como leitura
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                usuarioSistema.Nome = Convert.ToString(registro["nome"]);
                usuarioSistema.Usuario = Convert.ToString(registro["usuario"]);
                usuarioSistema.Senha = Convert.ToString(registro["senha"]);

            }
            return usuarioSistema;
        }
    }
}
