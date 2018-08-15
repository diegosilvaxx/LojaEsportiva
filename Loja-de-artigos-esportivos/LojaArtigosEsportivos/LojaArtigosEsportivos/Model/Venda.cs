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
        private int _idCompra;
        private int _idCliente;
        private string _nomeCliente;
        private decimal _valorTotal;



        public int IdCompra
        {
            get { return _idCompra; }
            set
            {
                _idCompra = value;
            }
        }
        public int IdCliente
        {
            get { return _idCliente; }
            set
            {
                _idCliente = value;
            }
        }
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set
            {
                _nomeCliente = value;
            }
        }
        public decimal ValorTotal
        {
            get { return _valorTotal; }
            set
            {
                _valorTotal = value;
            }
        }
    }
}
