using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class Venda
    {
        public ProdutosVenda  produtosVenda = new ProdutosVenda();
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
