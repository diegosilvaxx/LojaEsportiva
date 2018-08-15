using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class UsuarioSistema
    {
        private int _idUsuario;
        private string _nome;
        private string _usuario;
        private string _senha;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set
            {
                _idUsuario = value;
            }
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }
        public string Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
            }
        }
        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;   
            }
        }
    }
}
