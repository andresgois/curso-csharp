using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secao5Construtores
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 0;
        }

        // Reaproveita o construtor acima
        public Produto(string nome, double preco)
            : this()
        {
            Nome = nome;
            Preco = preco;
        }

        // Reaproveita o construtor acima
        public Produto(string nome, double preco, int quantidade)
            : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}
