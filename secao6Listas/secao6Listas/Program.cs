using System;

namespace secao6Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TesteReferencia();
            TesteStrcut();
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
    }
}