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
        private int _Idcliente;
        private string _nome;
        private string _cpf;
        private string _email;
        private string _dataNasc;
        private string _sexo;
        private string _tipo;
        private string _ddd;
        private string _numero;
        private string _rua;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _numeroCasa;


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

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Ddd
        {
            get { return _ddd; }
            set { _ddd = value; }
        }
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string NumeroCasa
        {
            get { return _numeroCasa; }
            set { _numeroCasa = value; }
        }
    }
}
