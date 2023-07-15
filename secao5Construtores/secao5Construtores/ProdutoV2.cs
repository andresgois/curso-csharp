using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace secao5Construtores
{
    internal class ProdutoV2
    {
        private string _nome;
        private int _quantidade;
        private double _preco;

        public ProdutoV2()
        {

        }

        public ProdutoV2(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public ProdutoV2(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome;}
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public override string ToString()
        {
            return $"Produto [Nome: {Nome} - Quantidade {Quantidade} - Preço: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}]";
        }
    }
}
