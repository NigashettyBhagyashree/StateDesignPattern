using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    internal interface IOrderState
    {
        void Process(Order order);
        void Ship(Order order);
        void Cancel(Order order);
    }
}
