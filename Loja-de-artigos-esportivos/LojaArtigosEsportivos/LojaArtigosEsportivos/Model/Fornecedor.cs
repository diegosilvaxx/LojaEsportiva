using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class Fornecedor
    {
        
        private int _idFornecedor;
        private string _nome;
        private string _cnpj;
        private string _email;
        private string _tipo;
        private string _ddd;
        private string _numero;

        public int IdFornecedor
        {
            get { return _idFornecedor; }
            set { _idFornecedor = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cnpj
        {
            get { return _cnpj; }
            set
            {
                if (ValidarCamposFornecedor.ValidaCnpj(value))
                {
                    _cnpj = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (ValidarCamposFornecedor.ValidarEmail(value))
                {
                    _email = value;
                }
            }
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

    }
}
