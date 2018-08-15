using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class DALGrupo
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public void Inserir(Grupo grupo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "insert into grupo(categoria, estado_categoria) values (@categoria, @estadoCategoria);";
            cmd.Parameters.AddWithValue("@categoria", grupo.Categoria);
            cmd.Parameters.AddWithValue("@estadoCategoria", grupo.EstadoCategoria);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Alterar(Grupo grupo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update grupo set estado_categoria=@estadoCategoria where id_grupo=@idGrupo;";
            cmd.Parameters.AddWithValue("@idGrupo", grupo.IdGrupo);
            cmd.Parameters.AddWithValue("@estadoCategoria", grupo.EstadoCategoria);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Excluir(int codigo)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@idGrupo", codigo);
            cmd.CommandText = "DELETE FROM grupo where id_grupo=@idGrupo";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable PesquisarPorCategoria(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCalcado = new MySqlDataAdapter("select * from grupo where grupo.categoria like '%" + valor + "%'", conn);

            dadosCalcado.Fill(tabela);
            return tabela;
        }

        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCalcado = new MySqlDataAdapter("select * from grupo;", conn);
            dadosCalcado.Fill(tabela);
            return tabela;
        }


        public Produto checaProdutoLinkado(int codigo)
        {
            Produto produto = new Produto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id_grupo from produto where produto.id_grupo =" + codigo.ToString();
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

        public Grupo getEstadoCategoria(int idGrupo)
        {
            Grupo grupo = new Grupo();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select estado_categoria from grupo where grupo.id_grupo = '" + idGrupo + "';";
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                grupo.EstadoCategoria = Convert.ToChar(registro["estado_categoria"]);
            }
            conn.Close();
            return grupo;
        }
    }
}
