using secao10HerancaPolimorfismo.Exemplo1;

namespace secao10HerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TesteProtected();

        }

        public static void TesteProtected()
        {
            Console.WriteLine("TesteProtected");
            BusinessAccount b = new BusinessAccount(120, "Teste", 100.0, 500.0);
            Console.WriteLine(b.Balance);

            // não exibe, pois o atributo é protegido
            //b.Balance = 10;
        }
    }
}