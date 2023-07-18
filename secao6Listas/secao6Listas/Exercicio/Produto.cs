using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao6Listas.Exercicio
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Preco { get; set;}

        public Produto()
        {
        }

        public Produto(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }
    }
}
