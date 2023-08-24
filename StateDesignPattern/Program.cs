using StateDesignPattern.Model;

namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            
            order.SimulateOrderLifecycle();

        }
    }
}