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
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int _idVenda;
        public DALUsuario()
        {

        }
        public bool VerificaUsuario(UsuarioSistema usuarioSistema)
        {
            MySqlCommand cmd = new MySqlCommand();
            UsuarioSistema usuario = new UsuarioSistema();
            cmd.Connection = conn;
            
            cmd.CommandText = "select * from usuario where usuario=@usuario;";
            cmd.Parameters.AddWithValue("@usuario", usuarioSistema.Usuario);

            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read()) {
                usuario.Usuario = registro.GetString(2);
                usuario.Senha = registro.GetString(3);
            }
            registro.Dispose();
            conn.Dispose();

            return usuarioSistema.Senha.Equals(usuario.Senha);
        }

        public void Inserir(UsuarioSistema usuarioSistema)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "insert into usuario(nome, usuario, senha) values (@nome, @usuario, @senha);";
            cmd.Parameters.AddWithValue("@nome", usuarioSistema.Nome);
            cmd.Parameters.AddWithValue("@usuario", usuarioSistema.Usuario);
            cmd.Parameters.AddWithValue("@senha", usuarioSistema.Senha);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Alterar(UsuarioSistema usuarioSistema)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update usuario set nome=@nome,usuario=@usuario,senha=@senha where id_usuario=@idusuario;";
            cmd.Parameters.AddWithValue("@idusuario", usuarioSistema.IdUsuario);
            cmd.Parameters.AddWithValue("@nome", usuarioSistema.Nome);
            cmd.Parameters.AddWithValue("@usuario", usuarioSistema.Usuario);
            cmd.Parameters.AddWithValue("@senha", usuarioSistema.Senha);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@idusuario", codigo);
            cmd.CommandText = "DELETE FROM usuario where id_usuario=@idusuario";

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public DataTable PesquisarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosUsuario = new MySqlDataAdapter("select usuario.id_usuario,usuario.nome,usuario.usuario from usuario where usuario.nome like '%" + valor + "%'", conn);

            dadosUsuario.Fill(tabela);
            return tabela;
        }
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosUsuario = new MySqlDataAdapter("select usuario.id_usuario,usuario.nome,usuario.usuario from usuario;", conn);

            dadosUsuario.Fill(tabela);
            return tabela;
        }

        public UsuarioSistema carregaUsuario(int codigo)
        {
            UsuarioSistema usuarioSistema = new UsuarioSistema();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from usuario where usuario.id_usuario =" + codigo.ToString();
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                usuarioSistema.Nome = Convert.ToString(registro["nome"]);
                usuarioSistema.Usuario = Convert.ToString(registro["usuario"]);
                usuarioSistema.Senha = Convert.ToString(registro["senha"]);

            }
            conn.Close();
            return usuarioSistema;
        }
    }
}
