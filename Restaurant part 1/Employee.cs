using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_part_1
{
    class Employee
    {
        object newOrder;
        int orderCount;

        public Employee()
        { }

        public object NewRequest(int quantity, string MenuItem)
        {
            orderCount++;
            if (orderCount % 3 == 0)
            {
                if (MenuItem == "Egg")
                {
                    MenuItem = "Chicken";
                }
                else
                {
                    MenuItem = "Egg";
                }
            }
            if (MenuItem == "Egg")
            {
                return newOrder = new EggOrder(quantity);
            }

            else if (MenuItem == "Chicken")
            {
                return newOrder = new ChickenOrder(quantity);
            }

            return newOrder;
        }
        public object CopyRequest()
        {
            if (newOrder == null)
            {
                throw new Exception("No orders yet!");
            }
            int quantity = 0;
            string menuItem = "";
            if (newOrder is ChickenOrder )
            {
                menuItem = "Chicken";
                quantity =  ((ChickenOrder)newOrder).GetQuantity();
            }
            if (newOrder is  EggOrder)
            {
                menuItem = "Egg";
                quantity = ((EggOrder) newOrder).GetQuantity();
            }
            return NewRequest(quantity, menuItem);
        }

        public string Inspect(object food)
        {
            if (food is EggOrder )
            {
                return ((EggOrder) newOrder).GetQuality().ToString();
            }
            return "No Inspection!";
        }

        public string? PrepareFood(object food)
        {
            if (food == null)
            {
                throw new Exception("No orders yet!");
            }
            if (food is ChickenOrder)
            {
                for (int i = 0; i < ((ChickenOrder)newOrder).GetQuantity(); i++)
                {
                    ((ChickenOrder)newOrder).CutUp();
                }
                ((ChickenOrder)newOrder).Cook();
                return "Chicken has been Prepared!";
            }

            if (food is EggOrder )
            {
                for (int i = 0; i < ((EggOrder)newOrder).GetQuantity(); i++)
                {
                    try
                    {
                        ((EggOrder)newOrder).Crack();
                    }
                    finally
                    {
                        ((EggOrder)newOrder).DiscardShell();
                    }
                }
                ((EggOrder)newOrder).Cook();
                return "{egg.GetQuantity()} egg has been prepared!";
            }
            return "Order has been completed!";
        }
    }
}