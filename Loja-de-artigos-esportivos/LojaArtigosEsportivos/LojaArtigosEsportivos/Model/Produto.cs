using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class Produto
    {
        private int _idProduto;
        private int _idGrupo;
        private int _idFornecedor;
        private string _nomeFornecedor;
        private string _categoria;
        private string _modelo;
        private string _marca;
        private decimal _preco;
        private int _quantidade;
        private string _descricao;


        public int IdProduto
        {
            get { return _idProduto; }
            set
            {
                _idProduto = value;
            }
        }
        public int IdGrupo
        {
            get { return _idGrupo; }
            set
            {
                _idGrupo = value;
            }
        }
        public int IdFornecedor
        {
            get { return _idFornecedor; }
            set
            {
                _idFornecedor = value;
            }
        }
        public string NomeFornecedor
        {
            get { return _nomeFornecedor; }
            set
            {
                _nomeFornecedor = value;
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
        public string Marca
        {
            get { return _marca; }
            set
            {
                _marca = value;
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
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                _preco = value;
            }
        }
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
            }
        }
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                _descricao = value;
            }
        }

    }
}
