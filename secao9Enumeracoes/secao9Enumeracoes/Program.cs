using secao9Enumeracoes.Enumeracoes;

namespace secao9Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Enumerações ------------");
            Enumeracoes();
        }

        public static void Enumeracoes()
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine($"Order {order.Id}");

            //Para o tipo original: use casting
            OrderStatus os1 = (OrderStatus)2;
            int n1 = (int)OrderStatus.Processing;
            //string -> enum:
            string txt = OrderStatus.PendingPayment.ToString();
            //enum -> string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}