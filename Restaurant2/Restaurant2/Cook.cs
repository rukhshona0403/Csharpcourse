using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    class Cook
    {
        public Order Submit(MenuItem menuItem, int quantity)
        {
            Order order = null;
            switch (menuItem)
            {
                case MenuItem.Chicken:
                    order = new ChickenOrder(quantity);
                    break;
                case MenuItem.Egg:
                    order = new EggOrder(quantity);
                    break;
            }
            return order;
        }
        public void Prepare(Order order)
        {
            order.Prepare();
        }
    }
}
