using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class Grupo
    {
        private int _idGrupo;
        private string _categoria;
        private char _estadoCategoria;


        public int IdGrupo
        {
            get { return _idGrupo; }
            set
            {
                _idGrupo = value;
            }
        }
        public string Categoria
        {
            get { return _categoria; }
            set
            {
                _categoria = value;
            }
        }
        public char EstadoCategoria
        {
            get { return _estadoCategoria; }
            set
            {
                _estadoCategoria = value;
            }
        }
    }
}
