using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    internal class ProcessState : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Order is being processed.");
            order.SetState(new ShippedState());
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship an order that is being processed.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Order is cancelled.");
            order.SetState(new CancelState());
        }
    }
}
