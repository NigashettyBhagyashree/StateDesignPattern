using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    internal class Order
    {
        private IOrderState currentState;

        public Order()
        {
            currentState = new ProcessState();
        }

        public void SetState(IOrderState state)
        {
            currentState = state;
        }

        public void Process()
        {
            currentState.Process(this);
        }

        public void Ship()
        {
            currentState.Ship(this);
        }

        public void Cancel()
        {
            currentState.Cancel(this);
        }
        public void SimulateOrderLifecycle()
        {
            Process();
            Thread.Sleep(3000);
            Ship();
            Thread.Sleep(3000);
            Cancel();
        }
    }
}
