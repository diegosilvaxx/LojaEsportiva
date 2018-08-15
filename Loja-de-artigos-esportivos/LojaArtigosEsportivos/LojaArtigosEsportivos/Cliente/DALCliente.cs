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
        //Cria um objeto do tipo AcessoBD
        private AcessoBD objConexao;
        //Sobrecarga do construtor que recebe a string de conexão do banco de dados
        public DALCliente(AcessoBD conexao)
        {
            objConexao = conexao;
        }
        //Metodo que atribui nos parametros os atributos do objeto Cliente e faz o cadastro no banco
        public void Inserir(Cliente cliente)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que insere na tabela Cliente do banco
            cmd.CommandText = "insert into cliente(nome, cpf, email, data_nascimento, sexo) values (@nome, @cpf, @email, @data_nascimento, @sexo);";         
            //Adicionando os atributos do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);            
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNasc);
            cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);     

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Essa variavel pegara no banco o ultimo id registrado e a armazenará
            int idcliente = Convert.ToInt32(cmd.LastInsertedId);

            //Comando que insere na tabela Endereco do banco
            cmd.CommandText = "insert into endereço(rua, bairro, estado, cidade, numero, id_cliente) values (@rua, @bairro, @estado, @cidade, @numero, @id_cliente);";
            //Adicionando os atributos do objeto Endereco nos parametros
            cmd.Parameters.AddWithValue("@id_cliente", idcliente);
            cmd.Parameters.AddWithValue("@rua", cliente.enderecoCliente.Rua);
            cmd.Parameters.AddWithValue("@bairro", cliente.enderecoCliente.Bairro);
            cmd.Parameters.AddWithValue("@estado", cliente.enderecoCliente.Estado);
            cmd.Parameters.AddWithValue("@cidade", cliente.enderecoCliente.Cidade);
            cmd.Parameters.AddWithValue("@numero", cliente.enderecoCliente.NumeroCasa);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Comando que insere na tabela Telefone do banco
            cmd.CommandText = "insert into telefone(ddd, numero_telefone, tipo, id_cliente) values (@ddd, @numero_telefone, @tipo, @id_cliente);";
            //Adicionando os atributos do objeto Telefone nos parametros
            cmd.Parameters.AddWithValue("@ddd", cliente.telefoneCliente.Ddd);
            cmd.Parameters.AddWithValue("@numero_telefone", cliente.telefoneCliente.Numero);
            cmd.Parameters.AddWithValue("@tipo", cliente.telefoneCliente.Tipo);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Fecha a conexao do banco
            objConexao.Desconectar();
        }

        //Metodo que atribui nos parametros os atributos do objeto Cliente e faz a alteraçao no banco
        public void Alterar(Cliente cliente)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que altera na tabela Cliente do banco
            cmd.CommandText = "update cliente set nome=@nome,cpf=@cpf,email=@email,data_nascimento=@data_nascimento, sexo=@sexo where id_cliente=@idcliente;";            
            //Adicionando os atributos do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@idcliente", cliente.Idcliente);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNasc);
            cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Comando que altera na tabela Endereco do banco
            cmd.CommandText = "update endereço set rua=@rua,bairro=@bairro,estado=@estado,cidade=@cidade,numero=@numero where id_cliente=@idcliente;";
            //Adicionando os atributos do objeto Endereco nos parametros
            cmd.Parameters.AddWithValue("@rua", cliente.enderecoCliente.Rua);
            cmd.Parameters.AddWithValue("@bairro", cliente.enderecoCliente.Bairro);
            cmd.Parameters.AddWithValue("@estado", cliente.enderecoCliente.Estado);
            cmd.Parameters.AddWithValue("@cidade", cliente.enderecoCliente.Cidade);
            cmd.Parameters.AddWithValue("@numero", cliente.enderecoCliente.NumeroCasa);

            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();

            //Comando que altera na tabela Telefone do banco
            cmd.CommandText = "update telefone set ddd=@ddd,numero_telefone=@numero_telefone,tipo=@tipo where id_cliente = @idcliente;";
            //Adicionando os atributos do objeto Telefone nos parametros
            cmd.Parameters.AddWithValue("@ddd", cliente.telefoneCliente.Ddd);
            cmd.Parameters.AddWithValue("@numero_telefone", cliente.telefoneCliente.Numero);
            cmd.Parameters.AddWithValue("@tipo", cliente.telefoneCliente.Tipo);
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que identifica a chave primaria do Cliente e seta no parametro e faz a exclusao do mesmo no banco
        public void Excluir(int codigo)
        {
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Abre a conexao do banco
            objConexao.Conectar();
            //Comando que deleta na tabela Cliente do banco
            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0;";
            //Adicionando o atributo primario do objeto Cliente nos parametros
            cmd.Parameters.AddWithValue("@idcliente", codigo);
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Comando que deleta na tabela Cliente do banco
            cmd.CommandText = "DELETE FROM cliente, endereço, telefone USING cliente, endereço, telefone WHERE cliente.id_cliente = @idcliente AND endereço.id_cliente = @idcliente AND telefone.id_cliente = @idcliente;";
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Comando que deleta na tabela Cliente do banco
            cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 1;";
            //Executa as linhas de comandos
            cmd.ExecuteNonQuery();
            //Fecha a conexao do banco
            objConexao.Desconectar();
        }
        //Metodo que faz a pesquisa de cliente no banco por nome
        public DataTable PesquisarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select c.id_cliente, c.nome,c.sexo,c.data_nascimento,c.email,c.cpf, t.tipo, t.ddd,t.numero_telefone, e.rua, e.numero, e.bairro, e.cidade, e.estado from cliente c join telefone t on c.id_cliente = t.id_cliente join endereço e on c.id_cliente = e.id_cliente where c.nome like '%" + valor + "%'", objConexao.StringConexao);
            
            dadosCliente.Fill(tabela);           
            return tabela;
        }
        //Metodo que faz a pesquisa de cliente no banco por cpf
        public DataTable PesquisarPorCpf(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select c.id_cliente, c.nome,c.sexo,c.data_nascimento,c.email,c.cpf, t.tipo, t.ddd,t.numero_telefone, e.rua, e.numero, e.bairro, e.cidade, e.estado from cliente c join telefone t on c.id_cliente = t.id_cliente join endereço e on c.id_cliente = e.id_cliente where c.cpf like '%" + valor + "%'", objConexao.StringConexao);
            
            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que faz a pesquisa de cliente no banco
        public DataTable Pesquisar()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("select c.id_cliente, c.nome,c.sexo,c.data_nascimento,c.email,c.cpf, t.tipo, t.ddd,t.numero_telefone, e.rua, e.numero, e.bairro, e.cidade, e.estado from cliente c join telefone t on c.id_cliente = t.id_cliente join endereço e on c.id_cliente = e.id_cliente;", objConexao.StringConexao);
            dadosCliente.Fill(tabela);
            return tabela;
        }
        //Metodo que tras do banco os dados do Cliente e armazena-os em seus atributos da classe
        public Cliente carregaCliente(int codigo)
        {
            //Cria um objeto do tipo Cliente que irá armazenar os dados que virao do banco
            Cliente cliente = new Cliente();
            //Cria um objeto do tipo MySqlCommand que irá armazenar os comando que vão para o banco
            MySqlCommand cmd = new MySqlCommand();
            //Atribui no comando Connection o metodo do objeto de conexao com o banco
            cmd.Connection = objConexao.ObjetoConexao;
            //Comando que pesquisa na tabela Cliente,Endereco,Telefone do banco
            cmd.CommandText = "select c.id_cliente, c.nome,c.sexo,c.data_nascimento,c.email,c.cpf, t.tipo, t.ddd,t.numero_telefone, e.rua, e.numero, e.bairro, e.cidade, e.estado from cliente c join telefone t on c.id_cliente = t.id_cliente join endereço e on c.id_cliente = e.id_cliente where c.id_cliente =" + codigo.ToString();
            //Abre a conexao do banco
            objConexao.Conectar();
            //Cria um objeto do tipo MySqlDataReader e executa as linhas de comandos no banco como leitura
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
                cliente.enderecoCliente.Rua = Convert.ToString(registro["rua"]);
                cliente.enderecoCliente.Bairro = Convert.ToString(registro["bairro"]);
                cliente.enderecoCliente.Estado = Convert.ToString(registro["estado"]);
                cliente.enderecoCliente.Cidade = Convert.ToString(registro["cidade"]);
                cliente.enderecoCliente.NumeroCasa = Convert.ToString(registro["numero"]);
                cliente.telefoneCliente.Ddd = Convert.ToString(registro["ddd"]);
                cliente.telefoneCliente.Numero = Convert.ToString(registro["numero_telefone"]);
                cliente.telefoneCliente.Tipo = Convert.ToString(registro["tipo"]);
            }
            return cliente;
        }
        
        
    }
}
