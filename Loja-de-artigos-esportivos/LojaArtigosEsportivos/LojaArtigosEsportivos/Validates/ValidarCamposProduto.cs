using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ValidarCamposProduto
    {
        public int ValidarCampos(Produto produto)
        {
            if (string.IsNullOrEmpty(produto.Marca))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(produto.Modelo))
            {
                return 2;
            }
            if (string.IsNullOrEmpty(produto.Descricao))
            {
                return 3;
            }
            if (produto.Quantidade == 0)
            {
                return 4;
            }
            if (produto.Preco == 0)
            {
                return 5;
            }
            if (string.IsNullOrEmpty(produto.Categoria))
            {
                return 6;
            }
            return 0;
        }
    }
}
