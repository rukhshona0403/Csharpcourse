using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    class Order
    {
        int quantity;

        public Order(int Quantity)
        {
            quantity = Quantity;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        protected virtual void Cook()
        { }

        public void SubtractQuantity()
        {
            quantity--;
        }

        public virtual void Prepare()
        { }
    }
}
