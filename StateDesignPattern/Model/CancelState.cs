using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    internal class CancelState:IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Cannot process a cancelled order.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship a cancelled order.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Order is already cancelled.");
        }
    }
}
