using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class Fornecedor
    {
        //Instancia um objeto do tipo TelefoneFornecedor para armazenar os dados do fornecedor
        public TelefoneFornecedor telefoneFornecedor = new TelefoneFornecedor();
        //Atributos privados da classe Fornecedor
        private int _idFornecedor;
        private string _nome;
        private string _cnpj;
        private string _email;
        //Atributos publicos da classe Fornecedor
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


    }
}
