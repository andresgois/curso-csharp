using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace secao4Classes
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { }

        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProduto(int q)
        {
            this.Quantidade += q;
        }

        public void RemoverProduto(int q)
        {
            this.Quantidade -= q;
        }

        public string Exibir()
        {
            return "Dados do produto: "
                + this.Nome
                + ",$ "
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this.Quantidade
                + ", total: $ "
                + this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Dados do produto: "
                + this.Nome
                + ",$ "
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this.Quantidade
                + ", total: $ "
                + this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
