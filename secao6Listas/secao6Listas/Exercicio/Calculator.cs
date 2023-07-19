using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao6Listas.Exercicio
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void TripleRef(int x)
        {
            x = x * 3;
        }

        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }

}
