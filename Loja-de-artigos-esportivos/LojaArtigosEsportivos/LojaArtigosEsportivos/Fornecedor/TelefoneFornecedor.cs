using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class TelefoneFornecedor
    {
        //Atributos privados da classe TelefoneFornecedor
        private string _tipo;
        private string _ddd;
        private string _numero;
        //Atributos publicos da classe TelefoneFornecedor
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
