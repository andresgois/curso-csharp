using secao6Listas.Exercicio;
using System;
using System.Globalization;

namespace secao6Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TesteReferencia();
            //TesteStrcut();
            //OperadorDeCoalescenciaNula();
            //Vetores();
            //ExercicioProduto();
            //ExercicioParams();
            ModificadoresParametrosRefOut();
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

        static void Vetores()
        {
            Console.WriteLine("Vetores");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            Console.WriteLine("Digite os valores");
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double media = 0;
            for (int i = 0; i<n; i++)
            {
                media += vet[i];
            }
            media = media / n;
            Console.WriteLine("Media é " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExercicioProduto()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os produtos");
            Produto[] produtos = new Produto[n];

            for(int i = 0;i<n;i++)
            {
                Console.Write("Produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto(name, preco);
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += produtos[i].Preco;
            }
            double media = soma / n;
            Console.WriteLine("Media é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    
    
        static void ExercicioParams()
        {
            Console.WriteLine("ExercicioParams()");
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);
        }
        

        public static void ModificadoresParametrosRefOut()
        {
            //A variável passada como parâmetro ref DEVE ter sido iniciada
            int a = 30;
            //Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            //A variável passada como parâmetro out não precisa ter sido iniciada
            int b = 40;
            int triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);
        }

        public static void Boxing()
        {
            int x = 20;
            Object obj = x;
        }

        public static void Unboxing()
        {
            int x = 20;
            Object obj = x;
            int y = (int) obj;
        }
    }
}