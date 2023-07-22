using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao7Topicos1.Aulas
{
    internal class Ternario
    {

        public static void PrintTernario()
        {
            double preco = 34.5;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto
                .ToString("F2"));
        }
    }
}
