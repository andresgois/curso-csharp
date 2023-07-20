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
            //ModificadoresParametrosRefOut();
            //LacoForEach();
            ListaFase1();
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
            Console.WriteLine("ModificadoresParametrosRefOut");
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

        public static void LacoForEach()
        {
            Console.WriteLine("LacoForEach()");
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }

        public static void ListaFase1()
        {
            
            List<int> list2 = new List<int>() { 12,6,9,78};
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>();
            list.Add("Ana");
            list.Add("Beatriz");
            list.Add("Priscila");
            list.Add("Lima");
            list.Add("Jo");
            list.Add("Fany");
            // insere em qualquer posição
            list.Insert(0, "Andre");

            foreach (var item in list)
            {
                Console.WriteLine("Nome: " + item);
            }

            //string s1 = list.Find(Test);
            string s1 = list.Find(x => x[0]=='A');
            Console.WriteLine(s1);

            // última ocorrencia
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            // última ocorrencia
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            Console.WriteLine("-----------FindAll---------------");
            // string maiores que 5
            List<string> list3 = list.FindAll(x => x.Length > 5);
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------Remove--------------");
            list.Remove("Andre");
            foreach (var item in list)
            {
                Console.WriteLine("Nome: " + item);
            }
            Console.WriteLine("------------RemoveAll--------------");
            list.RemoveAll(x => x.Length > 5);
            foreach (var item in list)
            {
                Console.WriteLine("Nome: " + item);
            }
            Console.WriteLine("------------RemoveAt--------------");
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine("Nome: " + item);
            }
            Console.WriteLine("-------------RemoveRange-------------");
            list.RemoveRange(2,1);
            foreach (var item in list)
            {
                Console.WriteLine("Nome: " + item);
            }

        }

        public static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}