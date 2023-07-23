using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao7Topicos1.Aulas
{
    internal class DateTime2
    {
        public static void PrintDateTime()
        {
            Console.WriteLine("Propriedades e Operações com\r\nDateTime");

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("Formatação (DateTime -> string)");
             d = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("");
            Console.WriteLine("Operações com Datetime");
            DateTime x = DateTime.Now;
            //DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(2);
            DateTime y1 = x.AddHours(3);
            DateTime y2 = x.AddMilliseconds(200);
            DateTime y3 = x.AddMinutes(34);
            DateTime y4 = x.AddMonths(1);
            DateTime y5 = x.AddSeconds(23);
            DateTime y6 = x.AddTicks(1223);
            DateTime y7 = x.AddYears(23);

            // diferença entre datas
            DateTime dia15 = new DateTime(2023, 05, 15);
            DateTime hoje = DateTime.Now;
            //DateTime y8 = hoje.Subtract(dia15);
            TimeSpan t = hoje.Subtract(dia15);

            Console.WriteLine(y);
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
            Console.WriteLine(y5);
            Console.WriteLine(y6);
            Console.WriteLine(y7);
            //Console.WriteLine(y8);
            Console.WriteLine(t);

        }

    }
}
