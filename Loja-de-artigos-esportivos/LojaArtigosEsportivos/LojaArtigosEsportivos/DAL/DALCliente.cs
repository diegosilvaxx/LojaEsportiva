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
    public class DALCliente
    {
        MySqlConnection conn = new Conexao().ObjetoConexao();
        public DALCliente()
        {
            
        }
        public void Inserir(Cliente cliente)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "insert into cliente(nome, cpf, email, data_nascimento, sexo, ddd, numero_telefone, tipo_numero, rua, bairro, estado, cidade, numero_endereco) values (@nome, @cpf, @email, @data_nascimento, @sexo, @ddd, @numero_telefone, @tipo_numero, @rua, @bairro, @estado, @cidade, @numeroCasa);";         
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);            
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNasc);
            cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);     
            cmd.Parameters.AddWithValue("@rua", cliente.Rua);
            cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@numeroCasa", cliente.NumeroCasa);
            cmd.Parameters.AddWithValue("@ddd", cliente.Ddd);
            cmd.Parameters.AddWithValue("@numero_telefone", cliente.Numero);
            cmd.Parameters.AddWithValue("@tipo_numero", cliente.Tipo);

            cmd.ExecuteNonQuery();

            int idcliente = Convert.ToInt32(cmd.LastInsertedId);

            conn.Close();
        }

        public void Alterar(Cliente cliente)
        {
            MySqlConnection conn = new Conexao().ObjetoConexao();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update cliente set nome=@nome,cpf=@cpf,email=@email,data_nascimento=@data_nascimento, sexo=@sexo, ddd=@ddd,numero_telefone=@numero_telefone,tipo_numero=@tipo_numero, rua=@rua, bairro=@bairro, estado=@estado, cidade=@cidade, numero_endereco=@numeroCasa where id_cliente=@idcliente;"; 
            cmd.Parameters.AddWithValue("@idcliente", cliente.Idcliente);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNasc);
            cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@rua", cliente.Rua);
            cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@numeroCasa", cliente.NumeroCasa);
            cmd.Parameters.AddWithValue("@ddd", cliente.Ddd);
            cmd.Parameters.AddWithValue("@numero_telefone", cliente.Numero);
            cmd.Parameters.AddWithValue("@tipo_numero", cliente.Tipo);
 
            cmd.ExecuteNonQuery();

            conn.Close();
        }
 
        public void Excluir(int codigo)
        {
            MySqlConnection conn = new Conexao().ObjetoConexao();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@idcliente", codigo);
           
            cmd.CommandText = "DELETE FROM cliente WHERE id_cliente = @idcliente;";        
            cmd.ExecuteNonQuery();


            conn.Close();
        }

        public DataTable PesquisarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from cliente where nome like '%" + valor + "%'", conn);
            
            dadosCliente.Fill(tabela);           
            return tabela;
        }

        public DataTable PesquisarPorCpf(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from cliente where cpf like '%" + valor + "%'", conn);
            
            dadosCliente.Fill(tabela);
            return tabela;
        }

        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select * from cliente;", conn);
            dadosCliente.Fill(tabela);
            return tabela;
        }

        public Cliente carregaCliente(int codigo)
        {
            MySqlConnection conn = new Conexao().ObjetoConexao();
            Cliente cliente = new Cliente();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from cliente where id_cliente =" + codigo.ToString();
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                cliente.Idcliente = Convert.ToInt32(registro["id_cliente"]);
                cliente.Nome = Convert.ToString(registro["nome"]);
                cliente.Cpf = Convert.ToString(registro["cpf"]);
                cliente.Email = Convert.ToString(registro["email"]);
                cliente.DataNasc = Convert.ToString(registro["data_nascimento"]);
                cliente.Sexo = Convert.ToString(registro["sexo"]);
                cliente.Rua = Convert.ToString(registro["rua"]);
                cliente.Bairro = Convert.ToString(registro["bairro"]);
                cliente.Estado = Convert.ToString(registro["estado"]);
                cliente.Cidade = Convert.ToString(registro["cidade"]);
                cliente.NumeroCasa = Convert.ToString(registro["numero_endereco"]);
                cliente.Ddd = Convert.ToString(registro["ddd"]);
                cliente.Numero = Convert.ToString(registro["numero_telefone"]);
                cliente.Tipo = Convert.ToString(registro["tipo_numero"]);
            }
            conn.Close();
            return cliente;
        }
        
        
    }
}
