using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class ProdutosVenda
    {
        private int _idProduto;
        private int _idCompra;
        private string _modelo;
        private string _categoria;
        private int _qtdProduto;
        private decimal _preco;

        public int IdProduto
        {
            get { return _idProduto; }
            set
            {
                _idProduto = value;
            }
        }
        public int IdCompra
        {
            get { return _idCompra; }
            set
            {
                _idCompra = value;
            }
        }
        public string Modelo
        {
            get { return _modelo; }
            set
            {
                _modelo = value;
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
        public int QtdProduto
        {
            get { return _qtdProduto; }
            set
            {
                _qtdProduto = value;
            }
        }
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                _preco = value;
            }
        }
    }
}
