using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace LojaArtigosEsportivos
{
    public class Cliente
    {

        //Instancia um objeto do tipo EnderecoCliente para armazenar os dados do cliente
        public EnderecoCliente enderecoCliente = new EnderecoCliente();
        //Instancia um objeto do tipo TelefoneCliente para armazenar os dados do cliente
        public TelefoneCliente telefoneCliente = new TelefoneCliente();
        //Atributos privados da classe Cliente
        private int _Idcliente;
        private string _nome;
        private string _cpf;
        private string _email;
        private string _dataNasc;
        private string _sexo;        
       
        //Atributos publicos da classe Cliente
        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
            
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (ValidarCamposCliente.ValidaCPF(value))
                {
                    _cpf = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (ValidarCamposCliente.ValidarEmail(value))
                {
                    _email = value;
                }
            }
        }
        public string DataNasc
        {
            get { return _dataNasc; }
            set
            {
                if (ValidarCamposCliente.validarData(value))
                {
                    _dataNasc = value;
                }                
            }
        }
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

    }
}
