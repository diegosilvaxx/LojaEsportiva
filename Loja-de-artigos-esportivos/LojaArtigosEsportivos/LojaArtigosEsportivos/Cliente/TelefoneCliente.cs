using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class TelefoneCliente
    {
        private string _idTelefone;
        private string _tipo;
        private string _ddd;
        private string _numero;

        public string IdTelefone
        {
            get { return _idTelefone; }
            set { _idTelefone = value; }
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
