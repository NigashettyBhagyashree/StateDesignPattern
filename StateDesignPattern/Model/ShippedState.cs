using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    internal class ShippedState:IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Cannot process an order that is already shipped.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Order is shipped.");
            order.SetState(new ProcessState());
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Cannot cancel an order that is already shipped.");
        }
    }
}
