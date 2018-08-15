using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class EnderecoCliente
    {
        private string _idEndereco;
        private string _rua;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _numeroCasa;

        public string IdEndereco
        {
            get { return _idEndereco; }
            set { _idEndereco = value; }
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
