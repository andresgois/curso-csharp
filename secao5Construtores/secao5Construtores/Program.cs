using System;

namespace secao5Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Tradicional-----");
            Produto produto = new Produto("TV", 500.0, 10);

            // apenas variaveis publicas tem essa possibilidade
            //produto.Quantidade = 100;
            
                        
            Console.WriteLine("Nome: "+produto.GetNome());
            Console.WriteLine(produto);

            Console.WriteLine("------Properties-----");

            ProdutoV2 p = new ProdutoV2("Radio", 120.90, 50);

            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine(p);

            Console.WriteLine("------Auto Properties-----");
            ProdutoV3 p3 = new ProdutoV3("Cola cola Lata", 4.59, 800);
            p3.Nome = p3.Nome = "Mini Coca";

            Console.WriteLine("Quantidade: "+p3.Quantidade);


            Console.WriteLine(p3.Nome);
            Console.ReadKey();
        }
    }
}