using System;

namespace secao6Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TesteReferencia();
            //TesteStrcut();
            OperadorDeCoalescenciaNula();
        }

        static void TesteReferencia()
        {
            Console.WriteLine("Teste referência");
            Product p = new Product(1, "TV", "LCD");
            Console.WriteLine(p.ToString());
            Product pRef = p;
            Console.WriteLine(pRef.ToString());

            p.Name = "Test";
            Console.WriteLine(p.ToString());
            Console.WriteLine(pRef.ToString());
            //Product pRef2 = null;
            //Console.WriteLine(pRef2.ToString());

            string a = "A";
            string b = a;
            Console.WriteLine("a: "+a);
            Console.WriteLine("b: "+b);
            a = "Mudou";
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    
        static void TesteStrcut()
        {
            Point p1;
            //Console.WriteLine(p); // erro: variável não atribuída
            p1.X = 10;
            p1.Y = 20;
            Console.WriteLine(p1);
            Point p2 = new Point();
            Console.WriteLine(p2);
            Point p3 = p1;
            Console.WriteLine(p3);

            Console.WriteLine("Criou uma cópia e não apontou pra ele");
            p1.X = 100;
            Console.WriteLine(p1);
            Console.WriteLine(p3);

        }
        
        static void OperadorDeCoalescenciaNula()
        {
            //double x = null; // erro
            Nullable<double> p = null;
            Console.WriteLine("p "+p);

            double? x = null;

            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            

            Console.WriteLine(y.Value);

            String estaNula = null;
            Console.WriteLine(estaNula);
            String vaiReceberUmValor = estaNula ?? "não esta nula";
            Console.WriteLine(vaiReceberUmValor);

            estaNula = "Novo";
            vaiReceberUmValor = estaNula ?? "Erro";
            Console.WriteLine(vaiReceberUmValor);

        }


    }
}