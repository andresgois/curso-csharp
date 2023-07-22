using System;
using System.Globalization;

namespace secao7Topicos1.Aulas
{
    internal class FuncaoDateTime
    {
        public static void PrintFuncaoDateTime() {
            Console.WriteLine("DateTime\r\n");
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            //O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum
            Console.WriteLine(d.Ticks);

            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("Demo - Now, UtcNow, Today");
            DateTime f1 = DateTime.Now;
            DateTime f2 = DateTime.UtcNow;
            DateTime f3 = DateTime.Today;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);

            Console.WriteLine("Demo - Parse");
            DateTime g1 = DateTime.Parse("2000-08-15");
            DateTime g2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime g3 = DateTime.Parse("15/08/2000");
            DateTime g4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);
            Console.WriteLine(g4);

            Console.WriteLine("Demo - ParseExact");
            DateTime q1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);
            DateTime q2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(q1);
            Console.WriteLine(q2);




        }
    }
}
