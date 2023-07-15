using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao5Construtores
{
    internal class Produto
    {
        private string _nome;
        private int _quantidade;
        private double _preco;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade): this(nome, preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome=nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public override string ToString()
        {
            return $"Produto [Nome: {GetNome()} - Quantidade {GetQuantidade()} - Preço: R$ {GetPreco()}]";
        }
    }
}
