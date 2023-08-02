using secao10HerancaPolimorfismo.Exemplo1;

namespace secao10HerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TesteProtected();
            upcasting();
        }

        public static void TesteProtected()
        {
            Console.WriteLine("TesteProtected");
            BusinessAccount b = new BusinessAccount(120, "Teste", 100.0, 500.0);
            Console.WriteLine(b.Balance);

            // não exibe, pois o atributo é protegido
            //b.Balance = 10;
        }

        public static void upcasting() {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            // A variavel Account recebe qualquer tipo de subclasse dela
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            // Operação insegura
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.loan(100.0);

            // Só é permitida essa operação se fizer o downcast de acc3
            //acc3.loan(20.00);

            // Erro em tempo de execução, pois,  BusinessAccount não é do tipo SavingsAccount
            // BusinessAccount acc5 = (BusinessAccount)acc3;

            // verifica se é uma instância de BusinessAccount
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}