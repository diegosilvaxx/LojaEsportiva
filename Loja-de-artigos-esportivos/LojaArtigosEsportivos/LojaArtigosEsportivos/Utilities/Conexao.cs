using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LojaArtigosEsportivos


    
{
    class Conexao
    {
        private string _stringConexao;


        /* public Conexao(String dadosConexao)
         {
             this._conexao = new MySqlConnection();
             this.StringConexao = dadosConexao;
             this._conexao.ConnectionString = dadosConexao; 
          }*/

        


        public Conexao()
        {
            _stringConexao = @"server=localhost; port=3306;userid=root;database=loja_esportivo; password = ;Sslmode = none;";
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public MySqlConnection ObjetoConexao()
        {
            MySqlConnection conn = new MySqlConnection(_stringConexao);
            return conn;
        }


    }


}
