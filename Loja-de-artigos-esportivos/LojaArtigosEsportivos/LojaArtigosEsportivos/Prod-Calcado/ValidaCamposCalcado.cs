using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ValidaCamposCalcado
    {
        public int ValidarCampos(Calcado calcado)
        {
            if (string.IsNullOrEmpty(calcado.Marca))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(calcado.Modelo))
            {
                return 2;
            }
            if (string.IsNullOrEmpty(calcado.Cor))
            {
                return 3;
            }
            if (string.IsNullOrEmpty(calcado.Tamanho))
            {
                return 4;
            }
            if (calcado.Quantidade == 0)
            {
                return 5;
            }
            if (calcado.Preco == 0)
            {
                return 6;
            }
            return 0;
        }
    }
}
