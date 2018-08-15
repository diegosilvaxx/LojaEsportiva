using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ProdutosVenda
    {
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        public string Modelo { get; set; }
        public string TipoProduto { get; set; }
        public int QtdProduto { get; set; }
        public decimal Preco { get; set; }
    }
}
