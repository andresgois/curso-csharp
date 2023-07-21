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
            //ListaFase1();
            //ExercicioEmployee();
            //Matriz();
            Exercicio01Matriz();
            Console.WriteLine("////////////////");
            Exercicio02atriz();
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

        public static void ExercicioEmployee()
        {
            Console.WriteLine("ExercicioEmployee()");
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee>  employee = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #"+(i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine()) ;

            Console.WriteLine();
            Employee emp = employee.Find(e => e.Id == id2);

            if( emp == null )
            {
                Console.WriteLine("This id does not exist!");
            }
            else{
                double increment = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncrementSalary(increment);

                Console.Write("Enter the percentage: ");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee item in employee)
            {
                Console.WriteLine(item);
            }

        }

        public static void Matriz()
        {
            double[,] mat = new double[2, 3];
            // Tamanho = 2*3 = 6
            Console.WriteLine(mat.Length);
            // 2
            Console.WriteLine(mat.Rank);
            // Tamanho linha 2
            Console.WriteLine(mat.GetLength(0));
            // Tamanho coluna 3
            Console.WriteLine(mat.GetLength(1));
        }

        public static void Exercicio01Matriz()
        {
            /**
             * Fazer um programa para ler um número inteiro N e uma matriz de
                ordem N contendo números inteiros. Em seguida, mostrar a diagonal
                principal e a quantidade de valores negativos da matriz.
             * */
            Console.Write("Digite um valor para linha e coluna: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            Console.Write("Digite os valores da primeira linha separando por espaço: ");
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

            /*
             * 3
                5 -3 10
                15 8 2
                7 9 -4
            Main diagonal:
            5 8 -4
            Negative numbers: 2
             * */
        }

        public static void Exercicio02atriz()
        {
            /*
             * Fazer um programa para ler dois números inteiros M e N, e depois ler
            uma matriz de M linhas por N colunas contendo números inteiros,
            podendo haver repetições. Em seguida, ler um número inteiro X que
            pertence à matriz. Para cada ocorrência de X, mostrar os valores à
            esquerda, acima, à direita e abaixo de X, quando houver, conforme
            exemplo.
             * */
            Console.Write("Digite um valor para linha e coluna: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            Console.Write("Digite os valores da primeira linha separando por espaço: ");
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.Write("Digite o número que quer procurar: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            /*
             3 4
            10 8 15 12
            21 11 23 8
            14 5 13 19
            8
            Position 0,1:
            Left: 10
            Right: 15
            Down: 11
            Position 1,3:
            Left: 23
            Up: 12
            Down: 19
             */
        }
    }
}