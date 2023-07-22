using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao7Topicos1.Aulas
{
    internal class TimeSpanTeste
    {
        public static void PrintTimeSpanTeste() {
            Console.WriteLine("TimeSpan");

            TimeSpan t = new TimeSpan(0, 1, 30);
            Console.WriteLine(t);
            Console.WriteLine(t.Ticks);

            Console.WriteLine("Demo - construtores");
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine("Demo - métodos From");
             t1 = TimeSpan.FromDays(1.5);
             t2 = TimeSpan.FromHours(1.5);
             t3 = TimeSpan.FromMinutes(1.5);
             t4 = TimeSpan.FromSeconds(1.5);
             t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

        }
    }
}
