using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao10HerancaPolimorfismo.Exemplo1
{
    internal class BusinessAccount : Account
    {
        public double Load { get; set; }

        public BusinessAccount()
        {
            Balance = 0;
        }

        public BusinessAccount(int number, string holder, double balance, double load) : base(number, holder,balance)
        {
            Load = load;
        }

        public void loan(double amount)
        {
            Balance += amount;
        }
    }
}
