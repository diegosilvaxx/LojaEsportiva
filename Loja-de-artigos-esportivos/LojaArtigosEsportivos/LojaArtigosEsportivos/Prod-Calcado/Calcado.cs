using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArtigosEsportivos
{
    public class Calcado
    {
        private int _idCalcado;
        private string _nomeFornecedor;
        private string _marca;
        private string _modelo;
        private string _tamanho;
        private string _cor;
        private int _quantidade;
        private decimal _preco;

        public int IdCalcado
        {
            get { return _idCalcado; }
            set
            {
                _idCalcado = value;
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
        public string Tamanho
        {
            get { return _tamanho; }
            set
            {
                _tamanho = value;
            }
        }
        public string Cor
        {
            get { return _cor; }
            set
            {
                _cor = value;
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
