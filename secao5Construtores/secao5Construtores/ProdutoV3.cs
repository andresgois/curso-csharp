using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao5Construtores
{
    internal class ProdutoV3
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        public ProdutoV3()
        {

        }

        public ProdutoV3(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public ProdutoV3(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Produto [Nome: {Nome} - Quantidade {Quantidade} - Preço: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}]";
        }
    }
}
