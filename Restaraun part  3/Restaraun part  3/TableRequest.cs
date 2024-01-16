using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    public enum FoodStatus
    {
        None,
        Ordered,
        Prepared,
        Served
    }
    public class TableRequest
    {
        public string requestStatus = "none";
        Dictionary<int, List<IMenuItem>> tableRequest = new Dictionary<int, List<IMenuItem>>();

        public void Add(int customer, IMenuItem menuItem)
        {
            int counter;
            if (!isCustomerExist(customer)) //false
            {
                counter = tableRequest.Count();
                if (counter == 8)
                {
                    ///
                }
                tableRequest[customer] = new List<IMenuItem>() { menuItem };
            }
            else
            {
                tableRequest[customer].Add(menuItem);
                // throw new Exception("This customer has already ordered!");
            }
            requestStatus = "ordered";
        }

        public IMenuItem[] this[int customerNumber]
        {
            get
            {
                return tableRequest[customerNumber].ToArray();
            }
        }

        public IMenuItem[] this[IMenuItem item]
        {
            get
            {
                IMenuItem[] menuItemArray = new IMenuItem[0];
                foreach (var request in tableRequest)
                {
                    foreach (var order in request.Value)
                    {
                        if (order.GetType() == item.GetType())
                        {
                            Array.Resize(ref menuItemArray, menuItemArray.Length + 1);
                            menuItemArray[menuItemArray.Length - 1] = order;
                        }
                    }
                }
                return menuItemArray;
            }
        }
        public int GetCustomerNumbers()
        {
            return tableRequest.Count();
        }

        private bool isCustomerExist(int customerId)
        {
            return tableRequest.ContainsKey(customerId);
        }
    }
}
