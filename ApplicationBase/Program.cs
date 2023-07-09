// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine("----------------------------------------");
            double s = 24.36944;
            Console.WriteLine(s);
            Console.WriteLine(s.ToString("F2"));
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("----------------------------------------");
            int idade = 32;
            double saldo = 10.35784;
            string nome2 = "Maria";
            Console.WriteLine(
                "{0} tem {1} anos e tem saldo igual a {2:F2} reais",
                nome2,
                idade,
                saldo
            );
            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(
                nome2
                    + " tem "
                    + idade
                    + " anos e tem saldo igual a "
                    + saldo.ToString("F2", CultureInfo.InvariantCulture)
                    + " reais"
            );
            Console.WriteLine("------------------Operadores aritméticos----------------------");
             n1 = 3 + 4 * 2;
             n2 = (3 + 4) * 2;
             n3 = 17 % 3;
            double n14 = 10.0 / 8.0;
            double a = 1.0,
                b = -3.0,
                c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n14);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine("------------------Conversão implícita e casting----------------------");
            double a1;
            float b1;
            a1 = 5.1;
            b1 = (float)a1;
            Console.WriteLine(b1);
            double a2;
            int b2;
            a2 = 5.1;
            b2 = (int)a2;
            Console.WriteLine(b2);
        }
    }
}
