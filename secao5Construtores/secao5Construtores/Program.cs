using System;

namespace secao5Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.0, 10);

            // apenas variaveis publicas tem essa possibilidade
            //produto.Quantidade = 100;
            
                        
            Console.WriteLine("Nome: "+produto.GetNome());
            Console.WriteLine(produto);
            Console.ReadKey();
        }
    }
}