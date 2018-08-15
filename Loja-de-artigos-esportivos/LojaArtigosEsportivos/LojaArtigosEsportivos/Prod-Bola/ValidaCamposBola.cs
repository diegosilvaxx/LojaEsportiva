using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ValidaCamposBola
    {
        public int ValidarCampos(Bola bola)
        {
            if (string.IsNullOrEmpty(bola.Marca))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(bola.Modelo))
            {
                return 2;
            }
            if (string.IsNullOrEmpty(bola.Cor))
            {
                return 3;
            }
            if (string.IsNullOrEmpty(bola.Calibragem))
            {
                return 4;
            }
            if (bola.Quantidade == 0)
            {
                return 5;
            }
            if (bola.Preco == 0)
            {
                return 6;
            }
            return 0;
        }
    }
}
